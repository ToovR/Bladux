using System;
using System.Threading.Tasks;

namespace Bladux
{
    /// <summary>
    /// Reducer base class
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TAction">Action type</typeparam>
    /// <typeparam name="TActionTypeEnum">Action enumeration type</typeparam>
    /// <see cref="https://redux.js.org/basics/reducers"/>
    public abstract class ReducerBase<TState, TAction, TActionTypeEnum> : IReducer<TState, TAction, TActionTypeEnum>
        where TAction : Action<TActionTypeEnum>
        where TActionTypeEnum : struct, IConvertible
    {
        #region Methods

        /// <summary>
        /// Reduce actions
        /// </summary>
        /// <param name="state">Original state</param>
        /// <param name="action">Action to reduce</param>
        /// <returns>New state</returns>
        public virtual async Task<TState> Reduce(TState state, TAction action)
        {
            if (action == default(TAction))
                return state;
            return default(TState);
        }

        #endregion Methods
    }
}