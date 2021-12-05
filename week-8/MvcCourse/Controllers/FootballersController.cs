using Microsoft.AspNetCore.Mvc;
using MvcCourse.Models;
using System.Collections.Generic;

namespace MvcCourse.Controllers
{
    public class FootballersController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<FootballerViewModel>
            {
                new FootballerViewModel()
                {
                    Name = "Lionel",
                    Surname = "Messi",
                },
                new FootballerViewModel()
                {
                    Name = "Cristiano",
                    Surname = "Ronaldo"
                }
            };

            ViewBag.Coach = "Guardiola";
            ViewData["Baskan"] = "Aziz Yıldırım";

            return View(list);
        }
    }
}
