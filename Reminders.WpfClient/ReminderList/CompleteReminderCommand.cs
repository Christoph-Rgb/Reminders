using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Reminders.Core;

namespace Reminders.WpfClient
{
    public class CompleteReminderCommand : ICommand
    {
        private ReminderUiDecorator _reminder;
        private bool _canExecute;

        public CompleteReminderCommand(ReminderUiDecorator reminder)
        {
            if (reminder == null) throw new ArgumentNullException("reminder");

            _reminder = reminder;
            _canExecute = true;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _reminder.Completed = true;
            _canExecute = false;
            CanExecuteChanged.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}
