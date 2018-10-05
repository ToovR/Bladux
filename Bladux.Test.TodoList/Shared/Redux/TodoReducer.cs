using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public class TodoReducer : ReducerBase<Todo, TodoAction, ActionTypes>
    {
        #region Methods

        public override async Task<Todo> Reduce(Todo state, TodoAction action)
        {
            switch (action.Type)
            {
                case ActionTypes.AddTodo:
                    return
                    new Todo
                    {
                        Id = action.Value.Id,
                        Text = action.Value.Text,
                        IsCompleted = action.Value.IsCompleted
                    };
                case ActionTypes.ToggleTodo:
                    if (state.Id != action.Value.Id)
                        return state;
                    else
                        return new Todo
                        {
                            Id = state.Id,
                            Text = state.Text,
                            IsCompleted = !state.IsCompleted
                        };

                default:
                    return state;
            }
        }

        #endregion Methods
    }
}