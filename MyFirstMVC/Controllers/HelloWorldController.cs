﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        /*
         * public IActionResult Index()
        {
            return View();
        }
        */
        public IActionResult Index()
        {
            return View();
        }
        
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
        }
        public string MyMethod()
        {
            return "This is my world....";
        }
    }
}
