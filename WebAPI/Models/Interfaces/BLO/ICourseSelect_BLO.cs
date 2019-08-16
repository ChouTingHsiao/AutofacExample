using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.DTO;

namespace WebAPI.Models.Interfaces.BLO
{
    public interface ICourseSelect_BLO
    {
        string Select(Course item);
    }
}
