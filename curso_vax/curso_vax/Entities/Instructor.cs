using curso_vax.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace curso_vax
{
    class Instructor:Dto
    {
        int instructorid;
        string nombre;
        string apellido;
        string grado;
        byte[] fotodeperfil;
        [Key]
        public int Instructorid { get => instructorid; set => instructorid = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Grado { get => grado; set => grado = value; }
        public ICollection <Instructorcurso> Instructorcursos { get; set; }
        public byte[] Fotodeperfil { get => fotodeperfil; set => fotodeperfil = value; }
    }
}
