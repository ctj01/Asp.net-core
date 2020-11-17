using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace curso_vax
{
    class Instructorcurso
    {
        int instructorid;
        int cursoid;

        [Key]
        public int Instructorid { get => instructorid; set => instructorid = value; }
        [Key]
        public int Cursoid { get => cursoid; set => cursoid = value; }
        public Tcurso Tcurso { get; set; }
        public Instructor Tinstructor { get; set; }
    }
}
