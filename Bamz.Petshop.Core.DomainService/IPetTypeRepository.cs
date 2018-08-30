using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Core.DomainService
{
    public interface IPetTypeRepository
    {
        /// <summary>
        /// Adds petType to repository.
        /// </summary>
        /// <param name="petType">Adding petType.</param>
        /// <returns></returns>
        bool Add(PetType petType);

        /// <summary>
        /// Gets all petTypes.
        /// </summary>
        /// <returns>All PetTypes in repository</returns>
        IEnumerable<PetType> GetAll();

        /// <summary>
        /// Updates PetType already in repository.
        /// </summary>
        /// <param name="index">Index wanted editing.</param>
        /// <param name="petType">New PetType information.</param>
        /// <returns></returns>
        bool Update(int index, PetType petType);

        /// <summary>
        /// Deletes petType in repository.
        /// </summary>
        /// <param name="petType">PetType wanted deleted.</param>
        /// <returns></returns>
        bool Delete(PetType petType);
    }
}
