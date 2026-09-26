using Clean_arch.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Users.ValueObjects
{
    public class PhoneBook : BaseValueObject
    {
        public PhoneNumber TelePhone { get; }
        public PhoneNumber Fax { get; }

        public PhoneBook(PhoneNumber telePhone, PhoneNumber fax)
        {
            TelePhone = telePhone;
            Fax = fax;
        }
    }
}
