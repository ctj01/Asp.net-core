using curso_vax.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace curso_vax.Managers
{
    interface IInstructorManager:IGenericRespository<Instructor>
    {
        IEnumerable<Instructor> MuestraInstructoresConUniD(int id);
    }
}
