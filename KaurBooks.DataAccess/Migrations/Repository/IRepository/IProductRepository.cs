using KaurBooks.DataAccess.Repository.IRepository;
using KaurBooks.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaurBooks.DataAccess.Migrations.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}