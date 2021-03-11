using System;
using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Utils.ExtensionMethods
{
    public static class ResultExtensionMethod
    {
        public static Result OnSuccess(this Result result, Func<Result> func)
        {
            if (result.Failure)
            {
                return result;
            }

            return func();
        }

        public static Result OnSuccess(this Result result, Action action)
        {
            if (result.Failure)
            {
                return result;
            }

            action();

            return Result.Success();
        }

        public static Result<T> OnSuccess<T>(this Result<T> result, Func<T> func)
        {
            if (result.Failure)
            {
                return Result.Fail<T>(result.Errors);
            }

            return Result.Success(func());
        }

        public static Result<T> OnSuccess<T>(this Result<T> result, Func<Result<T>> func)
        {
            if (result.Failure)
            {
                return Result.Fail<T>(result.Errors);
            }

            return func();
        }

        public static Result OnSuccess<T>(this Result<T> result, Func<T, Result> func)
        {
            if (result.Failure)
            {
                return Result.Fail<T>(result.Errors);
            }

            return func(result.Value);
        }

        public static Result OnFailure(this Result result, Action action)
        {
            if (result.Failure)
            {
                action();
            }

            return result;
        }

        public static bool ContainsAnyFailure(this IEnumerable<Result> results)
        {
            return results.Any(result => result.Failure);
        }

        public static string[] ExtractAllErrors(this IEnumerable<Result> results)
        {
            return results.SelectMany(r => r.Errors).ToArray();
        }
    }
}