using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Attributes;
using WebAPI.Models.DTO;
using WebAPI.Models.Interfaces.BLO;
using WebAPI.Models.Interfaces.DAO;

namespace WebAPI.Models.DAO
{
    [AutoInject]
    public class CourseSelect_BLO : ICourseSelect_BLO
    {
        private readonly IMaintain<Course> _Class_DAO = null;
        private readonly IMaintain<Student> _Student_DAO = null;

        public CourseSelect_BLO(IMaintain<Course> Class_DAO,
                                IMaintain<Student> Student_DAO)
        {
            _Class_DAO = Class_DAO;
            _Student_DAO = Student_DAO;
        }

        public string Select(Course item)
        {
            List<Course> Course_Select = _Class_DAO.GetAll().Where(x => x.StudentID == item.StudentID).ToList();

            if (Course_Select.Where(x => x.CourseID == item.CourseID).Count() > 0)
            {
                return "Course Cant Select Twice";
            }

            _Class_DAO.Create(item);

            return "Course Select Success";
        }
    }
}
