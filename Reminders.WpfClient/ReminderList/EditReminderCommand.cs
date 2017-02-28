using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Reminders.Core;

namespace Reminders.WpfClient
{
    public class EditReminderCommand : ICommand
    {
        private IReminder _reminder;

        public EditReminderCommand(IReminder reminder)
        {
            if (reminder == null) throw new ArgumentNullException("reminder");

            _reminder = reminder;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //edit reminder
            
        }

        public event EventHandler CanExecuteChanged;
    }
}
