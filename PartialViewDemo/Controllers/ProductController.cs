using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Models;

namespace PartialViewDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;
        private ProductCRUD db;
        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
            db = new ProductCRUD(this.context);
        }
        public IActionResult Index()
        {
            return View(db.GetProducts());
        }
    }
}
