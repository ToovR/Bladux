using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bladux
{
    /// <summary>
    /// Store interface
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TAction">Action type</typeparam>
    /// <typeparam name="TActionTypeEnum">Action enumeration type</typeparam>
    /// <see cref="https://redux.js.org/basics/store"/>
    public interface IStore<TState, TAction, TActionTypeEnum>
        where TAction : Action<TActionTypeEnum>
        where TActionTypeEnum : struct, IConvertible
    {
        #region Properties

        /// <summary>
        /// Gets the current state
        /// </summary>
        TState State { get; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Dispatchs specified action
        /// </summary>
        /// <param name="action">Action to dispatch</param>
        void Dispatch(TAction action);

        /// <summary>
        /// Registers a specified listener
        /// </summary>
        /// <param name="listener"></param>
        /// <returns>Action to unsubscribe</returns>
        Task<Action> Subscribe(Action listener);

        #endregion Methods
    }
}