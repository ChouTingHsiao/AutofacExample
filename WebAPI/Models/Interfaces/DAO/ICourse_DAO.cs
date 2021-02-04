using System.Collections.Generic;
using WebAPI.Models.DTO;

namespace WebAPI.Models.Interfaces.DAO
{
    public interface ICourse_DAO
    {

        List<Course> GetAll();
        
        void Create(Course item);

    }
}
