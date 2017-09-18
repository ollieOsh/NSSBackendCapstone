using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoundClout.Models;

namespace SoundClout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public int MakeDestiny()
        {
            DateTime birthDate = DateTime.Now;
            int day = Reduce(birthDate.Day);
            int month = Reduce(birthDate.Month);
            int year = Reduce(birthDate.Year);

            return Reduce(day + month + year);
        }
    }
}
