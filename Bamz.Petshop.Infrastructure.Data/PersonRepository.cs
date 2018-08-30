using Bamz.Petshop.Core.DomainService;
using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Infrastructure.Data
{
    public class PersonRepository : IPersonRepository
    {
        int _nextId;
        List<Person> _persons;

        public PersonRepository()
        {
            _nextId = 1;
            _persons = new List<Person>();
        }

        public Person Add(string firstName, string lastName, string address, int phone, string email)
        {
            Person person;
            try
            {
                person = new Person(_nextId, firstName, lastName, address, phone, email);
                _persons.Add(person);
                _nextId++;
            }
            catch (Exception e)
            {
                throw new RepositoryException("Error adding person: " + e.Message, e);
            }

            return person;
        }

        public IEnumerable<Person> GetAll()
        {
            return _persons;
        }

        public Person Update(int index, string firstName, string lastName, string address, int phone, string email)
        {
            Person person;
            for (int i = 0; i < _persons.Count; i++)
            {
                if (_persons[i].Id == index)
                {
                    person = new Person(index, firstName, lastName, address, phone, email);
                    _persons[i] = person;
                    return person;
                }
            }

            throw new RepositoryException("Person not found!");
        }

        public Person Delete(int index)
        {
            for (int i = 0; i < _persons.Count; i++)
            {
                if (_persons[i].Id == index)
                {
                    Person person = _persons[i];
                    _persons.Remove(_persons[i]);
                    return person;
                }
            }

            throw new RepositoryException("Error deleting person");
        }
    }
}
