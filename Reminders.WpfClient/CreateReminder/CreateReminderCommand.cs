using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Reminders.Core;
using Reminders.WpfClient.CreateReminder;

namespace Reminders.WpfClient
{
    public class CreateReminderCommand : ICommand
    {
        private ICollection<ReminderUiDecorator> _reminders;

        public CreateReminderCommand(ICollection<ReminderUiDecorator> reminders)
        {
            if (reminders == null) throw new ArgumentNullException("reminders");

            _reminders = reminders;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Reminder newReminder = new Reminder();
            ReminderUiDecorator newReminderUi = new ReminderUiDecorator(newReminder);

            List<Category> categories = new List<Category>();
            categories.Add(new Category("Reminder"));
            categories.Add(new Category("Task"));
            categories.Add(new Category("Buy"));
            categories.Add(new Category("Call"));

            ICreateReminderViewModel createReminderViewModel = new CreateReminderViewModel(newReminderUi, categories);

            CreateReminderView createReminderView = new CreateReminderView {DataContext = createReminderViewModel};

            bool? dialogResult = createReminderView.ShowDialog();

            if (dialogResult.Value)
            {
                _reminders.Add(newReminderUi);
            }

        }

        public event EventHandler CanExecuteChanged;
    }
}
