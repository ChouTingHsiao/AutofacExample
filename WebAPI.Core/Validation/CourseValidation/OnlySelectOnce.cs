using System.Linq;
using WebAPI.Core.Attributes;
using WebAPI.Core.Interfaces.Validation;
using WebAPI.Core.ViewModel;

namespace WebAPI.Core.Validation.CourseValidation
{
    [AutoInject]
    public class OnlySelectOnce : ICourseCheck
    {
        public CourseCheckState Check(CourseCheckState courseCheckState)
        {
            CourseSelect courseSelect = courseCheckState.CourseSelect;

            if (courseSelect.Student.Courses.Any(x => x.Id == courseSelect.Course.Id))
            {
                courseCheckState.IsValidate = false;
                courseCheckState.Message = "Course Can't Select Twice";
            }

            return courseCheckState;
        }
    }
}
