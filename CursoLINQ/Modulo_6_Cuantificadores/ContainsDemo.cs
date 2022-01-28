using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_6_Cuantificadores
{
    public class ContainsDemo
    {
        public static void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 5);
            // este elemente esta en el 3
            // return bool
            var estaElNumero3 = numeros.Contains(3);
            // este elemento esta en el lemento
            // return bool
            var estaElNumero20 = numeros.Contains(20);
            Console.WriteLine(estaElNumero3);
            Console.WriteLine(estaElNumero20);

        }
    }
}
