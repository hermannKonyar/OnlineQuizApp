using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;

namespace CourseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public IActionResult Index()
        {
            //Veritabanına bağlan
            //modeli al ve sayfada yani view de göster
            //gelen bilgiyi model içine paketle ve view e gönder.

            Course kurs = new Course();

            kurs.Id = 1;
            kurs.Name = "Asp.net core mvc 2";

            return View(kurs);
        }
    }
}