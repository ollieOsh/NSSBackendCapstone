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
            DateTime birthDate = form.DOB;

            int day = Reduce(birthDate.Day);
            int month = Reduce(birthDate.Month);
            int year = Reduce(birthDate.Year);

            form.Numerology =  Reduce(day + month + year);
            form.Day = form.DOB.DayOfWeek.ToString();

            if (form.Prefix == "Lil")
            {
                var second = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == form.Numerology && n.OrderInt > 1 && n.Weekday == form.Day);

                form.Clout = second.Word;

                if(second.SyllableCount < 3)
                {
                    var first = await _context.MainName.FirstOrDefaultAsync(n => n.NumerologyInt == form.Numerology && n.OrderInt != 2 && n.Weekday == form.Day && n.SyllableCount + second.SyllableCount < 5 && n.Id != second.Id);
                    
                    form.Clout = first.Word + " " + second.Word;
                }
            }

            return RedirectToAction("Index", form);
        }
    }
}
