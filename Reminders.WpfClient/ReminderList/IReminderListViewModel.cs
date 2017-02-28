using System.Collections.ObjectModel;
using System.ComponentModel;
using Reminders.Core;

namespace Reminders.WpfClient
{
    public interface IReminderListViewModel
    {
        //ReadOnlyObservableCollection<ReminderUiDecorator> Reminders { get; }
        //ReminderUiDecorator SelectedReminder { get; set; }
        ICollectionView CollectionView { get; }
        bool HideCompleted { get; set; }
    }
}