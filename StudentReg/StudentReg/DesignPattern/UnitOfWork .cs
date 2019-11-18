using StudentReg.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentReg.DesignPattern
{
    public class UnitOfWork : IDisposable
    {
        private StudentReg.EF.StudentEntities context = new StudentReg.EF.StudentEntities();
        private GenericRepository<Student> departmentRepository;
        //private GenericRepository<Course> courseRepository;

        public GenericRepository<Student> DepartmentRepository
        {
            get
            {

                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new GenericRepository<Student>(context);
                }
                return departmentRepository;
            }
        }

        //public GenericRepository<Course> CourseRepository
        //{
        //    get
        //    {

        //        if (this.courseRepository == null)
        //        {
        //            this.courseRepository = new GenericRepository<Course>(context);
        //        }
        //        return courseRepository;
        //    }
        //}

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}