﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class BaiduMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}