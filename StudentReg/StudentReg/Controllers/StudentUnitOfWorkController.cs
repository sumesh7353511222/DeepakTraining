using StudentReg.DesignPattern;
using StudentReg.EF;
using StudentReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentReg.Controllers
{
    public class StudentUnitOfWorkController : Controller
    {
        private IGenericRepository<Student> repository = null;
        // GET: StudentUnitOfWork
        public ActionResult Index()
        {
            //using (var context = new StudentEntities())
            //{
            //    List<Student> students = context.Students.ToList();

            //    List<StudentModel> lstST = new List<StudentModel>();
            //    foreach (var item in students)
            //    {
            //        //StudentModel s = new StudentModel( {
            //        //    DOB = item.DOB.Value, StudentAddress = item.StudentAddress, StudentAge = item.StudentAge.Value , StudentEmail = item.StudentEmail, StudentId = item.StudentId, StudentMobileNo = item.StudentMobileNo.Value, StudentName= item.StudentName 
            //        //})
            //        StudentModel s = new StudentModel();
            //        s.DOB = item.DOB.Value;
            //        s.StudentAddress = item.StudentAddress;
            //        s.StudentAge = item.StudentAge.Value;
            //        s.StudentEmail = item.StudentEmail;
            //        s.StudentId = item.StudentId;
            //        s.StudentMobileNo = item.StudentMobileNo.Value;
            //        s.StudentName = item.StudentName;
            //        lstST.Add(s);


            //    }
            //    return View(lstST);
            //}
            var model = repository.GetAll();
            return View(model);
        }

        // GET: StudentUnitOfWork/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentUnitOfWork/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentUnitOfWork/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentUnitOfWork/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentUnitOfWork/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentUnitOfWork/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentUnitOfWork/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
