using Microsoft.AspNetCore.Mvc;
using MVCAPI.Models;
using System.Data.Common;

namespace MVCAPI.Controllers
{
    public class CategoryController : Controller
    {
        //private readonly DbConnection db;
        //public CategoryController(DbConnection db)
        //{
        //    this.db = db;
        //}
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Add()
        {
            return View("Add");
        }
        //[HttpPost]
        //[Route("/[controller]/[action]/{category}")]
        //public List<Category> CreatNew(Category category)
        //{
        //    if (db.Category.Where(x => x.Name == category.Name).Count() == 0)
        //    {
        //        db.Category.Add(category);
        //        db.SaveChanges();
        //    }
        //    return db.Category.ToList();
        //}
    }
}
