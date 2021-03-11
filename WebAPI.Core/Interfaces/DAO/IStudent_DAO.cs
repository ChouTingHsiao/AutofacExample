using System.Collections.Generic;
using WebAPI.Core.DTO;

namespace WebAPI.Core.Interfaces.DAO
{
    public interface IStudent_DAO
    {

        List<Student> GetAll();

        void Create(Student item);

    }
}
