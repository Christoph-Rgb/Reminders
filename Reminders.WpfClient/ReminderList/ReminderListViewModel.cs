using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Reminders.Core;
using Reminders.WpfClient.Annotations;

namespace Reminders.WpfClient
{
    public class ReminderListViewModel : IReminderListViewModel
    {
        private ObservableCollection<ReminderUiDecorator> _reminders;
        //private ReadOnlyObservableCollection<ReminderUiDecorator> _remindersReadOnlyObservableCollection;
        //private ReminderUiDecorator _selectedReminder;
        private bool _hideCompleted;

        public ReminderListViewModel(ObservableCollection<ReminderUiDecorator> reminders)
        {
            if (reminders == null) throw new ArgumentNullException("reminders");
            
            _reminders = reminders;
            foreach (INotifyPropertyChanged item in _reminders)
                item.PropertyChanged += new PropertyChangedEventHandler(ReminderPropertyChanged);

            //_remindersReadOnlyObservableCollection = new ReadOnlyObservableCollection<ReminderUiDecorator>(_reminders);
            //_selectedReminder = null;
            
            _reminders.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler((sender, args) =>
            {
                if (args.OldItems != null)
                    foreach (INotifyPropertyChanged item in args.OldItems)
                    item.PropertyChanged -= new PropertyChangedEventHandler(ReminderPropertyChanged);

                if (args.NewItems != null)
                foreach (INotifyPropertyChanged item in args.NewItems)
                    item.PropertyChanged += new PropertyChangedEventHandler(ReminderPropertyChanged);
            });

            CollectionView = CollectionViewSource.GetDefaultView(_reminders);
            CollectionView.SortDescriptions.Add(new SortDescription("DueDate", ListSortDirection.Ascending));
            HideCompleted = true;
        }

        private void ReminderPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            CollectionView.Refresh();
        }

        //public ReadOnlyObservableCollection<ReminderUiDecorator> Reminders
        //{
        //    get { return _remindersReadOnlyObservableCollection; }
        //}

        //public ReminderUiDecorator SelectedReminder
        //{
        //    get { return _selectedReminder; }
        //    set
        //    {
        //        _selectedReminder = value; 
        //    }
        //}

        public ICollectionView CollectionView { get; }

        public bool HideCompleted
        {
            get
            {
                return _hideCompleted;
            }
            set
            {
                _hideCompleted = value;
                if (_hideCompleted)
                {
                    CollectionView.Filter = (o) =>
                    {
                        IReminder reminder = o as IReminder;
                        if (reminder == null)
                            return false;

                        return !reminder.Completed;
                    };
                }
                else
                {
                    CollectionView.Filter = null;
                }
            }
        }
    }
}
