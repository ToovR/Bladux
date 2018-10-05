using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public class TodoAction : Action<ActionTypes>
    {
        #region Properties

        public Todo Value { get; set; }

        #endregion Properties
    }
}