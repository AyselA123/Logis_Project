
using Logis.DAL;
using Logis.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Logis.Controllers
{
    public class HomeController : Controller
    {
        private readonly LogisContext _context;

        public HomeController(LogisContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var services=_context.Services.ToList();

            HomeViewModel viewModel = new HomeViewModel()
            {
                Services = services
            };

            return View(viewModel);
        }

        public IActionResult ServiceDetail(int id) 
        { 
            var service= _context.Services.FirstOrDefault(x => x.Id == id);
            if(service == null)
            {
                return View("Error");
            }

            return View(service);
        }

    }
}