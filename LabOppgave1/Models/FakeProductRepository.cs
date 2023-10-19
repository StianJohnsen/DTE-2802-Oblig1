using LabOppgave1.Models.Entities;
using LabOppgave1.Models.ViewModels;

namespace LabOppgave1.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 6, Name = "BMW 1-serie", Price = 300000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 7, Name = "BMW 2-serie", Price = 400000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 8, Name = "BMW 3-serie", Price = 500000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 9, Name = "BMW 4-serie", Price = 600000m, CategoryId = 2, ManufacturerId = 2 },
                new Product { ProductId = 10, Name = "BMW 5-serie", Price = 700000m, CategoryId = 2, ManufacturerId = 2 },
            };
            return products;
        }

        public ProductEditViewModel GetProductEditViewModel()
        {
            throw new NotImplementedException();
        }
        
        public ProductEditViewModel GetProductEditViewModelById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }


        public void Save(Product product)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
