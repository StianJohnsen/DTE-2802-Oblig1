using LabOppgave1.Data;
using LabOppgave1.Models.Entities;
using LabOppgave1.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LabOppgave1.Models
{
    public class ProductRepository : IProductRepository
    {

        private ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = db.Product
                .Include(cat => cat.Category)
                .Include(man => man.Manufacturer)
                .ToList();
        return products;
        }

        public ProductEditViewModel GetProductEditViewModel()
        {

            var viewModel = new ProductEditViewModel
            {
                Categories = db.Category.ToList(),
                Manufacturers = db.Manufacturer.ToList()

            };
            return viewModel;
                
        }

        public void Save(Product product)
        {
            db.Product.Add(product);
            db.SaveChanges();
        }
    }
}
