using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;
using sampleMVC.Models;

namespace sampleMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    // [ApiController]
    public class SampleAPIController : ControllerBase
    {
        private readonly testContext _context;
        public SampleAPIController(testContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> getAllProducts(){
            var listProducts = _context.Products.ToList();
            return listProducts;
        }

        [HttpPost]
        public ActionResult Post(Category c){
            return Ok();
        }

    }
}