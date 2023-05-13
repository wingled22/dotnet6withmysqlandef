using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;

namespace sampleMVC.Controllers
{
    public class PageController : Controller
    {
       
        public ActionResult Product(){
            return View();
        }


        public ActionResult ProductList(){
            return View();
        }


    }
}