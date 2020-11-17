using curso_vax.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace curso_vax
{
    class Tcomentario:Dto
    {
        
        int idcomentario;
        string alumno;
        int puntaje;
        string comentariotexto;
        int cursoid;

        [Key]
        public int Idcomentario { get => idcomentario; set => idcomentario = value; }
        public string Alumno { get => alumno; set => alumno = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public string Comentariotexto { get => comentariotexto; set => comentariotexto = value; }
        public int Cursoid { get => cursoid; set => cursoid = value; }
        public Tcurso Tcurso { get; set; }
    }
}
