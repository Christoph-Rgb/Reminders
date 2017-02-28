using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Reminders.Core;

namespace Reminders.WpfClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var reminders = new ObservableCollection<ReminderUiDecorator>
            {
                new ReminderUiDecorator(new Reminder("Reminder 1", new Category("Category 1"))),
                new ReminderUiDecorator(new Reminder("Reminder 2", new Category("Category 2"))),
                new ReminderUiDecorator(new Reminder("Reminder 3", new Category("Category 3")))
            };

            reminders[0].DueDate = DateTime.Now.AddDays(1);
            reminders[0].Completed = true;
            reminders[1].DueDate = DateTime.Now.AddDays(2);
            reminders[2].DueDate = DateTime.Now.AddDays(3);


            IReminderListViewModel reminderListViewModel = new ReminderListViewModel(reminders);

            ICommand createReminderCommand = new CreateReminderCommand(reminders);

            IMainWindowViewModel mainWindowViewModel = new MainWindowViewModel(reminderListViewModel, createReminderCommand);

            MainWindow = new MainWindow {DataContext = mainWindowViewModel};
            MainWindow.Show();

        }
    }
}
