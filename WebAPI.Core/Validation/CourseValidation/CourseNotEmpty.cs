using WebAPI.Core.Attributes;
using WebAPI.Core.Interfaces.Validation;
using WebAPI.Core.ViewModel;

namespace WebAPI.Core.Validation.CourseValidation
{
    [AutoInject]
    public class CourseNotEmpty : ICourseCheck
    {
        public CourseCheckState Check(CourseCheckState courseCheckState)
        {
            CourseSelect courseSelect = courseCheckState.CourseSelect;

            if (courseSelect.Course == null)
            {
                courseCheckState.IsValidate = false;
                courseCheckState.Message = "Course Can't Null";
            }

            return courseCheckState;
        }
    }
}
