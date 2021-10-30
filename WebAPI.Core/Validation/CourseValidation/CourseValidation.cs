using System.Collections.Generic;
using System.Linq;
using WebAPI.Core.Attributes;
using WebAPI.Core.Interfaces.Validation;
using WebAPI.Core.ViewModel;

namespace WebAPI.Core.Validation.CourseValidation
{
    [AutoInject]
    public class CourseValidation : ICourseValidation
    {
        private readonly List<ICourseCheck> _courseCheck;

        public CourseValidation(IEnumerable<ICourseCheck> courseCheck)
        {
            _courseCheck = courseCheck.ToList();
        }

        public CourseCheckState Check(CourseCheckState courseCheckState)
        {
            foreach (ICourseCheck check in _courseCheck)
            {
                check.Check(courseCheckState);

                if (!courseCheckState.IsValidate)
                {
                    return courseCheckState;
                }
            }

            return courseCheckState;
        }
    }
}
