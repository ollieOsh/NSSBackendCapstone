using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoundClout.ViewModels;

namespace SoundClout.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult MakeDestiny(Form form)
        {
            DateTime birthDate = form.DOB;

            int day = Reduce(birthDate.Day);
            int month = Reduce(birthDate.Month);
            int year = Reduce(birthDate.Year);

            form.Numerology =  Reduce(day + month + year);
            form.Day = form.DOB.DayOfWeek;
            form.InitialVal = form.FirstName.First().GetHashCode().ToString();

            return RedirectToAction("Index", form);
        }
    }
}
