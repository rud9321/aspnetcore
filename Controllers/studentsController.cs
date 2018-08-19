using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreapp2._0.DataAccess;
using coreapp2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreapp2._0.Controllers
{
    public class studentsController : Controller
    {
        protected DataBaseContext db;

        public studentsController(DataBaseContext dataBaseContext)
        {
            db = dataBaseContext;
        }
        // GET: students
        public ActionResult Index()
        {

            return View(db.Students.ToList());
        }

        // GET: students/Details/5
        public ActionResult Details(int id)
        {

            return View(db.Students.Where(_ => _.Id.Equals(id)).FirstOrDefault());
        }

        // GET: students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: students/Create
        [HttpPost]
        public ActionResult Create(student collection)
        {
            try
            {
                // TODO: Add insert logic here
                db.Students.Add(new coreapp2.Models.student{Name=collection.Name,Age=collection.Age,Address=collection.Address});
                db.SaveChanges(); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: students/Edit/5
        public ActionResult Edit(int id)
        {        
            return View(db.Students.Where(_ => _.Id.Equals(id)).FirstOrDefault());
        }

        // POST: students/Edit/5
        [HttpPost]
        public ActionResult Edit(student collection)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(collection).State = EntityState.Modified;
                db.SaveChanges(); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        // POST: students/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                db.Students.Remove(db.Students.Where(_ => _.Id.Equals(id)).FirstOrDefault());
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Content("Error to delete this record...");
            }
        }
    }
}