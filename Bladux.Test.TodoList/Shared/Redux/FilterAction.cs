using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public class FilterAction : Action<ActionTypes>
    {
        #region Properties

        public FilterTodoTypes Filter { get; set; }

        #endregion Properties
    }
}