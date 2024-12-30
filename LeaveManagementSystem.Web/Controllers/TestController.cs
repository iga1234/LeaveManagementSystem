﻿using LeaveManagementSystem.Application.Models;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateOfBirth = new DateTime(1994, 04, 24)
            };
            return View(data);
        }
    }
}
