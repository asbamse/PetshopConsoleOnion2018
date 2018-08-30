﻿using Bamz.Petshop.Core.DomainService;
using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bamz.Petshop.Core.ApplicationService.Services
{
    public class ColourService : IColourService
    {
        private readonly IColourRepository _crep;

        public ColourService(IColourRepository colourService)
        {
            _crep = colourService;
        }

        public Colour Add(string description)
        {
            try
            {
                return _crep.Add(description);
            }
            catch (Exception e)
            {
                throw new ServiceException("Error adding colour: " + e.Message, e);
            }
        }

        public Colour Delete(int index)
        {
            try
            {
                return _crep.Delete(index);
            }
            catch (Exception e)
            {
                throw new ServiceException("Error deleting colour: " + e.Message, e);
            }
        }

        public List<Colour> GetAll()
        {
            try
            {
                return _crep.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw new ServiceException("Error getting all colours: " + e.Message, e);
            }
        }

        public Colour Update(int index, string description)
        {
            try
            {
                return _crep.Update(index, description);
            }
            catch (Exception e)
            {
                throw new ServiceException("Error updating colour: " + e.Message, e);
            }
        }
    }
}
