using Microsoft.AspNetCore.Mvc;
using sampleMVC.Entities;

namespace sampleMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ClientController : ControllerBase
    {
        private readonly testContext _context;

        public ClientController(testContext context)
        {
            _context = context;
        }

        public ActionResult<List<Category>> getCats(){
            return _context.Categories.ToList();
        }

        public ActionResult postcat(string name){
            Category c = new Category(){
                Name = name
            };

            _context.Categories.Add(c);
            _context.SaveChanges();

            return Ok();
        }
    }
}