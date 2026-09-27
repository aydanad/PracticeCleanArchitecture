using Clean_arch.Domain.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch_Infrastructure.Persistend.Memory.Product
{
    public class ProductRepository : IProductRepository
    {
        private Context _context;
        private List<Clean_arch.Domain.Products.Product> _products;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public void Add(Clean_arch.Domain.Products.Product product)
        {
             _context.Products.Add(product);
        }

        public Clean_arch.Domain.Products.Product GetById(Guid Id)
        {
            return _context.Products.FirstOrDefault(c => c.Id == Id);
        }

        public List<Clean_arch.Domain.Products.Product> GetLists()
        {
            return _context.Products;
        }

        public bool IsProductExsit(Guid Id)
        {
            return _context.Products.Any(h => h.Id == Id);
        }

        public void Remove(Clean_arch.Domain.Products.Product product)
        {
             _context.Products.Remove(product);
        }

        public void SaveChanges()
        {
           //
        }

        public void Update(Clean_arch.Domain.Products.Product product)
        {
            Remove(product);
            Add(product);
        }
    }
}
