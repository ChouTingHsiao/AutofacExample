using System.Collections.Generic;
using WebAPI.Core.Attributes;
using WebAPI.Core.DTO;
using WebAPI.Core.Interfaces.DAO;

namespace WebAPI.Core.DAO
{
    [AutoInject]
    public class CourseDao: ICourseDao
    {
        private readonly List<Course> _CourseList;

        public CourseDao()
        {
            _CourseList = new List<Course>();
        }

        public List<Course> GetAll()
        {

            List<Course> CourseList = new List<Course>();

            CourseList.Add(new Course {CourseID = 1 ,Name = "微積分", Score=2,StudentID=1});

            CourseList.Add(new Course {CourseID = 2, Name = "管理學", Score=3,StudentID=1});

            return CourseList;

        }

        public void Create(Course item)
        {

            _CourseList.Add(item);

        }
    }
}
