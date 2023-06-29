using Microsoft.AspNetCore.Mvc;

namespace MVCAPI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Add()
        {
            return View("Add");
        }
    }
}
