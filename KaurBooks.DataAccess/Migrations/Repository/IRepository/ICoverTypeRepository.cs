using KaurBooks.DataAccess.Repository.IRepository;
using KaurBooks.Models;

namespace KaurBooks.DataAccess.Migrations.Repository.IRepository
{
    public  interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
