using Microsoft.AspNetCore.Mvc;
using Prospectus.Data;
using Prospectus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Prospectus.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PlayerController(ApplicationDbContext db)
        {
            // create database object
            // now can be used as "db"
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Player> objList = _db.Player;
            return View(objList);
        }
    }
}
