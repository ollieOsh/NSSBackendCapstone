using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoundClout.Models;
using System.Threading.Tasks;

namespace SoundClout.Data //Worked on by Ollie, August 18th, 2017
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext
                (serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.MainName.Any())
                {
                    return; //db is already seeded
                }

                var Name = new MainName[]
                {
                    new MainName()
                    {
                        Word = "Hitta",
                        SyllableCount = 2,
                        NumerologyInt = 8,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Saturday"
                    },
                    new MainName()
                    {
                        Word = "Swag",
                        SyllableCount = 1,
                        NumerologyInt = 8,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Saturday"
                    },
                    new MainName()
                    {
                        Word = "",
                        SyllableCount = 1,
                        NumerologyInt = 8,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Saturday"
                    }
                };
                foreach (MainName n in Name)
                {
                    context.MainName.Add(n);
                }
                context.SaveChanges();
            }
        }
    }
}
                
