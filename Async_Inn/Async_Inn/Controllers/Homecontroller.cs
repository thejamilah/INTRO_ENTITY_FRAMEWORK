﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Controllers
{
    public class Homecontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
