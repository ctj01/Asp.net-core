using curso_vax.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace curso_vax.Modelos
{
    class ModeloCurso :ICursoManager
    {
        appventacuros conexion = new appventacuros();
        public string Descripcion { get; set; }
        public string Titulo { get; set; }
        public DateTime Fechadepublicacion { get; set; }

        public void Create(Tcurso Entidad)
        {
            Entidad = new Tcurso
            {
                Titulo = Titulo,
                Descripcion = Descripcion,
                Fechadepublicacion = Fechadepublicacion              
            };
            conexion.Add(Entidad);
            conexion.SaveChanges();
        }

        public IEnumerable<Tcurso> CursoEnRangoPrecios(decimal precio)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tcurso> Read()
        {
            var Results = conexion.Tcurso;
            var ListaCurso = new List<Tcurso>();
            foreach (var item in Results)
            {
                ListaCurso.Add(new Tcurso
                {
                    Titulo = item.Titulo,
                    Descripcion = item.Descripcion,
                    Fechadepublicacion = item.Fechadepublicacion
                });
            }
            return (ListaCurso);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
