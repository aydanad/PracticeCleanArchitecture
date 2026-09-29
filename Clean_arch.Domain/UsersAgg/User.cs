using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Users.ValueObjects;
using Clean_arch.Domain.UsersAgg.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Users
{
    public class User: BaseAggregate
    {
        public User(string name, string family, PhoneBook phoneBook,string email)
        {
            Name = name;
            Family = family;
            PhoneBook = phoneBook;
            Email = email;
        }
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string Email { get; private set; }
        public PhoneBook PhoneBook { get; private set; }

        public static User RegisterUser(string email)
        {
            var user= new User("", "", null, email);
            user.AddDomainEvent(new UserRegistered(user.Id, email));
            return user;
        }
    }
}
