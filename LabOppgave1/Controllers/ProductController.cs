using Microsoft.AspNetCore.Mvc;
using LabOppgave1.Models.Entities;
using LabOppgave1.Models;

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
            return View();
        }


        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // Kall til metoden save i repository
               this.repository.Save(product);
                return RedirectToAction("Index");

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
    }
}
