using System;

namespace Bladux
{
    /// <summary>
    /// Action class
    /// </summary>
    /// <see cref="https://redux.js.org/basics/actions"/>
    /// <typeparam name="TActionTypeEnum">Action enumeration type</typeparam>
    public class Action<TActionTypeEnum> where TActionTypeEnum : struct, IConvertible
    {
        #region Properties

        /// <summary>
        /// Gets or sets the action's type
        /// </summary>
        public TActionTypeEnum Type { get; set; }

        #endregion Properties
    }
}