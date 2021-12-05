using KaurBooks.DataAccess.Repository.IRepository;
using AmandeepKBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using KaurBooks.Models;

namespace KaurBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork      //make the method public to access the class 
    {
        private readonly ApplicationDbContext _db;   // the using statement 

        public CategoryRepository Category { get; }

        public UnitOfWork(ApplicationDbContext db)   // constructor to use DI and inject in the repository
        {
            _db = db;
            Category = new CategoryRepository(_db);
<<<<<<< HEAD
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
=======
            

>>>>>>> d4ee44d8d860d6acd668629e1be7d4fc91fe9837

            SP_Call = new SP_Call(_db);
        }

        

        public ISP_Call SP_Call { get; private set; }

<<<<<<< HEAD
        public ICoverTypeRepository CoverType { get; private set; }

        public IProductRepository Product { get; private set; }

=======
        ICategoryRepository IUnitOfWork.Category => throw new NotImplementedException();
>>>>>>> d4ee44d8d860d6acd668629e1be7d4fc91fe9837

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()   // all changes will be saved when the save method is called at parent level.
        {
            _db.SaveChanges();
        }

    }
}

