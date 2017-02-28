using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Reminders.Core;

namespace Reminders.WpfClient.SampleData
{
    public class ReminderListViewModelSampleData : IReminderListViewModel
    {
        private ObservableCollection<ReminderUiDecorator> _reminders;

        public ReminderListViewModelSampleData()
        {
            _reminders = new ObservableCollection<ReminderUiDecorator>
            {
                new ReminderUiDecorator(new Reminder("Reminder 1", new Category("Category 1"))),
                new ReminderUiDecorator(new Reminder("Reminder 2", new Category("Category 2"))),
                new ReminderUiDecorator(new Reminder("Reminder 3", new Category("Category 3")))
            };

            _reminders[0].DueDate = DateTime.Now.AddDays(1);
            _reminders[1].DueDate = DateTime.Now.AddDays(2);
            _reminders[2].DueDate = DateTime.Now.AddDays(3);

            //SelectedReminder = Reminders[1];
        }

        //public ReadOnlyObservableCollection<ReminderUiDecorator> Reminders { get; }
        //public ReminderUiDecorator SelectedReminder { get; set; }
        public ICollectionView CollectionView { get { return CollectionViewSource.GetDefaultView(_reminders); } }
        public bool HideCompleted { get; set; }
    }
}
