using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            var contactPageModel = new ContactPageModel
            {
                TeamName = "Gorące ziemniaki!",
                Contact = new Contact
                {
                    City = "Gdańsk2",
                    PhoneNumbers = new List<string>
                    {
                        "123",
                        "456",
                        "789"
                    },
                    PostCode = "80-425",
                    State = "Pomorskie",
                    Street = "Grunwaldzka"
                },
                EmailAddresses = new List<EmailAddress>
                {
                    new EmailAddress
                    {
                        DepartmentName = "Marketing",
                        Email = "marketing@example.com"
                    },
                    new EmailAddress
                    {
                        DepartmentName = "Support",
                        Email = "support@example.com"
                    },
                    new EmailAddress
                    {
                        DepartmentName = "IT",
                        Email = "it@example.com"
                    }
                }
            };

            return View(contactPageModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
