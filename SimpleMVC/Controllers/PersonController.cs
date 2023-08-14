using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;
using SimpleMVC.Services;

namespace SimpleMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonService _service;
        public PersonController(PersonService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            List<Person> p = await _service.getPersons();
            return View(p);
        }
        [HttpGet]
        public async Task<JsonResult> GetAll()
        {
            List<Person> p = await _service.getPersons();
            return await Task.FromResult(Json(p));
        }
    }
}