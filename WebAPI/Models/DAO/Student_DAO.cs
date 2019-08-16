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
    public class Student_DAO: IMaintain<Student>
    {
        private List<Student> _List;
        public Student_DAO()
        {
            _List = new List<Student>();
        }

        public List<Student> GetAll()
        {
            List<Student> list = new List<Student>();

            list.Add(new Student{ID=1,Name="張三",Age=19 });
            list.Add(new Student{ID=2,Name="李四",Age=20 });

            return list;
        }

        public void Create(Student item)
        {
            _List.Add(item);
        }
    }
}
