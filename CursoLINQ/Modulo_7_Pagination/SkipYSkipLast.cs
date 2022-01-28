using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7_Pagination
{
    public class SkipYSkipLast
    {
        public static void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 100);
            // skip sirve para saltar
            var primeros10Numeros = numeros.Take(10).ToList();
            var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();

            var ultimos10Numeros = numeros.TakeLast(10).ToList();
            var penultimoLote = numeros.SkipLast(10).TakeLast(10).ToList();
            Console.WriteLine(primeros10Numeros);
            Console.WriteLine(ultimos10Numeros);
            Console.WriteLine(segundoLoteDe10);
            Console.WriteLine(penultimoLote);
        }
    }
}
