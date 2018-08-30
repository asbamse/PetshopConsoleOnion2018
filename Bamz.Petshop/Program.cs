using Bamz.Petshop.Core.ApplicationService;
using Bamz.Petshop.Core.ApplicationService.Services;
using Bamz.Petshop.Core.DomainService;
using Bamz.Petshop.Infrastructure.Data;
using Bamz.Petshop.UserInterface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;

namespace Bamz.Petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create service collection.
            ServiceCollection sc = new ServiceCollection();

            // Adds wanted modules to scope.
            sc.AddScoped<IColourService, ColourService>();
            sc.AddScoped<IPersonService, PersonService>();
            sc.AddScoped<IPetService, PetService>();
            sc.AddScoped<IPetTypeService, PetTypeService>();
            sc.AddScoped<IColourRepository, ColourRepository>();
            sc.AddScoped<IPersonRepository, PersonRepository>();
            sc.AddScoped<IPetRepository, PetRepository>();
            sc.AddScoped<IPetTypeRepository, PetTypeRepository>();
            sc.AddScoped<IUserInterface, ConsoleUI>();
            // Build Service.
            ServiceProvider sp = sc.BuildServiceProvider();

            #region TestData
            IColourService cs = sp.GetRequiredService<IColourService>();
            cs.Add("Black");
            cs.Add("Orange");
            cs.Add("Grey");
            cs.Add("White");

            IPetTypeRepository pts = sp.GetRequiredService<IPetTypeRepository>();
            pts.Add("Dog");
            pts.Add("Cat");
            pts.Add("Goat");
            pts.Add("Dreadnaught");

            IPersonRepository pss = sp.GetRequiredService<IPersonRepository>();
            pss.Add("Jens", "Jensen", "Jensvej", 536736, "jens@jensen.dk");
            pss.Add("John", "Smith", "Global Avenue", 66666666, "seeya@my.crib");
            pss.Add("Wonda Bonda", "Sonda", "Vegetable Street", 432589, "wbs@onda.co.uk");
            #endregion

            // Gets generated User Interface to run Show() Method.
            IUserInterface ui = sp.GetRequiredService<IUserInterface>();
            ui.Show();
        }
    }
}
