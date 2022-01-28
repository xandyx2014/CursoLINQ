using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11_Misc
{
    public class SequenceEqualDemo
    {
        public static void Ejemplo()
        {
            string[] A = { "felipe", "fernando" };

            string[] B = { "felipe", "fernando" };

            string[] C = { "FEliPE", "FernandO" };

            string[] D = { "fernando", "felipe" };
            // comprueba si tiene los mismo elementos

            var AB = A.SequenceEqual(B);

            var AC = A.SequenceEqual(C);
            // Comprueba si tiene los mismo , ignorando Case
            var ACSinImportarMayusculas = A.SequenceEqual(C, StringComparer.OrdinalIgnoreCase);

            var AD = A.SequenceEqual(D);
            Console.WriteLine(AB);
            Console.WriteLine(AC);
            Console.WriteLine(AD);
            Console.WriteLine(ACSinImportarMayusculas);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
