using System;

namespace Reminders.Core
{
    public interface IReminder
    {
        string Text { get; set; }
        DateTime? DueDate { get; set; }
        DateTime? AlarmDate { get; set; }
        Category Category { get; set; }
        string Notes { get; set; }
        bool Completed { get; set; }
        Guid Id { get; }
        DateTime CreatedDate { get; }
    }
}