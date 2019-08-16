using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.DTO;

namespace WebAPI.Models.Interfaces.DAO
{
    public interface IMaintain<T> where T:class
    {
        List<T> GetAll();
        void Create(T item);

    }
}
