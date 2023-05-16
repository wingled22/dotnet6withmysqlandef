using System.Diagnostics;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;
using sampleMVC.Models;
using sampleMVC.ViewModels;

namespace sampleMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CategoryAPIController : ControllerBase
    {
        private readonly testContext _context;
        public CategoryAPIController(testContext context)
        {
            _context = context;
        }
        public ActionResult<List<Category>> getAllCategories(){
            return _context.Categories.ToList();
        }

    }
}