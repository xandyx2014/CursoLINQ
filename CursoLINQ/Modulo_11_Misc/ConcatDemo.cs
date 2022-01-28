using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11_Misc
{
    public class ConcatDemo
    {
        public static void Ejemplo()
        {
            int[] A = { 1, 2, 3 };

            int[] B = { 4, 5, 6 };
            // Junta 2 colleciones
            var resultado = A.Concat(B);
            Console.WriteLine(resultado);
            // Nota: no existe sintaxis de query para este código.
        }
    }
}
