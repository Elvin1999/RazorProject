using Microsoft.AspNetCore.Mvc;
using RazorProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Player> model = new List<Player>
            {
                new Player{Id=1,Name="John",Score=40},
                new Player{Id=2,Name="Rafiq",Score=80},
                new Player{Id=3,Name="Leyla",Score=75},
                new Player{Id=3,Name="Leyla",Score=100}
            };

            return View();
        }

        public JsonResult Index2(string key)
        {
            List<Player> model = new List<Player>
            {
                new Player{Id=1,Name="John",Score=40},
                new Player{Id=2,Name="Rafiq",Score=80},
                new Player{Id=3,Name="Leyla",Score=75},
                new Player{Id=3,Name="Akif",Score=100}
            };
            if (string.IsNullOrEmpty(key))
            {
                return Json(model);
            }
            var result = model.Where(x => x.Name.ToLower().Contains(key)).ToList();

            return Json(result);
        }
        public JsonResult Index3(string key, double score)
        {
            List<Player> model = new List<Player>
            {
                new Player{Id=1,Name="John",Score=40},
                new Player{Id=2,Name="Rafiq",Score=80},
                new Player{Id=3,Name="Leyla",Score=75},
                new Player{Id=3,Name="Akif",Score=100}
            };
            if (string.IsNullOrEmpty(key))
            {
                return Json(model);
            }
            var result = model.Where(x => x.Name.ToLower().Contains(key) && x.Score <= score).ToList();

            return Json(result);
        }

        public IActionResult PlayerForm()
        {
            return View();
        }
        public IActionResult Index5(int id)
        {
            return Json(id);
        }
        public IActionResult Index6(int id,int id2)
        {
            return Json(id.ToString()+" "+id2.ToString());
        }

    }
}
