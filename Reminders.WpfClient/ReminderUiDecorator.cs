using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Reminders.Core;
using Reminders.WpfClient.Annotations;

namespace Reminders.WpfClient
{
    public class ReminderUiDecorator : IReminder, INotifyPropertyChanged
    {
        private Reminder _reminder;
        private ICommand _editReminderCommand;
        private ICommand _completeReminderCommand;

        public ReminderUiDecorator(Reminder reminder)
        {
            if (reminder == null) throw new ArgumentNullException("reminder");

            _reminder = reminder;
            _editReminderCommand = new EditReminderCommand(this);
            _completeReminderCommand = new CompleteReminderCommand(this);
        }

        public string Text
        {
            get { return _reminder.Text; }
            set
            {
                _reminder.Text = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DueDate
        {
            get { return _reminder.DueDate; }
            set
            {
                _reminder.DueDate = value;
                OnPropertyChanged();
            }
        }

        public DateTime? AlarmDate
        {
            get { return _reminder.AlarmDate; }
            set
            {
                _reminder.AlarmDate = value;
                OnPropertyChanged();
            }
        }

        public Category Category {
            get { return _reminder.Category; }
            set
            {
                _reminder.Category = value;
                OnPropertyChanged();
            }
        }

        public string Notes
        {
            get { return _reminder.Notes; }
            set
            {
                _reminder.Notes = value;
                OnPropertyChanged();
            }
        }

        public bool Completed
        {
            get { return _reminder.Completed; }
            set
            {
                _reminder.Completed = value;
                OnPropertyChanged();
            }
        }

        public Guid Id
        {
            get { return _reminder.Id; }
        }

        public DateTime CreatedDate
        {
            get { return _reminder.CreatedDate; }
        }

        public ICommand EditReminderCommand
        {
            get { return _editReminderCommand; }
        }

        public ICommand CompleteReminderCommand
        {
            get { return _completeReminderCommand; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
