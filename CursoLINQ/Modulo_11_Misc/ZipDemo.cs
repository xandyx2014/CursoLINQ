
namespace CursoLINQ.Modulo_11_Misc
{
    public class ZipDemo
    {
        public static void Ejemplo()
        {
            int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };

            var combinados = A.Zip(B);
            foreach (var (First, Second) in combinados)
            {
                Console.WriteLine($"({First}, {Second})");
            }

            var resultado = A.Zip(B, (a, b) => a * b);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
