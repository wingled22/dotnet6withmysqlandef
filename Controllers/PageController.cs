using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;

namespace sampleMVC.Controllers
{
    public class PageController : Controller
    {
        private readonly testContext _context;
        private ILogger<PageController> _logger;
        public PageController(testContext context, ILogger<PageController> logger)
        {
            _context  = context;
            _logger = logger;
        }

        public ActionResult Product(){
            return View();
        }



    }
}