﻿using KaurBooks.DataAccess.Repository.IRepository;
using KaurBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandeepKBookStore.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)    //action method for Upsert
        {
            CoverType coverType = new CoverType();
            if (id == null)
            {
                // this is for create
                return View(coverType);
            }

            //this for the edit
            coverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (coverType == null)
            {
                return NotFound();
            }
            return View();
        }

        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(CoverType coverType)
        {
            if (ModelState.IsValid)     // checks all validations in the model
            {
                if (coverType.Id == 0)
                {
                    _unitOfWork.CoverType.Add(coverType);

                }
                else
                {
                    _unitOfWork.CoverType.Update(coverType);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index)); // to see all the categories


            }
            return View(coverType);
        }


    // API CALLS//
       
    }

}
