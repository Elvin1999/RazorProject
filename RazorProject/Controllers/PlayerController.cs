using Microsoft.AspNetCore.Mvc;
using RazorProject.Entities;
using RazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorProject.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Info(PlayerViewModel vm)
        {
            return View(vm);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var model = new PlayerViewModel
            {
                Player = new Player()
            };
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(Player player)
        {
            //with problem
            return RedirectToAction("Info", "Player", new PlayerViewModel { Player = player }) ;
        }
    }
}
