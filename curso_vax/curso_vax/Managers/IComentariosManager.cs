using curso_vax.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace curso_vax.Managers
{
    interface IComentariosManager:IGenericRespository<Tcomentario>
    {
        IEnumerable<Tcomentario> MuestraComentariosDeUnCursoDado(string Pnombre_curso);
    }
}
