using System.Collections.Generic;
using WebAPI.Models.DTO;

namespace WebAPI.Models.Interfaces.DAO
{
    public interface IStudent_DAO
    {

        List<Student> GetAll();

        void Create(Student item);

    }
}
