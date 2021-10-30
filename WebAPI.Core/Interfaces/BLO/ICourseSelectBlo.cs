using System.Collections.Generic;
using WebAPI.Core.DTO;

namespace WebAPI.Core.Interfaces.BLO
{
    public interface ICourseSelectBlo
    {
        List<Course> GetAllCourse();

        List<Student> GetAllStudent();

        string Select(Course item);
    }
}
