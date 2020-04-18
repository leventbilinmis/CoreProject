using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Repositories;

namespace Core.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task CommitAsync();

        void Commit();
    }
}
