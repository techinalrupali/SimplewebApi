using SimplewebApi.Model;
using SimplewebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplewebApi.Services
{
    public class CourseServices: ICourseServices
    {
        private readonly ICourseRepositoy _iCourseRepo;
        // Injecition of Dependancy using constructor
        public CourseServices(ICourseRepositoy iCourseRepo)
        {
            _iCourseRepo = iCourseRepo;
        }
        public int AddCourse(Course course)
        {
            return _iCourseRepo.AddCourse(course);
        }
        public int DeleteCourse(int id)
        {
            return _iCourseRepo.DeleteCourse(id);
        }
        public IEnumerable<Course> GetAllCourse()
        {
            return _iCourseRepo.GetAllCourse();
        }
        public int ModifyCourse(Course course)
        {
            return _iCourseRepo.ModifyCourse(course);
        }
    }
}

