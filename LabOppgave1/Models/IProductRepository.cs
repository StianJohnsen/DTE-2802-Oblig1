using LabOppgave1.Models.Entities;
using LabOppgave1.Models.ViewModels;

namespace LabOppgave1.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        void Save(Product product);
        ProductEditViewModel GetProductEditViewModel();
    }
}
