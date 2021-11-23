using KaurBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaurBooks.DataAccess.Migrations.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {

        void Update(CoverType covertype);
    }
}
