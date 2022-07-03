using SimplewebApi.Entities;
using SimplewebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplewebApi.Repositories
{
    public class CourseRepositoy:ICourseRepositoy
    {
        RepositoriesContext context;
        public CourseRepositoy(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddCourse(Course course)
        {
            context.courses.Add(course);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteCourse(int id)
        {
            var cour = context.courses.Where(c => c.Id == id).SingleOrDefault();
            if (cour != null)
            {
                context.courses.Remove(cour);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Course> GetAllCourse()
        {
            return context.courses.ToList();
        }

        public int ModifyCourse(Course course)
        {
            
            var cour = context.courses.Where(p => p.Id == course.Id).SingleOrDefault();
            if (cour != null)
            {
                cour.CourseName = course.CourseName;
                cour.CourseFees = course.CourseFees;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}

