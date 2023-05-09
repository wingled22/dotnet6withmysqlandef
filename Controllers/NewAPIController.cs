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

        public IActionResult saveCategory(string name){
            Category c = new Category(){
                Name = name
            };
            _context.Categories.Add(c);
            _context.SaveChanges();
            return Ok();
        }
        
    }
}