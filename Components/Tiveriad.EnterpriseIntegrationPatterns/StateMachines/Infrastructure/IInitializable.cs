//-------------------------------------------------------------------------------

//-------------------------------------------------------------------------------

namespace Tiveriad.EnterpriseIntegrationPatterns.StateMachines.Infrastructure
{
    public interface IInitializable<out T>
    {
        bool IsInitialized { get; }

        Initializable<TResult> Map<TResult>(Func<T, TResult> func);

        T ExtractOrThrow();
    }
}