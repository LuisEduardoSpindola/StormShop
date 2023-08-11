using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StormShop.API.Models;
using StormShop.API.Services;

namespace StormShop.Web.Controllers
{
    public class ProductController : Controller
    {

        private ServiceProduct _ServiceProduct { get; set; }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product products) 
        {
            if (ModelState.IsValid) 
            {
                return View(products);
            }

            _ServiceProduct._RepositoryProduct.Create(products);

            return View("List");
        }


        //[Authorize()]
        public IActionResult ReadAll() 
        {
          IEnumerable<Product> products = _ServiceProduct._RepositoryProduct.ReadAll();
          return View(products);
        }

        public IActionResult Update(int id) 
        {
            Product productUpdated = _ServiceProduct._RepositoryProduct.FindById(id);
            return View(productUpdated);
        }

        [HttpPost]
        public IActionResult Update(Product product) 
        {
            _ServiceProduct._RepositoryProduct.Update(product);
            return View("List");
        }

        public IActionResult Delete(int id) 
        {
            _ServiceProduct._RepositoryProduct.DeleteById(id);
            return View("List");
        }
    }
}
