using System.Collections.Generic;
using System.Linq;
using WebAPI.Core.Attributes;
using WebAPI.Core.DTO;
using WebAPI.Core.Interfaces.BLO;
using WebAPI.Core.Interfaces.DAO;
using WebAPI.Core.Interfaces.Validation;
using WebAPI.Core.ViewModel;

namespace WebAPI.Core.DAO
{
    [AutoInject]
    public class CourseSelectBlo : ICourseSelectBlo
    {
        private readonly ICourseDao _courseDao;
        private readonly IStudentDao _studentDao;
        private readonly ICourseValidation _courseValidation;
        
        public CourseSelectBlo(ICourseDao courseDao,
                               IStudentDao studentDao,
                               ICourseValidation courseValidation)
        {
            _courseDao = courseDao;
            _studentDao = studentDao;
            _courseValidation = courseValidation;
        }

        public List<Course> GetAllCourse()
        {
            return _courseDao.GetAll();
        }

        public List<Student> GetAllStudent()
        {
            return _studentDao.GetAll();
        }
        
        public string Select(Course item)
        {
            CourseCheckState courseCheckState = new CourseCheckState
            {
                IsValidate = true
            };

            Student student = _studentDao.GetAll().SingleOrDefault(x => x.Id == item.StudentId);

            List<Course> courseSelected = _courseDao.GetAll().Where(x => x.StudentId == student.Id).ToList();

            student.Courses = courseSelected;

            courseCheckState.CourseSelect = new CourseSelect {
                Student = student,
                Course = item
            };

            _courseValidation.Check(courseCheckState);

            if (!courseCheckState.IsValidate)
            {
                return courseCheckState.Message;
            }

            _courseDao.Create(item);

            return "Course Select Success";
        }
    }
}
