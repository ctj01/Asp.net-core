using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace curso_vax
{
    class Tprecio
    {
        decimal precioactual;
        decimal promocion;
        int cursoid;
        int precioid;
        [Key]
        public int Precioid { get => precioid; set => precioid = value; }
        public decimal Precioactual { get => precioactual; set => precioactual = value; }
        public decimal Promocion { get => promocion; set => promocion = value; }
        public int Cursoid { get => cursoid; set => cursoid = value; }
        public Tcurso Tcurso { get; set; }
    }
}
