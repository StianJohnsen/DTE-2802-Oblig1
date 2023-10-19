using LabOppgave1.Models.Entities;
using LabOppgave1.Models.ViewModels;

namespace LabOppgave1.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        void Save(Product product);
        void Edit(Product product);
        void Delete(Product product);
        ProductEditViewModel GetProductEditViewModel();
        ProductEditViewModel GetProductEditViewModelById(int id);
         Product GetProductById(int id);
    }
}
