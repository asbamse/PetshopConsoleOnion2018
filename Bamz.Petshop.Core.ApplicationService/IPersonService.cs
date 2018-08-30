using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Core.ApplicationService
{
    interface IPersonService
    {
        /// <summary>
        /// Adds person to repository.
        /// </summary>
        /// <param name="person">Adding person.</param>
        /// <returns></returns>
        bool Add(Person person);

        /// <summary>
        /// Gets all persons.
        /// </summary>
        /// <returns>All Persons in repository</returns>
        IEnumerable<Person> GetAll();

        /// <summary>
        /// Updates Person already in repository.
        /// </summary>
        /// <param name="index">Index wanted editing.</param>
        /// <param name="person">New Person information.</param>
        /// <returns></returns>
        bool Update(int index, Person person);

        /// <summary>
        /// Deletes person in repository.
        /// </summary>
        /// <param name="person">Person wanted deleted.</param>
        /// <returns></returns>
        bool Delete(Person person);
    }
}
