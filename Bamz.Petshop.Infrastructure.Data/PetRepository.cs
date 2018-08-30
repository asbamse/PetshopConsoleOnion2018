using Bamz.Petshop.Core.DomainService;
using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {
        int _nextId;
        List<Pet> _pets;

        public PetRepository()
        {
            _nextId = 1;
            _pets = new List<Pet>();
        }

        public Pet Add(string name, DateTime birthDate, DateTime soldDate, Colour colour, PetType type, Person previousOwner, double price)
        {
            Pet pet;
            try
            {
                pet = new Pet(_nextId, name, birthDate, soldDate, colour, type, previousOwner, price);
                _pets.Add(pet);
                _nextId++;
            }
            catch (Exception e)
            {
                throw new RepositoryException("Error adding pet: " + e.Message, e);
            }

            return pet;
        }

        public IEnumerable<Pet> GetAll()
        {
            return _pets;
        }

        public Pet Update(int index, string name, DateTime birthDate, DateTime soldDate, Colour colour, PetType type, Person previousOwner, double price)
        {
            Pet pet;
            for (int i = 0; i < _pets.Count; i++)
            {
                if (_pets[i].Id == index)
                {
                    pet = new Pet(index, name, birthDate, soldDate, colour, type, previousOwner, price);
                    _pets[i] = pet;
                    return pet;
                }
            }

            throw new RepositoryException("Pet not found!");
        }

        public Pet Delete(int index)
        {
            for (int i = 0; i < _pets.Count; i++)
            {
                if (_pets[i].Id == index)
                {
                    Pet pet = _pets[i];
                    _pets.Remove(_pets[i]);
                    return pet;
                }
            }

            throw new RepositoryException("Error deleting pet");
        }
    }
}
