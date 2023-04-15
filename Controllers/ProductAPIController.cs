using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;
using sampleMVC.Models;

namespace sampleMVC.Controllers
{
    public class ProductAPIController : ControllerBase
    {
        private readonly testContext _context;
        public ProductAPIController(testContext context)
        {
            _context = context;
        }

        public ActionResult<List<Category>> getAllCategories(){
            // List<string> names = new List<string>();
            // names.Add("sam");
            // names.Add("efraem");

            return _context.Categories.ToList();
        }

        public ActionResult<List<Product>> getAllProducts(){
            return _context.Products.ToList();
        }

    }
}