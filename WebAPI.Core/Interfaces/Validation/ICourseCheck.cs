using WebAPI.Core.ViewModel;

namespace WebAPI.Core.Interfaces.Validation
{
    public interface ICourseCheck
    {
        CourseCheckState Check(CourseCheckState courseCheckState);
    }
}
