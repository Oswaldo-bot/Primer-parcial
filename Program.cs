using System;

namespace Primer_parcial
{
    class Program
    {
        static void Main(string[] cadena)
        {
            Console.WriteLine("Seleccione una conversion");
            Console.WriteLine("1.Cifrado");
            Console.WriteLine("2.Descifrado");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                string binaria = "";
                int i = 0;
                while (i < cadena.Length)
                {
                    if (i < cadena.Length)
                    {
                        binaria = binaria + cadena[i + 1].ToString() +
                            cadena[i].ToString();
                    }
                    else
                    {
                        binaria = binaria + cadena[cadena.Length - 1].ToString();
                    }
                    i = i + 2;
                }
            }
            else
            {
                string binaria = "";
                int i = 0;
                while (i < cadena.Length)
                {
                    if (i < cadena.Length)
                    {
                        binaria = binaria + cadena[i + 1].ToString() +
                            cadena[i].ToString();
                    }
                    else
                    {
                        binaria = binaria + cadena[cadena.Length - 1].ToString();
                    }
                    i = i + 2;
                }
                Console.ReadLine();
            }
        }
    }
}
