using System.Collections.Generic;
using WebAPI.Core.DTO;

namespace WebAPI.Core.Interfaces.DAO
{
    public interface ICourse_DAO
    {

        List<Course> GetAll();
        
        void Create(Course item);

    }
}
