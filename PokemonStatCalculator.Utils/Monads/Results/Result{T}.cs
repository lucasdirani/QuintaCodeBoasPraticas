using System;

namespace PokemonStatCalculator.Utils.Monads.Results
{
    public class Result<T> : Result
    {
        private readonly T value;

        public Result(T value, bool isSuccess, string errorMessage)
            : base(isSuccess, errorMessage)
        {
            this.value = value;
        }

        public Result(T value, bool isSuccess, string[] errorMessages)
            : base(isSuccess, errorMessages)
        {
            this.value = value;
        }

        public Result()
            : base(true, new string[] { })
        {
            value = default;
        }

        public T Value
        {
            get
            {
                if (!IsSuccess)
                {
                    throw new InvalidOperationException();
                }

                return value;
            }
        }
    }
}