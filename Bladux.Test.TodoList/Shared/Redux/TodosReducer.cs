using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public class TodosReducer : ReducerBase<Todo[], TodoAction, ActionTypes>
    {
        #region Methods

        public override async Task<Todo[]> Reduce(Todo[] state, TodoAction action)
        {
            switch (action.Type)
            {
                case ActionTypes.AddTodo:
                    return state.Concat(new Todo[] { await new TodoReducer().Reduce(null, action) }).ToArray();

                case ActionTypes.ToggleTodo:
                    return state.Select(async s => (await new TodoReducer().Reduce(s, action))).Select(s => s.Result).ToArray();

                default:
                    return state;
            }
        }

        #endregion Methods
    }
}