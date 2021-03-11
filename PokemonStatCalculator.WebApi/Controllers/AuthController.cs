using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NLog;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.WebApi.Models.Authentication;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> signInManager;

        private readonly UserManager<IdentityUser> userManager;

        private readonly AppSettings jsonWebTokenSettings;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public AuthController(
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            IOptions<AppSettings> jsonWebTokenSettings)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.jsonWebTokenSettings = jsonWebTokenSettings.Value;
        }

        [HttpPost("new-account")]
        public async Task<IActionResult> Register(RegisterUserViewModel registerUser)
        {
            try
            {
                logger.Info("Requested user registration {0}", registerUser.UserName);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
                }

                var user = new IdentityUser
                {
                    UserName = registerUser.UserName,
                    Email = registerUser.Email,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, registerUser.Password);

                if (!result.Succeeded)
                {
                    logger.Warn("Invalid user registration {0}", result.ToJson());

                    return BadRequest(result.Errors);
                }

                await signInManager.SignInAsync(user, false);

                logger.Info("User registered {0}", user.UserName);

                return Ok(GenerateJwt());
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, ex.Message);

                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserViewModel loginUser)
        {
            try
            {
                logger.Info("Requested user login {0}", loginUser.UserName);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
                }

                var result = await signInManager.PasswordSignInAsync(loginUser.UserName, loginUser.Password, false, true);

                if (result.Succeeded)
                {
                    logger.Info("Login confirmed {0}", loginUser.UserName);

                    return Ok(GenerateJwt());
                }

                logger.Warn("Invalid credentials {0}", result.ToJson());

                return BadRequest("The credentials are invalid.");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, ex.Message);

                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }        
        }

        private string GenerateJwt()
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                var key = Encoding.ASCII.GetBytes(jsonWebTokenSettings.Secret);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Issuer = jsonWebTokenSettings.Issuer,
                    Audience = jsonWebTokenSettings.ValidIn,
                    Expires = DateTime.UtcNow.AddMinutes(jsonWebTokenSettings.ExpirationInMinutes),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
            }
            catch (ArgumentNullException ex)
            {
                logger.Fatal(ex, ex.Message);

                throw ex;
            }
            catch (SecurityTokenEncryptionFailedException ex)
            {
                logger.Fatal(ex, ex.Message);

                throw ex;
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);

                throw ex;
            }
        }
    }
}