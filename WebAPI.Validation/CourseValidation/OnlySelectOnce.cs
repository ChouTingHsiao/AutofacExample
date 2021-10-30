using WebAPI.Core.DTO;
using WebAPI.Validation.CourseValidation.Interfaces;
using WebAPI.Validation.CourseValidation.ViewModel;

namespace WebAPI.Validation.CourseValidation
{
    public class OnlySelectOnce : ICourseCheck
    {
        public CheckState Check(Student student)
        {
            throw new System.NotImplementedException();
        }
    }
}
