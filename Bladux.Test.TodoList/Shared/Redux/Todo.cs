using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bladux.Test.TodoList.Shared.Redux
{
    public class Todo
    {
        #region Properties

        public int Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Text { get; set; }

        #endregion Properties
    }
}