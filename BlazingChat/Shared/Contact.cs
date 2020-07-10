using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingChat.Shared
{
    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Contact(int id, string name, string lastName) {
            this.ID = id;
            this.Name = name;
            this.LastName = lastName;
        }
    }
}
