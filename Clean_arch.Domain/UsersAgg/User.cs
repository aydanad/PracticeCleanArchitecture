using Clean_arch.Domain.Users.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Users
{
    public class User
    {
        public User(string name, string family, PhoneBook phoneBook)
        {
            Name = name;
            Family = family;
            PhoneBook = phoneBook;
        }
        public string Name { get; private set; }
        public string Family { get; private set; }
        public PhoneBook PhoneBook { get; private set; }
    }
}
