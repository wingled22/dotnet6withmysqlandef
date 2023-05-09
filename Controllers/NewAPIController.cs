using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;

namespace sampleMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    public class NewAPIController : ControllerBase
    {

        private readonly testContext _context;
        public NewAPIController(testContext context)
        {
            _context = context;
        }

        public ActionResult<List<Category>> getAllCategories(){
            return _context.Categories.ToList();
        }

        public ActionResult<List<Product>> getAllprods(){
            return _context.Products.ToList();
        }

        public IActionResult saveCategory(Product p){
            p.Status = "Active";
            _context.Products.Add(p);
            _context.SaveChanges();
            return Ok();
        }
        
    }
}