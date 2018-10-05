using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public enum ActionTypes
    {
        None,
        AddTodo,
        ToggleTodo,
        SetVisibilityFilter
    }
}