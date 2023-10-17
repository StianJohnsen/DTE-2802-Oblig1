using LabOppgave1.Data;
using LabOppgave1.Models.Entities;

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
            return db.Product;
        }

        public void Save(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
