using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Core.Entity
{
    public class Pet
    {
        public int Id { get; }
        public String Name { get; }
        public DateTime BirthDate { get; }
        public DateTime SoldDate { get; }
        public Colour Colour { get; }
        public PetType Type { get; }
        public Person PreviousOwner { get; }
        public double Price { get; }
    }
}
