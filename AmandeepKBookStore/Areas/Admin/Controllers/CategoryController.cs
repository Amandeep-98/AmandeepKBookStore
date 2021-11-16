using KaurBooks.DataAccess.Repository.IRepository;
using KaurBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandeepKBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)     // action method for upsert
        {
            Category category = new Category(); // using KaurBooks.Models;
            if (id == null)
            {
                // this is for create
                return View(category);
            }
            //this for the edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (id == null)
            {
                return NotFound();
            }
            return View();
        }


        // API Calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            // return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion 
    }
}
