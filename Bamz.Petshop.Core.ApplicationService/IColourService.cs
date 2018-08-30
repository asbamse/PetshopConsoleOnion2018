using Bamz.Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bamz.Petshop.Core.ApplicationService
{
    interface IColourService
    {
        /// <summary>
        /// Adds colour to repository.
        /// </summary>
        /// <param name="colour">Adding colour.</param>
        /// <returns></returns>
        bool Add(Colour colour);

        /// <summary>
        /// Gets all colours.
        /// </summary>
        /// <returns>All Colours in repository</returns>
        IEnumerable<Colour> GetAll();

        /// <summary>
        /// Updates Colour already in repository.
        /// </summary>
        /// <param name="index">Index wanted editing.</param>
        /// <param name="colour">New Colour information.</param>
        /// <returns></returns>
        bool Update(int index, Colour colour);

        /// <summary>
        /// Deletes colour in repository.
        /// </summary>
        /// <param name="colour">Colour wanted deleted.</param>
        /// <returns></returns>
        bool Delete(Colour colour);
    }
}
