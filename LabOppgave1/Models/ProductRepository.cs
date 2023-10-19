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

        public ProductEditViewModel GetProductEditViewModelById(int id)
        {
            var product = db.Product.Find(id);
            var viewModel = new ProductEditViewModel
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                ManufacturerId = product.ManufacturerId,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Categories = db.Category.ToList(),
                Manufacturers = db.Manufacturer.ToList()
            };
            return viewModel;
        }
        
        public Product GetProductById(int id)
        {
            var product = db.Product.Find(id);
            return product;
        }
        
        public void Save(Product product)
        {
            db.Product.Add(product);
            db.SaveChanges();
        }

         public void Edit(Product product)
         {
             db.Product.Update(product);
             db.SaveChanges();
         }
         
         public void Delete(Product product)
         {
             db.Product.Remove(product);
             db.SaveChanges();
         }
        
    }
}
