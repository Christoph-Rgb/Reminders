using System;

namespace Reminders.Core
{
    public class Category
    {
        private Guid _id;
        private string _name;

        public Category(string name)
        {
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            _name = name;
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}