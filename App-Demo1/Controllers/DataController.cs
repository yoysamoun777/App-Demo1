using App_Demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace App_Demo1.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DataForm()
        {
            ClsStudent S;
            List<ClsStudent> ls = new List<ClsStudent>();

            S = new ClsStudent();

            S.SID = 1;
            S.Name = "A";
            S.Gender = "M";
            S.DOB = 1992;
            S.Phone = 012345678;
            S.Email = "yoysamoun@gmail.com";
            S.Address = " Phnom Penh ";

            ls.Add(S);

            return View(ls);
           
        }
    }
}
