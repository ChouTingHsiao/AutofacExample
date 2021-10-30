using WebAPI.Core.DTO;
using WebAPI.Validation.CourseValidation.ViewModel;
using WebAPI.Validation.Interfaces;

namespace WebAPI.Validation.CourseValidation
{
    public class CourseValidation : ICourseValidation
    {
        public CheckState Check(Student student)
        {
            CheckState checkState = new CheckState
            {
                IsValidate = true
            };

            if (student.Courses.Any(x => x.CourseID == item.CourseID))
            {
                return "Course Cant Select Twice";
            }

            return checkState;
        }
    }
}
