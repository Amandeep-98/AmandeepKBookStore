using KaurBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaurBooks.Models;

namespace KaurBooks.DataAccess.Migrations.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<Models.CoverType>
    {
        void Update(Models.CoverType coverType);
    }
}