using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Core.DTO;
using WebAPI.Core.Interfaces.BLO;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseSelectController : ControllerBase
    {
        private readonly ICourseSelectBlo _CourseSelect_BLO;
       
        public CourseSelectController(ICourseSelectBlo CourseSelect_BLO)
        {
            _CourseSelect_BLO = CourseSelect_BLO;
        }

        [HttpGet]
        public List<Course> AllCourse()
        {
            return _CourseSelect_BLO.GetAllCourse();
        }

        [HttpGet]
        public List<Student> AllStudent()
        {
            return _CourseSelect_BLO.GetAllStudent();
        }

        [HttpGet]
        public string SelectCourse([FromQuery]Course item)
        {
            return _CourseSelect_BLO.Select(item);
        }
    }
}
