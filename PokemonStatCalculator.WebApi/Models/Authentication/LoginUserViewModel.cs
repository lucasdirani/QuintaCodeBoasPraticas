using System.ComponentModel.DataAnnotations;

namespace PokemonStatCalculator.WebApi.Models.Authentication
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [EmailAddress(ErrorMessage = "The field {0} is in an invalid format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(10, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 6)]
        public string Password { get; set; }
    }
}