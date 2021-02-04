using System.Collections.Generic;
using WebAPI.Models.Attributes;
using WebAPI.Models.DTO;
using WebAPI.Models.Interfaces.DAO;

namespace WebAPI.Models.DAO
{
    [AutoInject]
    public class Course_DAO: ICourse_DAO
    {

        private readonly List<Course> _CourseList;

        public Course_DAO()
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
