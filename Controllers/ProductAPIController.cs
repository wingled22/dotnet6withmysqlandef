using System.Diagnostics;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;
using sampleMVC.Models;
using sampleMVC.ViewModels;

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
        public ActionResult<List<ProductViewModel>> getAllProducts(){
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
                    Stocks = p.Stocks,
                    Status = p.Status
                }).ToList();
            return prods;
        }

        public IActionResult postProduct(Product p ){

            _context.Products.Add(p);
            _context.SaveChanges();
            return Ok();
        }

    }
}