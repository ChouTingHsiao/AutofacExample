using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models.DTO;
using WebAPI.Models.Interfaces.BLO;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseSelectController : ControllerBase
    {

        private readonly ICourseSelect_BLO _CourseSelect_BLO;
       
        public CourseSelectController(ICourseSelect_BLO CourseSelect_BLO)
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

        [HttpPost]
        public string SelectCourse([FromBody]Course item)
        {
            return _CourseSelect_BLO.Select(item);
        }

    }
}
