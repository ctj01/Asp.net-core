using curso_vax.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace curso_vax.Interfaces
{
    interface IGenericRespository<T> where T: Dto
    {
        void Create(T Entidad);
        IEnumerable<T> Read();
        void Update(int id);
        void Delete(int id);
    }
}
