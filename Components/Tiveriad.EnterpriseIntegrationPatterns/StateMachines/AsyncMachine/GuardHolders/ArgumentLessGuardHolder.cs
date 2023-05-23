//-------------------------------------------------------------------------------

//-------------------------------------------------------------------------------

using System.Reflection;
using Tiveriad.Commons.Extensions;

namespace Tiveriad.EnterpriseIntegrationPatterns.StateMachines.AsyncMachine.GuardHolders
{
    /// <summary>
    /// Holds an argument less guard.
    /// </summary>
    public class ArgumentLessGuardHolder : IGuardHolder
    {
        private readonly MethodInfo originalGuardMethodInfo;
        private readonly Func<Task<bool>> guard;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentLessGuardHolder"/> class.
        /// </summary>
        /// <param name="guard">The guard.</param>
        public ArgumentLessGuardHolder(Func<bool> guard)
        {
            this.originalGuardMethodInfo = guard.GetMethodInfo();
            this.guard = () => Task.FromResult(guard());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentLessGuardHolder"/> class.
        /// </summary>
        /// <param name="guard">The guard.</param>
        public ArgumentLessGuardHolder(Func<Task<bool>> guard)
        {
            this.originalGuardMethodInfo = guard.GetMethodInfo();
            this.guard = guard;
        }

        /// <summary>
        /// Executes the guard.
        /// </summary>
        /// <param name="argument">The state machine event argument.</param>
        /// <returns>Result of the guard execution.</returns>
        public async Task<bool> Execute(object argument)
        {
            return await this.guard().ConfigureAwait(false);
        }

        /// <summary>
        /// Describes the guard.
        /// </summary>
        /// <returns>Description of the guard.</returns>
        public string Describe()
        {
            return this.originalGuardMethodInfo.ExtractMethodNameOrAnonymous();
        }
    }
}