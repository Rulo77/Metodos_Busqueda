using System;


namespace RadixSore2
{
    class Inicio
    {
        public Inicio()
        {
            int[] arreglo;
            int x;
            Console.WriteLine("Cantidad de numeros a ingresar: ");
            x = int.Parse(Console.ReadLine());

            arreglo = new int[x];

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ingresa los numeros");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write("Ingresa el numero " + (i+1) + " :");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Arreglo original: ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" " + arreglo[i]);
            }

            Radix(arreglo);

            Console.WriteLine("\n\nArreglo acomodado: ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" " + arreglo[i]);
            }
        }

        private void Radix(int[] arreglo) 
        {
            int i, j;

            int[] temporal = new int[arreglo.Length];

            for (int x = 31; x > 0; x--)
            {

                j = 0;

                for ( i = 0; i < arreglo.Length; i++)
                {
                    bool mover = arreglo[i] << x >= 0;

                    if (x == 0 ? !mover : mover)
                        arreglo[i - j] = arreglo[i];

                    else
                        temporal[j++] = arreglo[i];
                }

                Array.Copy(temporal, 0, arreglo, arreglo.Length - j, j);

            }
        }
        
    }
}
