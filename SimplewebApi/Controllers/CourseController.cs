using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimplewebApi.Model;
using SimplewebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplewebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseServices _courseservice;
        public CourseController(ICourseServices courseservice)
        {
            _courseservice = courseservice;
        }
        [HttpGet]

        [Route("GetCourse")]
        public IActionResult GetCourse()
        {
            return new ObjectResult(_courseservice.GetAllCourse());
            // test code
        }
        [HttpPost]
        [Route("AddCourse")]
        public IActionResult AddCourse(Course course)
        {
            return new ObjectResult(_courseservice.AddCourse(course));
        }

        [HttpPost]
        [Route("ModifyCourse")]
        public IActionResult ModifyCourse(Course course)
        {
            return new ObjectResult(_courseservice.ModifyCourse(course));
        }

        [HttpGet]
        [Route("DeleteCourse/{id}")]
        public IActionResult DeleteCourse(int id)
        {
            return new ObjectResult(_courseservice.DeleteCourse(id));
        }

    }
}
