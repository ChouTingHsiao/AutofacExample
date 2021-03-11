using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Core.DTO
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Name { get; set; }
        public int Score { get; set; }
        public int StudentID { get; set; }
    }
}
