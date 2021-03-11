using System.Collections.Generic;
using WebAPI.Core.DTO;

namespace WebAPI.Core.Interfaces.BLO
{
    public interface ICourseSelect_BLO
    {

        List<Course> GetAllCourse();

        List<Student> GetAllStudent();

        string Select(Course item);

    }
}
