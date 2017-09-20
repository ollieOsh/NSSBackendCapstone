using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoundClout.Models;
using System.Threading.Tasks;

namespace SoundClout.Data //Worked on by Ollie, August 18th, 2017
{
    public static class DBInitializer
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

                var name = new MainName[]
                {
                    new MainName()
                    {
                        Word = "Hitta",
                        SyllableCount = 2,
                        NumerologyInt = 1,
                        OrderInt = 3,
                        PrefixInt = 3,
                        Weekday = "Thursday"
                    },
                };
            }
        }
    }
}
                
