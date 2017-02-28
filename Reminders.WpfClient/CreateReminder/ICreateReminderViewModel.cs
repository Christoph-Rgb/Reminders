using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reminders.Core;

namespace Reminders.WpfClient.CreateReminder
{
    public interface ICreateReminderViewModel
    {
        IReminder CreatedReminder { get; set; }
        IReadOnlyList<Category> Categories { get; }
    }

    public class CreateReminderViewModel : ICreateReminderViewModel
    {
        private IReminder _createdReminder;
        private IReadOnlyList<Category> _categories;

        public CreateReminderViewModel(IReminder createdReminder, IReadOnlyList<Category> categories)
        {
            if (createdReminder == null) throw new ArgumentNullException("createdReminder");
            if (categories == null) throw new ArgumentNullException("categories");

            _createdReminder = createdReminder;
            _categories = categories;
        }

        public IReminder CreatedReminder
        {
            get { return _createdReminder; }
            set { _createdReminder = value; }
        }

        public IReadOnlyList<Category> Categories { get { return _categories; } }
    }
}
