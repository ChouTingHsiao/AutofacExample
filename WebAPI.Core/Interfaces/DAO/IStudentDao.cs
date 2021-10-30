using System.Collections.Generic;
using WebAPI.Core.DTO;

namespace WebAPI.Core.Interfaces.DAO
{
    public interface IStudentDao
    {
        List<Student> GetAll();

        void Create(Student item);
    }
}
