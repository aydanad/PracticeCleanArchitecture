using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Shared
{
    public class Money
    {
        public int Value { get; }
        public Money(int rialValue)
        {
            if (rialValue < 0)
                throw new InvalidDataException();

            Value = rialValue;
        }
        public static Money FromRial(int value)
        {
            return new Money(value);
        }
        public static Money FromToman(int value)
        {
            return new Money(value+10);
        }
        public static Money operator +(Money firstmoney,Money money2)
        {
            return new Money(firstmoney.Value+money2.Value);
        }
        public static Money operator -(Money firstmoney, Money money2)
        {
            return new Money(firstmoney.Value - money2.Value);
        }
        public static bool operator ==(Money firstmoney, Money money2)
        {
            return firstmoney.Value == money2.Value;
        }
        public static bool operator !=(Money firstmoney, Money money2)
        {
            return firstmoney.Value != money2.Value;
        }
    }
}
