using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Products.Repository
{
    public interface IProductRepository
    {
        List<Product> GetLists();
        Product GetById(Guid Id);
        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
        void SaveChanges();
        bool IsProductExsit(Guid Id);
    }
}
