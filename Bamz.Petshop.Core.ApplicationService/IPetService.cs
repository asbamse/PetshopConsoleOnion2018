using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Core.ApplicationService
{
    public interface IPetService
    {
        /// <summary>
        /// Adds pet to repository.
        /// </summary>
        /// <param name="pet">Adding pet.</param>
        /// <returns></returns>
        bool Add(Pet pet);

        /// <summary>
        /// Gets pet with given id if present.
        /// </summary>
        /// <param name="Id">Id of pet wanted.</param>
        /// <returns>Pet with given id.</returns>
        Pet GetById(int Id);

        /// <summary>
        /// Gets all pets.
        /// </summary>
        /// <returns>All Pets in repository</returns>
        List<Pet> GetAll();

        /// <summary>
        /// Gets all pets in order cheapest to most expensive.
        /// </summary>
        /// <returns>All Pets in repository</returns>
        List<Pet> GetAllOrderPrice();

        /// <summary>
        /// Gets the five cheapest pets.
        /// </summary>
        /// <returns>Five cheapest pets.</returns>
        List<Pet> GetFiveCheapest();

        /// <summary>
        /// Search for all pets of given type.
        /// </summary>
        /// <param name="search">The type wanted.</param>
        /// <returns>A list of pets of given type.</returns>
        List<Pet> SearchByType(string search);

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
