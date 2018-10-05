using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public class VisibilityFilterReducer : ReducerBase<FilterTodoTypes, FilterAction, ActionTypes>
    {
        #region Methods

        public override async Task<FilterTodoTypes> Reduce(FilterTodoTypes state, FilterAction action)
        {
            switch (action.Type)
            {
                case ActionTypes.SetVisibilityFilter:
                    return action.Filter;

                default:
                    return state;
            }
        }

        #endregion Methods
    }
}