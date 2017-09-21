using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoundClout.ViewModels;
using SoundClout.Data;

namespace SoundClout.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Dictionary<char, int> _alphaNum = new Dictionary<char, int>()
        {
            {'a', 1}, {'b', 2}, {'c', 3}, {'d', 4}, {'e', 5}, {'f', 6}, {'g', 7}, {'h', 8}, {'i', 9}, {'j', 10}, {'k', 11}, {'l', 12}, {'m', 13}, {'n', 14}, {'o', 15}, {'p', 16}, {'q', 17}, {'r', 18}, {'s', 19}, {'t', 20}, {'u', 21}, {'v', 22}, {'w', 23}, {'x', 24}, {'y', 25}, {'z', 26}

        };

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(Form model)
        {
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public int Reduce (int date)
        {
            int finalNum = 0;

            while(date > 9 && date != 11 && date != 22 && date != 33)
            {
                finalNum = 0;

                var splitDate = date.ToString().ToCharArray();

                for( int i = 0; i < splitDate.Length; i++)
                {
                    finalNum += Int32.Parse(splitDate[i].ToString());
                    date = finalNum;
                }
            }

            return date;

        }

        public async Task<IActionResult> MakeDestiny(Form form)
        {
            if (ModelState.IsValid)
            {
                DateTime birthDate = form.DOB;

                int day = Reduce(birthDate.Day);
                int month = Reduce(birthDate.Month);
                int year = Reduce(birthDate.Year);

                int numerology = Reduce(day + month + year);

                int firstFirstAlphaNum = _alphaNum[form.FirstName.ToLower().First()];
                int firstLastAlphaNum = _alphaNum[form.LastName.ToLower().First()];
                int lastFirstAlphaNum = _alphaNum[form.FirstName.ToLower().Last()];
                int lastLastAlphaNum = _alphaNum[form.LastName.ToLower().Last()];

                int nameMath = Reduce((form.FirstName.Length + form.LastName.Length) * (firstFirstAlphaNum + lastFirstAlphaNum + lastLastAlphaNum + firstLastAlphaNum));

                int ultraNum = Reduce(nameMath + numerology);

                string dayBorn = form.DOB.DayOfWeek.ToString();

                if (form.Prefix == "Lil")
                {
                    try
                    {
                        var second = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == numerology && n.OrderInt > 1 && n.Weekday == dayBorn && n.PrefixInt == 1);

                        form.Clout = second.Word;

                        if (second.SyllableCount < 4)
                        {
                            try
                            {
                                var first = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == ultraNum && n.OrderInt != 2 && n.Weekday == dayBorn && n.SyllableCount + second.SyllableCount < 5 && n.Id != second.Id && n.PrefixInt == 1);

                                form.Clout = first.Word + " " + second.Word;
                            }
                            catch
                            {
                                try
                                {
                                    var first = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == ultraNum && n.OrderInt != 2 && n.Weekday == dayBorn && n.SyllableCount + second.SyllableCount < 5 &&  n.PrefixInt == 1);

                                    form.Clout = first.Word + " " + second.Word;
                                }
                                catch
                                {
                                    var first = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == ultraNum && n.OrderInt != 2 && n.SyllableCount + second.SyllableCount < 5 && n.PrefixInt == 1);

                                    form.Clout = first.Word + " " + second.Word;
                                }
                            }
                        }
                    }
                    catch
                    {
                        try
                        {
                            var second = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == numerology && n.PrefixInt == 1);

                            form.Clout = second.Word;

                            if (second.SyllableCount < 4)
                            {
                                try
                                {
                                    var first = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == ultraNum && n.OrderInt != 2 && n.Weekday == dayBorn && n.SyllableCount + second.SyllableCount < 5 && n.Id != second.Id && n.PrefixInt == 1);

                                    form.Clout = first.Word + " " + second.Word;
                                }
                                catch
                                {
                                    try
                                    {
                                        var first = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == ultraNum && n.OrderInt != 2 && n.Weekday == dayBorn && n.SyllableCount + second.SyllableCount < 5 && n.Id != second.Id);

                                        form.Clout = first.Word + " " + second.Word;
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                else
                {
                    try
                    {
                        var second = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == ultraNum && n.OrderInt > 1 && n.Weekday == dayBorn && n.PrefixInt == 2);

                        form.Clout = second.Word;

                        if (second.SyllableCount < 3)
                        {
                            try
                            {
                                var first = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == numerology && n.OrderInt != 2 && n.Weekday == dayBorn && n.SyllableCount + second.SyllableCount < 5 && n.Id != second.Id && n.PrefixInt == 2);

                                form.Clout = first.Word + " " + second.Word;
                            }
                            catch
                            {

                            }
                        }
                    }
                    catch
                    {
                        try
                        {
                            var second = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == nameMath && n.PrefixInt == 2);

                            form.Clout = second.Word;
                        }
                        catch
                        {

                        }
                    }
                }
            }
            else
            {
                form.Clout = "Dunno How To Fill A Form Right";
            }

            return RedirectToAction("Index", form);
        }
    }
}
