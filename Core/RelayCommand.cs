using System.Windows.Input;

namespace BookingSystem.Core
{
    internal class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;
        private Action loadBookings;

        public RelayCommand(Action<object> execute)
        {
            _execute = execute;
            _canExecute = null;
        }

        public RelayCommand(Action loadBookings)
        {
            this.loadBookings = loadBookings;
        }

        public RelayCommand(
            Action<object> execute, Predicate<object>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);

        }
    }
}
