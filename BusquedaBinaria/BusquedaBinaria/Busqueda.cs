using System;


namespace BusquedaBinaria
{
    class Busqueda
    {
        int[] arreglo;
        int dimensiones, aux;


        public Busqueda()
        {
            Console.WriteLine("Ingresa la dimension del arreglo: ");
            dimensiones = int.Parse(Console.ReadLine());
            arreglo = new int[dimensiones];

            for(int i = 0; i < dimensiones; i++)
            {
                Console.WriteLine("Ingesa el valor de la posicion " + (i + 1)+" :");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            Ordenar();
        }

        public void Ordenar()
        {

            Array.Sort(arreglo);
            Imprimir();

        }

        public void Imprimir()
        {
            Console.WriteLine("El arreglo es:");
            for(int i = 0; i< arreglo.Length; i++)
            {
                Console.Write("" + arreglo[i] + " ");
            }
            Console.WriteLine();
            Buscar();
        }

        public void Buscar()
        {
            int numero, inicio = 0, final = (arreglo.Length - 1), mediana = 0;
            bool encontro = false;

            Console.WriteLine("ingrese el numero a buscar:");
            numero = int.Parse(Console.ReadLine());

            while(!encontro && inicio <= final)
            {
                mediana = (int)(inicio + final) / 2;
                if (numero==arreglo[mediana])
                {
                    encontro = true;
                }
                else if (numero<arreglo[mediana])
                {
                    final = mediana - 1;
                }
                else
                {
                    inicio = mediana + 1;
                }
            }

            if (encontro==true)
            {
                Console.WriteLine("El numero " + numero + " se encontro en la posicion " + (mediana+1));
            }
            else
            {
                Console.WriteLine("El numero "+numero+"no se encuentra en el arreglo");
            }
        }

    }
}
