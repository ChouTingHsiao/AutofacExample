using System.Collections.Generic;
using WebAPI.Core.DTO;

namespace WebAPI.Core.Interfaces.DAO
{
    public interface ICourseDao
    {
        List<Course> GetAll();
        
        void Create(Course item);
    }
}
