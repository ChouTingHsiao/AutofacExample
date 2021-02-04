using System.Collections.Generic;
using WebAPI.Models.DTO;

namespace WebAPI.Models.Interfaces.BLO
{
    public interface ICourseSelect_BLO
    {

        List<Course> GetAllCourse();

        List<Student> GetAllStudent();

        string Select(Course item);

    }
}
