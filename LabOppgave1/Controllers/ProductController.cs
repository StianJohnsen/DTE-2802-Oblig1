using Microsoft.AspNetCore.Mvc;
using LabOppgave1.Models.Entities;
using LabOppgave1.Models;
using LabOppgave1.Models.ViewModels;

namespace LabOppgave1.Controllers
{
    public class ProductController : Controller
    {

        private IProductRepository repository;

        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            var product = repository.GetProductEditViewModel();
            return View(product);
        }
        
        

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(
            [Bind("Name,Description,Price,ManufacturerId,CategoryId")] ProductEditViewModel productEditViewModel)
        {
            try
            {
                // Kall til metoden save i repository
                var product = new Product
                {
                    ProductId = productEditViewModel.ProductId,
                    Name = productEditViewModel.Name,
                    Description = productEditViewModel.Description,
                    Price = productEditViewModel.Price,
                    ManufacturerId = productEditViewModel.ManufacturerId,
                    CategoryId = productEditViewModel.CategoryId,

                };
                if (ModelState.IsValid)
                {
                    TempData["message"] = string.Format("{0} has been saved", product.Name);
                    repository.Save(product);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Index()
        {
            var products = this.repository.GetAll();
            return View(products);
        }

        public ActionResult Edit(int id)
        {
            var product = repository.GetProductEditViewModelById(id);
            Console.WriteLine(id);
            return View(product);
        }

        public ActionResult Details(int id)
        {
            var product = repository.GetProductEditViewModelById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(int id,
            [Bind("Name,Description,Price,ManufacturerId,CategoryId")] ProductEditViewModel productEditViewModel)
        {
            try
            {
                // Kall til metoden save i repository
                var product = new Product
                {
                    ProductId = id,
                    Name = productEditViewModel.Name,
                    Description = productEditViewModel.Description,
                    Price = productEditViewModel.Price,
                    ManufacturerId = productEditViewModel.ManufacturerId,
                    CategoryId = productEditViewModel.CategoryId,

                };
                if (ModelState.IsValid)
                {
                    TempData["message"] = string.Format("{0} has been saved", product.Name);
                    repository.Edit(product);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var product = repository.GetProductById(id);
            repository.Delete(product);
            return RedirectToAction("Index");
        }
    }
}
