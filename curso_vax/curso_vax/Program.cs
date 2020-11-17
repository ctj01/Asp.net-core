using curso_vax.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlTypes;

namespace curso_vax
{
    class Program
    {
        static void Main(string[] args)
        {

            var modeloCurso = new ModeloCurso();
            var Show = modeloCurso.Read();
            foreach (var item in Show)
            {
                Console.WriteLine(item.Titulo);
                Console.WriteLine(item.Descripcion);
                Console.WriteLine(item.Fechadepublicacion.ToShortDateString());
            }
         
        }
    }
}
