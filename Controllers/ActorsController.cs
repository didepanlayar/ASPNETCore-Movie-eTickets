﻿using Microsoft.AspNetCore.Mvc;
using Movie_eTickets.Data.Services;
using Movie_eTickets.Models;
using System.Threading.Tasks;

namespace Movie_eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, FullName, Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
