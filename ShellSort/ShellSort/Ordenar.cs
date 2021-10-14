using System;


namespace ShellSort
{
    class Ordenar
    {
        int[] numeros;
        int x;

        public Ordenar()
        {
            Console.WriteLine("Ingrese la dimension del arreglo:");
            x = int.Parse(Console.ReadLine());
            numeros = new int[x];
            Llenar();

        }

        public void Llenar()
        {
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posicion No. " + (i + 1) + " :");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Imprimir();
            Shell();
        }

        public void Imprimir()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]+"  ");
               
            }
            Console.WriteLine();
        }

        public void Shell()
        {
            int salto, aux, reten,i;

            salto = numeros.Length / 2;

            while (salto > 0)
            {
                reten = 1;

                while (reten != 0)
                {
                    reten = 0;
                    i = 0;
                    while (i < (numeros.Length - salto))
                    {
                        if (numeros[i] > numeros[i + salto])
                        {
                            aux = numeros[i];
                            numeros[i] = numeros[i + salto];
                            numeros[i + salto] = aux;
                            reten = 1;
                        }
                        i++;
                    }
                }
                salto = salto / 2;

            }

            Imprimir();
        }

    }
}
