using System.Collections.Generic;
using WebAPI.Core.Attributes;
using WebAPI.Core.DTO;
using WebAPI.Core.Interfaces.DAO;

namespace WebAPI.Core.DAO
{
    [AutoInject]
    public class StudentDao: IStudentDao
    {
        private readonly List<Student> _StudentList;

        public StudentDao()
        {
            _StudentList = new List<Student>();
        }

        public List<Student> GetAll()
        {
            List<Student> StudentList = new List<Student>();

            StudentList.Add( new Student{ID=1,Name="張三",Age=19 });

            StudentList.Add( new Student{ID=2,Name="李四",Age=20 });

            return StudentList;
        }

        public void Create(Student item)
        {
            _StudentList.Add(item);
        }
    }
}
