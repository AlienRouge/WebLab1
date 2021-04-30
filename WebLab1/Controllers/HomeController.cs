using Microsoft.AspNetCore.Mvc;
using WebLab1.ViewModel;

namespace WebLab1.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PassUsingModel()
        {
            var viewModel = new Operations();
            return View(viewModel);
        }
        public IActionResult PassUsingViewData()
        {

            ViewData["Nums"] = new Operations();
            return View();
        }
        public IActionResult PassUsingViewBag()
        {
            ViewBag.Nums = new Operations();
            return View();
        }
        public IActionResult AccessServiceDirectly()
        {
            return View();
        }

    }
}
