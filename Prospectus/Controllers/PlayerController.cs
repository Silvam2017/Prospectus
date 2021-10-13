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
        // Use dependency injection to get applicationdbcontext
        // This allows us to access database on prospect view
        private readonly ApplicationDbContext _db;
        // Pull in an instance of ApplicationDBContext and call it db

        public PlayerController(ApplicationDbContext db)
        {
            // create database object
            // now can be used as "db"
            _db = db;
        }

        public IActionResult Index()
        {
            // Create enumerable of Player, call it object list
            // Retrieve it from DB with entity framework and store it in objlist
            IEnumerable<Player> objList = _db.Player;
            // Return list to be displayed in view
            return View(objList);
        }
        // Can add other CRUD methods here
        // Create = want to add QB's via web app and not SQL database
        // Edit = make corrections/changes to QB stats
        // Delete = remove QB from database/web app
    }
}
