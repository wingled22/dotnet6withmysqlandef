using System.Diagnostics;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;
using sampleMVC.Models;

namespace sampleMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductAPIController : ControllerBase
    {
        private readonly testContext _context;
        public ProductAPIController(testContext context)
        {
            _context = context;
        }

        public ActionResult<List<Category>> getAllCategories(){
            return _context.Categories.ToList();
        }

        [EnableCors]
        public ActionResult<List<Product>> getAllProducts(){
            return _context.Products.ToList();
        }

    }
}