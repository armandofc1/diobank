using System;

namespace DIO.Bank.Domain
{
    public abstract class Base
    {
        public Guid Id { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}
