﻿//-------------------------------------------------------------------------------

//-------------------------------------------------------------------------------

using System.Collections.Concurrent;
using Tiveriad.EnterpriseIntegrationPatterns.StateMachines.Infrastructure;

namespace Tiveriad.EnterpriseIntegrationPatterns.StateMachines.AsyncMachine
{
    public class StateContainer<TState, TEvent> :
        IExtensionHost<TState, TEvent>,
        IStateMachineInformation<TState, TEvent>,
        ILastActiveStateModifier<TState>
        where TState : IComparable
        where TEvent : IComparable
    {
        private readonly Dictionary<TState, TState> lastActiveStates = new Dictionary<TState, TState>();

        public StateContainer()
            : this(default(string))
        {
        }

        public StateContainer(string name)
        {
            this.Name = name;
            this.CurrentStateId = Initializable<TState>.UnInitialized();
        }

        public string Name { get; }

        public List<IExtensionInternal<TState, TEvent>> Extensions { get; } = new List<IExtensionInternal<TState, TEvent>>();

        public IInitializable<TState> CurrentStateId { get; set; }

        public IReadOnlyDictionary<TState, TState> LastActiveStates => this.lastActiveStates;

        public ConcurrentQueue<EventInformation<TEvent>> Events { get; set; } = new ConcurrentQueue<EventInformation<TEvent>>();

        public IReadOnlyCollection<EventInformation<TEvent>> SaveableEvents => new List<EventInformation<TEvent>>(this.Events);

        public ConcurrentStack<EventInformation<TEvent>> PriorityEvents { get; set; } = new ConcurrentStack<EventInformation<TEvent>>();

        public IReadOnlyCollection<EventInformation<TEvent>> SaveablePriorityEvents => new List<EventInformation<TEvent>>(this.PriorityEvents);

        public async Task ForEach(Func<IExtensionInternal<TState, TEvent>, Task> action)
        {
            foreach (var extension in this.Extensions)
            {
                await action(extension)
                    .ConfigureAwait(false);
            }
        }

        public Optional<TState> GetLastActiveStateFor(TState state)
        {
            return
                this.lastActiveStates.TryGetValue(state, out var lastActiveState)
                    ? Optional<TState>.Just(lastActiveState)
                    : Optional<TState>.Nothing();
        }

        public void SetLastActiveStateFor(TState state, TState newLastActiveState)
        {
            if (this.lastActiveStates.ContainsKey(state))
            {
                this.lastActiveStates[state] = newLastActiveState;
            }
            else
            {
                this.lastActiveStates.Add(state, newLastActiveState);
            }
        }
    }
}
