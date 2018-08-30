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

        public Pet(int id, string name, DateTime birthDate, DateTime soldDate, Colour colour, PetType type, Person previousOwner, double price)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            SoldDate = soldDate;
            Colour = colour;
            Type = type;
            PreviousOwner = previousOwner;
            Price = price;
        }
    }
}
