using WebAPI.Core.ViewModel;

namespace WebAPI.Core.Interfaces.Validation
{
    public interface ICourseValidation
    {
        CourseCheckState Check(CourseCheckState courseCheckState);
    }
}
