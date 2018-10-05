using Bladux.Test.TodoList.Shared.Redux;

namespace Bladux.Test.TodoList.Pages
{
    public static class StoreManager
    {
        #region Fields

        private static readonly IStore<TodoAppState, Action<ActionTypes>, ActionTypes> _store = new Store<TodoAppState, TodoAppReducer, Action<ActionTypes>, ActionTypes>();

        #endregion Fields

        #region Properties

        public static IStore<TodoAppState, Action<ActionTypes>, ActionTypes> Store { get { return _store; } }

        #endregion Properties
    }
}