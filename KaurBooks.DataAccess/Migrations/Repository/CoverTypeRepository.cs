﻿using AmandeepKBookStore.DataAccess.Data;
using KaurBooks.DataAccess.Migrations.Repository.IRepository;
using KaurBooks.DataAccess.Repository;
using KaurBooks.DataAccess.Repository.IRepository;
using System.Linq;
using KaurBooks.Models;

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
        var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
        if (objFromDb != null)
        {
            objFromDb.Name = coverType.Name;
            _db.SaveChanges();

        }
    }
}
}
