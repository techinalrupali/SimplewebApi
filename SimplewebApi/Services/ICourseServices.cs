using SimplewebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplewebApi.Services
{
    public interface ICourseServices
    {
        IEnumerable<Course> GetAllCourse();
        int AddCourse(Course course);
        int ModifyCourse(Course course);
        int DeleteCourse(int id);
    }
}
