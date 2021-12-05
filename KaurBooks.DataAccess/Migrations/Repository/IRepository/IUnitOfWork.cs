using System;

namespace KaurBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
<<<<<<< HEAD
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }
        ISP_Call SP_Call { get; }
=======

        ISP_Call SP_Call { get; }
        
<<<<<<< HEAD
>>>>>>> d4ee44d8d860d6acd668629e1be7d4fc91fe9837
=======
>>>>>>> d4ee44d8d860d6acd668629e1be7d4fc91fe9837

        void Save();
    }
}
