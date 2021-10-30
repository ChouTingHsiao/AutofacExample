using WebAPI.Core.ViewModel;
using WebAPI.Validation.CourseValidation.ViewModel;

namespace WebAPI.Validation.CourseValidation.Interfaces
{
    interface ICourseCheck
    {
        CheckState Check(CourseSelect courseSelect);
    }
}
