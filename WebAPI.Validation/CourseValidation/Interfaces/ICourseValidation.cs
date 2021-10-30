using WebAPI.Core.ViewModel;
using WebAPI.Validation.CourseValidation.ViewModel;

namespace WebAPI.Validation.Interfaces
{
    interface ICourseValidation
    {
        CheckState Check(CourseSelect courseSelect);
    }
}
