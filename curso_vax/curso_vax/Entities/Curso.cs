using curso_vax.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace curso_vax
{
    class Tcurso:Dto
    {
        string titulo;
        string descripcion;
        DateTime fechadepublicacion;
        int cursoid;
        [Key]
        public int Cursoid { get => cursoid; set => cursoid = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fechadepublicacion { get => fechadepublicacion; set => fechadepublicacion = value; }
        public Tprecio PrecioPromocion { get; set; }
        public ICollection<Tcomentario> Comments { get; set; }
        public ICollection<Instructorcurso> Instructorcursos { get; set; }
    }
}
