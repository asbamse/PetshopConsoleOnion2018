using Bamz.Petshop.Core.DomainService;
using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Infrastructure.Data
{
    public class ColourRepository : IColourRepository
    {
        int _nextId;
        List<Colour> _colours;

        public ColourRepository()
        {
            _nextId = 1;
            _colours = new List<Colour>();
        }

        public Colour Add(string description)
        {
            Colour colour;
            try
            {
                colour = new Colour(_nextId, description);
                _colours.Add(colour);
                _nextId++;
            }
            catch (Exception e)
            {
                throw new RepositoryException("Error adding colour: " + e.Message, e);
            }

            return colour;
        }

        public IEnumerable<Colour> GetAll()
        {
            return _colours;
        }

        public Colour Update(int index, string description)
        {
            Colour colour;
            for (int i = 0; i < _colours.Count; i++)
            {
                if(_colours[i].Id == index)
                {
                    colour = new Colour(index, description);
                    _colours[i] = colour;
                    return colour;
                }
            }

            throw new RepositoryException("Colour not found!");
        }

        public Colour Delete(int index)
        {
            for (int i = 0; i < _colours.Count; i++)
            {
                if (_colours[i].Id == index)
                {
                    Colour colour = _colours[i];
                    _colours.Remove(_colours[i]);
                    return colour;
                }
            }

            throw new RepositoryException("Error deleting colour");
        }
    }
}
