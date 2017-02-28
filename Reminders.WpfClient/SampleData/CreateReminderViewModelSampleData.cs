using System.Collections.Generic;
using Reminders.Core;
using Reminders.WpfClient.CreateReminder;

namespace Reminders.WpfClient.SampleData
{
    public class CreateReminderViewModelSampleData : ICreateReminderViewModel
    {
        public CreateReminderViewModelSampleData()
        {
            CreatedReminder = new Reminder("Created Reminder", new Category("Test Category 2"));

            var categories = new List<Category>();
            categories.Add(new Category("Reminder"));
            categories.Add(new Category("Task"));
            categories.Add(new Category("Buy"));
            categories.Add(new Category("Call"));

            Categories = categories;
        }

        public IReminder CreatedReminder { get; set; }
        public IReadOnlyList<Category> Categories { get; }
    }
}