using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;
using sampleMVC.ViewModels;

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

        public ActionResult<List<ProductViewModel>> getAllprods(){
            var prods = (
                from p in _context.Products
                join c in _context.Categories
                on p.Category equals c.Id
                select new ProductViewModel{
                    Name = p.Name,
                    Category = p.Category,
                    Id = p.Id,
                    CategoryName = c.Name,
                    Units = p.Units,
                    Stocks = p.Stocks
                }).ToList();
            return prods;
        }

        public IActionResult saveCategory(Product p){
            p.Status = "Active";
            _context.Products.Add(p);
            _context.SaveChanges();
            return Ok();
        }
        
    }
}