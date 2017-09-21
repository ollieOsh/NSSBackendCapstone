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
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Saturday",
                        NumerologyInt = 1
                    },
                    new MainName()
                    {
                        Word = "Swag",
                        SyllableCount = 1,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 1
                    },
                    new MainName()
                    {
                        Word = "Tough",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Saturday",
                        NumerologyInt = 2
                    },
                    new MainName()
                    {
                        Word = "Penguin",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Monday",
                        NumerologyInt = 11
                    },
                    new MainName()
                    {
                        Word = "Baby",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Friday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Tinder",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Tuesday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Savage",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 6
                    },
                    new MainName()
                    {
                        Word = "Boat",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Dog",
                        SyllableCount = 1,
                        OrderInt = 2,
                        PrefixInt = 1,
                        Weekday = "Friday",
                        NumerologyInt = 6
                    },
                    new MainName()
                    {
                        Word = "Goyard",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Saturday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Sauce",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Tundra",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Thursday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Penguin",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Tuesday",
                        NumerologyInt = 22
                    },
                    new MainName()
                    {
                        Word = "Coyote",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 2
                    },
                    new MainName()
                    {
                        Word = "Alabaster",
                        SyllableCount = 3,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 8
                    },
                    new MainName()
                    {
                        Word = "Trash",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Eater",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 3
                    },
                    new MainName()
                    {
                        Word = "Lazy",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Monday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Pineapple",
                        SyllableCount = 3,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Jaguar",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Spicy",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 2
                    },
                    new MainName()
                    {
                        Word = "Face",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Booty",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Finesse",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Finesser",
                        SyllableCount = 3,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Tuesday",
                        NumerologyInt = 22
                    },
                    new MainName()
                    {
                        Word = "Magic",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Friday",
                        NumerologyInt = 6
                    },
                    new MainName()
                    {
                        Word = "Jungle",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 1,
                        Weekday = "Thursday",
                        NumerologyInt = 3
                    },
                    new MainName()
                    {
                        Word = "Space",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Wednesday",
                        NumerologyInt = 8
                    },
                    new MainName()
                    {
                        Word = "Albino",
                        SyllableCount = 3,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Monday",
                        NumerologyInt = 3
                    },
                    new MainName()
                    {
                        Word = "Ninja",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Dunk",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Friday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Tank",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Lord",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 8
                    },
                    new MainName()
                    {
                        Word = "Mouse",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Sunday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Rat",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Monday",
                        NumerologyInt = 3
                    },
                    new MainName()
                    {
                        Word = "China",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Tuesday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Saucy",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Peanut",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Thursday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Jetski",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 1,
                        Weekday = "Friday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Pump",
                        SyllableCount = 1,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Monday",
                        NumerologyInt = 1
                    },
                    new MainName()
                    {
                        Word = "Banana",
                        SyllableCount = 3,
                        OrderInt = 1,
                        PrefixInt = 2,
                        Weekday = "Sunday",
                        NumerologyInt = 11
                    },
                    new MainName()
                    {
                        Word = "Hammock",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Monday",
                        NumerologyInt = 22
                    },
                    new MainName()
                    {
                        Word = "Vagabond",
                        SyllableCount = 3,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Tuesday",
                        NumerologyInt = 33
                    },
                    new MainName()
                    {
                        Word = "Platypus",
                        SyllableCount = 3,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Wednesday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Tender",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Thursday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Neck",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Friday",
                        NumerologyInt = 2
                    },
                    new MainName()
                    {
                        Word = "Pickles",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Cujo",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 2
                    },
                    new MainName()
                    {
                        Word = "Cactus",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Monday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Meat",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Tuesday",
                        NumerologyInt = 8
                    },
                    new MainName()
                    {
                        Word = "Fidget",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 8
                    },
                    new MainName()
                    {
                        Word = "Dawg",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Thursday",
                        NumerologyInt = 11
                    },
                    new MainName()
                    {
                        Word = "Hops",
                        SyllableCount = 1,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Friday",
                        NumerologyInt = 11
                    },
                    new MainName()
                    {
                        Word = "Kick",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Saturday",
                        NumerologyInt = 22
                    },
                    new MainName()
                    {
                        Word = "Pharoah",
                        SyllableCount = 4,
                        OrderInt = 2,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 33
                    },
                    new MainName()
                    {
                        Word = "Smell",
                        SyllableCount = 1,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Monday",
                        NumerologyInt = 1
                    },
                    new MainName()
                    {
                        Word = "Garbage",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Tuesday",
                        NumerologyInt = 2
                    },
                    new MainName()
                    {
                        Word = "Makeshift",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 2,
                        Weekday = "Wednesday",
                        NumerologyInt = 3
                    },
                    new MainName()
                    {
                        Word = "Button",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Thursday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Muscle",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Friday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Spasm",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Saturday",
                        NumerologyInt = 6
                    },
                    new MainName()
                    {
                        Word = "Sweet Water",
                        SyllableCount = 3,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Sunday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Flame",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Monday",
                        NumerologyInt = 8
                    },
                    new MainName()
                    {
                        Word = "Spaghetti",
                        SyllableCount = 3,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Tuesday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Chest",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 11
                    },
                    new MainName()
                    {
                        Word = "Splinter",
                        SyllableCount = 3,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Thursday",
                        NumerologyInt = 1
                    },
                    new MainName()
                    {
                        Word = "Pistol",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Friday",
                        NumerologyInt = 2
                    },
                    new MainName()
                    {
                        Word = "Spinach",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 3
                    },
                    new MainName()
                    {
                        Word = "Plant",
                        SyllableCount = 1,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Monday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Barbie",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 1,
                        Weekday = "Tuesday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Oprah",
                        SyllableCount = 2,
                        OrderInt = 1,
                        PrefixInt = 1,
                        Weekday = "Wednesday",
                        NumerologyInt = 6
                    },
                    new MainName()
                    {
                        Word = "Splash",
                        SyllableCount = 1,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Thursday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Mower",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Friday",
                        NumerologyInt = 8
                    },
                    new MainName()
                    {
                        Word = "Mountain",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Tackle",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Sunday",
                        NumerologyInt = 11
                    },
                    new MainName()
                    {
                        Word = "Blanket",
                        SyllableCount = 3,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Monday",
                        NumerologyInt = 1
                    },
                    new MainName()
                    {
                        Word = "Zucchini",
                        SyllableCount = 3,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Tuesday",
                        NumerologyInt = 2
                    },
                    new MainName()
                    {
                        Word = "Cortisol",
                        SyllableCount = 3,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Wednesday",
                        NumerologyInt = 3
                    },
                    new MainName()
                    {
                        Word = "Charger",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Thursday",
                        NumerologyInt = 4
                    },
                    new MainName()
                    {
                        Word = "Mountain",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Friday",
                        NumerologyInt = 5
                    },
                    new MainName()
                    {
                        Word = "Duck",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 6
                    },
                    new MainName()
                    {
                        Word = "Smurf",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Sunday",
                        NumerologyInt = 7
                    },
                    new MainName()
                    {
                        Word = "Wrestler",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Monday",
                        NumerologyInt = 8
                    },
                    new MainName()
                    {
                        Word = "Tuna",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 1,
                        Weekday = "Tuesday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Contrast",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Wednesday",
                        NumerologyInt = 11
                    },
                    new MainName()
                    {
                        Word = "Fire",
                        SyllableCount = 2,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 9
                    },
                    new MainName()
                    {
                        Word = "Triumph",
                        SyllableCount = 2,
                        OrderInt = 2,
                        PrefixInt = 2,
                        Weekday = "Sunday",
                        NumerologyInt = 1
                    },
                    new MainName()
                    {
                        Word = "Flex",
                        SyllableCount = 1,
                        OrderInt = 3,
                        PrefixInt = 2,
                        Weekday = "Saturday",
                        NumerologyInt = 7
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
                
