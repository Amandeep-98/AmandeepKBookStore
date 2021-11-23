using AmandeepKBookStore.DataAccess.Data;
using KaurBooks.DataAccess.Migrations.Repository.IRepository;
using KaurBooks.DataAccess.Repository;
using KaurBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaurBooks.DataAccess.Migrations.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            //use.NET LINQ to retrieve the first or default category objects,
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) // save changer if not null
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }
        }
    }
}
