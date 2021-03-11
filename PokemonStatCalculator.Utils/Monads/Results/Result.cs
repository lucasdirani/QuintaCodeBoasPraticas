using System;

namespace PokemonStatCalculator.Utils.Monads.Results
{
    public class Result
    {
        protected Result(bool isSuccess, string[] errors)
        {
            if (isSuccess && errors.Length > 0)
            {
                throw new InvalidOperationException("Errors can't be filled in the case of success.");
            }

            if (!isSuccess && errors.Length == 0)
            {
                throw new InvalidOperationException("Errors can't be empty in the case of failure.");
            }

            IsSuccess = isSuccess;
            Errors = errors;
        }

        protected Result(bool isSucess, string error)
            : this(isSucess, new string[] { error })
        {
        }

        public bool IsSuccess { get; private set; }

        public string[] Errors { get; private set; }

        public bool Failure => !IsSuccess;

        public static Result Success()
        {
            return new Result(true, new string[] { });
        }

        public static Result<T> Success<T>(T value)
        {
            return new Result<T>(value, true, new string[] { });
        }

        public static Result Fail(string[] messages)
        {
            return new Result(false, messages);
        }

        public static Result Fail(string message)
        {
            return Fail(new string[] { message });
        }

        public static Result<T> Fail<T>(string[] messages)
        {
            return new Result<T>(default, false, messages);
        }

        public static Result<T> Fail<T>(string message)
        {
            return Fail<T>(new string[] { message });
        }
    }
}