﻿using App_Demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace App_Demo1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormLogin()
        {
            ClsStudent S;
            List<ClsStudent> ls = new List<ClsStudent>();

            S = new ClsStudent();
            
                S.SID = 1;
                S.Name = "A";
                S.Gender = "M";
            
            ls.Add(S);

            return View(ls);
        }

    }
}
