using System;
using System.Threading.Tasks;

namespace Bladux
{
    /// <summary>
    /// Reducer interface
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TAction">Action type</typeparam>
    /// <typeparam name="TActionTypeEnum">Action enumeration type</typeparam>
    /// <see cref="https://redux.js.org/basics/reducers"/>
    public interface IReducer<TState, TAction, TActionTypeEnum>
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
        Task<TState> Reduce(TState state, TAction action);

        #endregion Methods
    }
}