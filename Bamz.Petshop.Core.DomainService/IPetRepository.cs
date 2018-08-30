using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Core.DomainService
{
    public interface IPetRepository
    {
        /// <summary>
        /// Adds pet to repository.
        /// </summary>
        /// <param name="pet">Adding pet.</param>
        /// <returns></returns>
        bool Add(Pet pet);

        /// <summary>
        /// Gets all pets.
        /// </summary>
        /// <returns>All Pets in repository</returns>
        IEnumerable<Pet> GetAll();

        /// <summary>
        /// Updates Pet already in repository.
        /// </summary>
        /// <param name="index">Index wanted editing.</param>
        /// <param name="pet">New Pet information.</param>
        /// <returns></returns>
        bool Update(int index, Pet pet);

        /// <summary>
        /// Deletes pet in repository.
        /// </summary>
        /// <param name="pet">Pet wanted deleted.</param>
        /// <returns></returns>
        bool Delete(Pet pet);
    }
}
