using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reminders.WpfClient
{
    public interface IMainWindowViewModel
    {
        IReminderListViewModel ReminderListViewModel { get; }
        ICommand CreateReminderCommand { get; }
    }

    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IReminderListViewModel _reminderListViewModel;
        private readonly ICommand _createReminderCommand;

        public MainWindowViewModel(IReminderListViewModel reminderListViewModel, ICommand createReminderCommand)
        {
            if (reminderListViewModel == null) throw new ArgumentNullException("reminderListViewModel");
            if (createReminderCommand == null) throw new ArgumentNullException("createReminderCommand");

            _reminderListViewModel = reminderListViewModel;
            _createReminderCommand = createReminderCommand;
        }

        public IReminderListViewModel ReminderListViewModel
        {
            get
            {
                return _reminderListViewModel;
            }
        }

        public ICommand CreateReminderCommand
        {
            get
            {
                return _createReminderCommand;
            }
        }
    }

    public class MainWindowViewModelSampleData
    {
        
    }
}
