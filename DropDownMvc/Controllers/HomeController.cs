using Microsoft.AspNetCore.Mvc;
using DropDownMvc.Models;
using System.Diagnostics;

namespace DropDownMvc.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HomeViewModel _homeViewModel = new HomeViewModel { };

        public IActionResult Index()
        {
            return View(_homeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HomeViewModel changes)
        {
            if (ModelState.IsValid)
            {
                await TryUpdateModelAsync(_homeViewModel);
                return RedirectToAction("Index");
            }
            return View(changes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}