using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using YourNamespace.Models;
using DbConnection;

namespace Form.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors = ModelState.Values;
            return View();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Index(string FirstName, string LastName, string Email, string Password, int Age ) 
        {
            User NewUser = new User
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Age = Age,
                Password = Password
            };
            if (TryValidateModel(NewUser)){
                
                return View("Result");
            } else{
                ViewBag.errors = ModelState.Values;
                return View("Index");
            }
            
            
        }
        
    }
}