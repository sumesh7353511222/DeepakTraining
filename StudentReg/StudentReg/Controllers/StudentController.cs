using StudentReg.EF;
using StudentReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentReg.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //StudentEntity
            //return View();
            using (var context = new StudentEntities())
            {
                List<Student> students = context.Students.ToList() ;

                List<StudentModel> lstST = new List<StudentModel>();
                foreach (var item in students)
                {
                    //StudentModel s = new StudentModel( {
                    //    DOB = item.DOB.Value, StudentAddress = item.StudentAddress, StudentAge = item.StudentAge.Value , StudentEmail = item.StudentEmail, StudentId = item.StudentId, StudentMobileNo = item.StudentMobileNo.Value, StudentName= item.StudentName 
                    //})
                    StudentModel s = new StudentModel();
                    s.DOB = item.DOB.Value;
                    s.StudentAddress = item.StudentAddress;
                    s.StudentAge = item.StudentAge.Value;
                    s.StudentEmail = item.StudentEmail;
                    s.StudentId = item.StudentId;
                    s.StudentMobileNo = item.StudentMobileNo.Value;
                    s.StudentName = item.StudentName;
                    lstST.Add(s);


                }
                return View(lstST);
            }
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            using (var context = new StudentEntities())
            {
                Student item = context.Students.Find(id);
                StudentModel s = new StudentModel();
                s.DOB = item.DOB.Value;
                s.StudentAddress = item.StudentAddress;
                s.StudentAge = item.StudentAge.Value;
                s.StudentEmail = item.StudentEmail;
                s.StudentId = item.StudentId;
                s.StudentMobileNo = item.StudentMobileNo.Value;
                s.StudentName = item.StudentName;
                return View(s);
            }
        }

        // GET: Student/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // Form Collection passing
        /*
        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                
                // TODO: Add insert logic here
                using (var context = new StudentEntities())
                {
                    Student st = new Student();
                    st.DOB = Convert.ToDateTime( "2000-12-12");
                    st.StudentAddress = Convert.ToString( collection["StudentAddress"]);
                    st.StudentAge = Convert.ToInt32(collection["StudentAge"]);
                    st.StudentEmail = Convert.ToString(collection["StudentEmail"]);
                    st.StudentId = Convert.ToInt32(collection["StudentId"]);
                    st.StudentMobileNo = Convert.ToInt64(collection["StudentMobileNo"]);
                    st.StudentName = Convert.ToString(collection["StudentName"]);

                    context.Students.Add(st);
                    context.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }
        */
        // Model Based Passing
        [HttpPost]
        public ActionResult Create(StudentModel st)
        {
            //try
            //{

            //    if (ModelState.IsValid)
            //    {

            //        // TODO: Add insert logic here
            //        using (var context = new StudentEntities())
            //        {
            //            Student st1 = new Student();
            //            st1.DOB = Convert.ToDateTime("2000-12-12");
            //            st1.StudentAddress = Convert.ToString(st.StudentAddress);
            //            st1.StudentAge = Convert.ToInt32(st.StudentAge);
            //            st1.StudentEmail = Convert.ToString(st.StudentEmail);
            //            st1.StudentId = Convert.ToInt32(st.StudentId);
            //            st1.StudentMobileNo = Convert.ToInt64(st.StudentMobileNo);
            //            st1.StudentName = Convert.ToString(st.StudentName);

            //            context.Students.Add(st1);
            //            context.SaveChanges();


            //        }
            //        return RedirectToAction("Index");
            //    }
            //    else
            //    {
            //        return View();
            //    }
            //}
            //catch
            //{
            //    return View();
            //}
            try
            {

                if (ModelState.IsValid)
                {

                    // TODO: Add insert logic here
                    using (var context = new StudentEntities())
                    {

                        Student checkStudent = context.Students.Find(st.StudentId);

                       // 9072756600



                    }
                    using (var context1 = new StudentEntities())
                    {
                        Student st1 = new Student();
                        st1.DOB = Convert.ToDateTime("2000-12-12");
                        st1.StudentAddress = Convert.ToString(st.StudentAddress);
                        st1.StudentAge = Convert.ToInt32(st.StudentAge);
                        st1.StudentEmail = Convert.ToString(st.StudentEmail);
                        st1.StudentId = Convert.ToInt32(st.StudentId);
                        st1.StudentMobileNo = Convert.ToInt64(st.StudentMobileNo);
                        st1.StudentName = Convert.ToString(st.StudentName);

                         
                        context1.Entry(st).State = System.Data.Entity.EntityState.Modified;
                        context1.SaveChanges();
                    }

                    return RedirectToAction("Index");




                    //***********Connected****************

                    //                    Pros:

                    //                    Performs fast.
                    //    The context keeps track of all entities and automatically sets an appropriate state as and when changes occurr to entities.

                    //Cons:

                    //    The context stays alive, so the connection with the database stays open.
                    //    Utilizes more resources.


                    // Disconnected
                    //                    Pros:

                    //                    Utilizes less resources compared to the connected scenario.
                    //    No open connection with the database.

                    //Cons:

                    //                    Need to set an appropriate state to each entity before saving.
                    //    Performs slower than the connected scenario.


                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
        

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            // return View();
            using (var context = new StudentEntities())
            {
                Student item = context.Students.Find(id);
                StudentModel s = new StudentModel();
                s.DOB = item.DOB.Value;
                s.StudentAddress = item.StudentAddress;
                s.StudentAge = item.StudentAge.Value;
                s.StudentEmail = item.StudentEmail;
                s.StudentId = item.StudentId;
                s.StudentMobileNo = item.StudentMobileNo.Value;
                s.StudentName = item.StudentName;
                return View(s);
            }
        }

        // POST: Student/Edit/5
       /* [HttpPost]
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
        }*/

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            using (var context = new StudentEntities())
            {
                Student item = context.Students.Find(id);
                StudentModel s = new StudentModel();
                s.DOB = item.DOB.Value;
                s.StudentAddress = item.StudentAddress;
                s.StudentAge = item.StudentAge.Value;
                s.StudentEmail = item.StudentEmail;
                s.StudentId = item.StudentId;
                s.StudentMobileNo = item.StudentMobileNo.Value;
                s.StudentName = item.StudentName;
                return View(s);
            }
            
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            //try
            //{
            //    // TODO: Add delete logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
            try
            {
                using (var context = new StudentEntities())
                {
                    Student item = context.Students.Find(id);
                    if (item != null)
                    {
                        context.Students.Remove(item);
                        context.SaveChanges();

                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}
