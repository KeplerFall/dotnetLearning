﻿using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using SquadManager.Validator;

namespace SquadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    Console.WriteLine($"Property {item.PropertyName} failed at {item.ErrorMessage}");
                }
            }

            return View("index", user);
        }
    }
}
