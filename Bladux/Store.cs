using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux
{
    /// <summary>
    /// Store class
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TReducer">Reducer type</typeparam>
    /// <typeparam name="TAction">Action type</typeparam>
    /// <typeparam name="TActionTypeEnum">Action enumeration type</typeparam>
    /// <see cref="https://redux.js.org/basics/store"/>
    public class Store<TState, TReducer, TAction, TActionTypeEnum> : IStore<TState, TAction, TActionTypeEnum>
        where TReducer : IReducer<TState, TAction, TActionTypeEnum>
        where TAction : Action<TActionTypeEnum>
        where TActionTypeEnum : struct, IConvertible
    {
        #region Fields

        protected IReducer<TState, TAction, TActionTypeEnum> _reducer;
        private List<Action> _listeners;

        private TState _state;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the current state
        /// </summary>
        public TState State
        {
            get { return _state; }
            private set
            {
                Debug.WriteLine("State modification :");
                _state = value;
                if (_state != null)
                    Debug.WriteLine(Microsoft.AspNetCore.Blazor.JsonUtil.Serialize(_state));
                else
                    Debug.WriteLine("[null]");
            }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public Store()
        {
            _listeners = new List<Action>();
            State = Activator.CreateInstance<TState>();
            _reducer = Activator.CreateInstance<TReducer>();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Dispatchs specified action
        /// </summary>
        /// <param name="action">Action to dispatch</param>
        public async void Dispatch(TAction action)
        {
            State = await _reducer.Reduce(State, action);
            _listeners.ForEach(listener => listener());
            if (_listeners != null)
                Debug.WriteLine("Listeners count : " + _listeners.Count);
        }

        /// <summary>
        /// Registers a specified listener
        /// </summary>
        /// <param name="listener"></param>
        /// <returns>Action to unsubscribe</returns>
        public async Task<Action> Subscribe(Action listener)
        {
            _listeners.Add(listener);
            return () => { _listeners = _listeners.Where(l => l != listener).ToList(); };
        }

        #endregion Methods
    }
}