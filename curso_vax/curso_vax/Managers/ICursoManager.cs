using curso_vax.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace curso_vax.Managers
{
    interface ICursoManager:IGenericRespository<Tcurso>
    {
        /// <summary>
        /// consultar todos los cursos con un precio dado
        /// </summary>
        /// <returns> muestra todos los curso en el rango dado</returns>
        IEnumerable<Tcurso> CursoEnRangoPrecios(decimal precio);
    }
}
