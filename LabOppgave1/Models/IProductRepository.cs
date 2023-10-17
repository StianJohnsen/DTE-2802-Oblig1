using LabOppgave1.Models.Entities;

namespace LabOppgave1.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        void Save(Product product);
    }
}
