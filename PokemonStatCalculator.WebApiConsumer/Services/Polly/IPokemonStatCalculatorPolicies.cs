using System;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer.Services.Polly
{
    public interface IPokemonStatCalculatorPolicies
    {
        Task<TExecute> CreateRetryExecuteAsyncPolicyFor<TRetry,TExecute>(
            Func<Task> onRetryAsync,
            Func<TRetry, bool> handler,
            Func<Task<TExecute>> onExecuteAsync) 
            where TRetry : Exception;
    }
}