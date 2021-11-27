<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaurBooks.DataAccess.Migrations.Repository.IRepository
{
    interface ICoverTypeRepository
    {
=======
﻿using KaurBooks.DataAccess.Repository.IRepository;
using KaurBooks.Models;

namespace KaurBooks.DataAccess.Migrations.Repository.IRepository
{
    public  interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
>>>>>>> b0c9eab4087d1f76bb5b34406c8cc6bb41f95799
    }
}
