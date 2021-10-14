using System;


namespace BusquedaSecuencial
{
    class Busqueda
    {
        int numero, i = 0, p = 0;
        int[] vec = { 2, 14, 3, 5, 88, 6, 3, 8, 9, 10 };
        bool encontro = false;
        public Busqueda()
        {
            Console.WriteLine("Número a buscar: ");
            numero = int.Parse(Console.ReadLine());

            while(!(encontro) && i<10)
            {
                if (numero == vec[i])
                {
                    encontro = true;
                    p = i;
                }
                i = i + 1;
            }
            if (encontro)
            {
                Console.WriteLine("El número se encontró en la posición: " + (p + 1));
            }
            else
            {
                Console.WriteLine("No se encontró");
            }
        }
    }
}
