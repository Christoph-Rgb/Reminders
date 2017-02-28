using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminders.Core
{
    public class Reminder : IReminder
    {
        private Guid _id;
        private string _text;
        private DateTime _createdDate;
        private DateTime? _dueDate;
        private DateTime? _alarmDate;
        private Category _category;
        private string _notes;
        private bool _completed;

        public Reminder(string text, DateTime? dueDate, DateTime? alarmDate, Category category, string notes)
        {
            if (string.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            if (category == null) throw new ArgumentNullException("category");

            _id = Guid.NewGuid();
            _text = text;
            _createdDate = DateTime.Now;
            _dueDate = dueDate;
            _alarmDate = alarmDate;
            _category = category;
            _notes = notes == null ? string.Empty : notes;
            _completed = false;
        }

        public Reminder(string text, Category category)
            : this (text, null, null, category, String.Empty)
        {
            
        }

        public Reminder()
        {
            _id = Guid.NewGuid();
            _createdDate = DateTime.Now;
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public DateTime? DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        public DateTime? AlarmDate
        {
            get { return _alarmDate; }
            set { _alarmDate = value; }
        }

        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }

        public Guid Id
        {
            get { return _id; }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
        }
    }
}
