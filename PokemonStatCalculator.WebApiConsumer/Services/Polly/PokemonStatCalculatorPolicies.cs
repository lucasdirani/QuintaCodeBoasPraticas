using Polly;
using System;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApiConsumer.Services.Polly
{
    public class PokemonStatCalculatorPolicies : IPokemonStatCalculatorPolicies
    {
        private const int DefaultRetryCount = 2;

        private const int DefaultSleepDurationInSeconds = 5;

        public Task<TExecute> CreateRetryExecuteAsyncPolicyFor<TRetry,TExecute>(
            Func<Task> onRetryAsync, 
            Func<TRetry,bool> handler,
            Func<Task<TExecute>> executer)
            where TRetry : Exception
        {
            return Policy
              .Handle<TRetry>(r => handler(r))
              .WaitAndRetryAsync(
                retryCount: DefaultRetryCount, 
                sleepDurationProvider: attempt => TimeSpan.FromSeconds(DefaultSleepDurationInSeconds), 
                onRetry: (exception, calculatedWaitDuration) => 
                {
                    onRetryAsync();
                })
              .ExecuteAsync(action: executer);
        }
    }
}