using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public class TodoAppState
    {
        #region Properties

        public Todo[] Todos { get; set; }
        public FilterTodoTypes VisibilityFilter { get; set; }

        #endregion Properties

        #region Constructors

        public TodoAppState()
        {
            Todos = new Todo[0];
            VisibilityFilter = FilterTodoTypes.ShowAll;
        }

        #endregion Constructors
    }
}