using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        // IRepository  tanımlanan sorgular genel sorgulardır. bu sorguların dışında bir
        // metod tanımı yapılacaksa belirtilen repository de metod tanımlaması yapılması lazım

        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
