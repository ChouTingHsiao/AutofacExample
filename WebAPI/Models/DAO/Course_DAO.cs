using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Attributes;
using WebAPI.Models.DTO;
using WebAPI.Models.Interfaces.DAO;

namespace WebAPI.Models.DAO
{
    [AutoInject]
    public class Course_DAO: IMaintain<Course>
    {
        private List<Course> _List;
        public Course_DAO()
        {
            _List = new List<Course>();
        }

        public List<Course> GetAll()
        {

            _List.Add(new Course {CourseID = 1 ,Name = "微積分", Score=2,StudentID=1});
            _List.Add(new Course {CourseID = 2, Name = "管理學", Score=3,StudentID=1});

            return _List;
        }

        public void Create(Course item)
        {
            _List.Add(item);
        }

    }
}
