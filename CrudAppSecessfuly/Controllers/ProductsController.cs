using CrudAppSecessfuly.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudAppSecessfuly.Controllers
{
    public class ProductsController : Controller
    {
        public readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            return View(_context.products.ToList());
        }

        [HttpGet]
        public IActionResult Inset()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Inset(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("show");
            }
            
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var findedit =  _context.products.Find(id);
            return View(findedit);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Show");
            }
            return View(product);
        }


        public IActionResult Delete(int id )
        {
            var idname =  _context.products.Find(id);
            _context.products.Remove(idname);
            _context.SaveChanges();
            return RedirectToAction("Show");

        }

    }
}
