using System;
using Microsoft.AspNetCore.Mvc;
using WebLab1.ViewModels;

namespace WebLab1.Controllers
{
    public class HomeController:Controller
    {
        private Random random = new Random();
        private int first;
        private int second;
        private string sum;
        private string sub;
        private string mult;
        private string div;

        public HomeController()
        {
            first = random.Next(0, 10);
            second = random.Next(0, 10);
            sum = $"{first} + {second} = {first + second}";
            sub = $"{first} - {second} = {first - second}";
            mult = $"{first} * {second} = {first * second}";
            div = second !=0 ? $"{first} + {second} = {first + second}": "Division by 0";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            var model = new Calculation(first, second, sum, sub, mult, div);
            return View(model);
        }

        public IActionResult PassUsingViewData()
        {
            ViewData["First"] = first;
            ViewData["Second"] = second;
            ViewData["Sum"] = sum;
            ViewData["Sub"] = sub;
            ViewData["Mult"] = mult;
            ViewData["Div"] = div;
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            ViewBag.First = first;
            ViewBag.Second = second;
            ViewBag.Sum = sum;
            ViewBag.Sub = sub;
            ViewBag.Mult = mult;
            ViewBag.Div = div;
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            var model = new Calculation(first, second, sum, sub, mult, div);
            return View(model);
        }
    }
}
