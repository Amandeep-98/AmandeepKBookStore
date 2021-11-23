using AmandeepKBookStore.DataAccess.Data;
using KaurBooks.DataAccess.Migrations.Repository.IRepository;
using KaurBooks.DataAccess.Repository;
using KaurBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace KaurBooks.DataAccess.Migrations.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Add(Models.CoverType entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.CoverType> GetAll(Expression<Func<Models.CoverType, bool>> filter = null, Func<IQueryable<Models.CoverType>, IOrderedQueryable<Models.CoverType>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Models.CoverType GetFirstOrDefault(Expression<Func<Models.CoverType, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Models.CoverType entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Models.CoverType> entity)
        {
            throw new NotImplementedException();
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

        public void Update(Models.CoverType coverType)
        {
            throw new NotImplementedException();
        }

        Models.CoverType IRepository<Models.CoverType>.Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
