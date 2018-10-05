using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public class TodoAppReducer : ReducerBase<TodoAppState, Action<ActionTypes>, ActionTypes>
    {
        #region Methods

        public override async Task<TodoAppState> Reduce(TodoAppState state, Action<ActionTypes> action)
        {
            if (state == null)
                state = new TodoAppState();
            return new TodoAppState
            {
                Todos = (action is TodoAction ? await new TodosReducer().Reduce(state.Todos, (TodoAction)action) : state.Todos),
                VisibilityFilter = (action is FilterAction ? await new VisibilityFilterReducer().Reduce(state.VisibilityFilter, (FilterAction)action) : state.VisibilityFilter),
            };
        }

        #endregion Methods
    }
}