﻿using DemoLibrary;
using Microsoft.AspNetCore.Mvc;

namespace MINIPROJECTASPNETCOREMVC.Controllers
{
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // GET: Address
        public ActionResult Index()
        {
            return View();
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            if (ModelState.IsValid == false)
            {
                _logger.LogWarning("The user submitted an invalid Address upon creating.");
                return View();
            }
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
