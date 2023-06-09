using AskizEvent.Models;
using AskizEvent.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Controllers
{
    public class EventController : Controller
    {
        private readonly IEvent _Event;
        private readonly ITypeEvent _TypeEvent;
        public EventController(IEvent _IEvent, ITypeEvent _ITypeEvent)
        {
            _Event = _IEvent;
            _TypeEvent = _ITypeEvent;
        }
        public IActionResult Index()
        {
            return View(_Event.GetEvents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.TypeEvents = _TypeEvent.GetTypeEvents;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Event model)
        {
            if (ModelState.IsValid)
            {
                _Event.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? ID)
        {
            if(ID == null)
            {

            }
            else
            {
                _Event.Remove(ID);
                return RedirectToAction("index");
            }
            return View();
        }
    }
}
