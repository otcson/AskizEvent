using AskizEvent.Models;
using AskizEvent.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsers _Users;
        public UserController(IUsers _IUsers)
        {
            _Users = _IUsers;
        }
        public IActionResult Index()
        {
            return View(_Users.GetUsers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Users model)
        {
            if(ModelState.IsValid)
            {
                _Users.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? ID)
        {
            if (ID == null)
            {
               
            }
            else
            {
                _Users.Remove(ID);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
