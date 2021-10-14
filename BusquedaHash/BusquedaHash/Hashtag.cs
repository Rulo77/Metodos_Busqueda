using System;
using System.Collections;


namespace BusquedaHash
{
    class Hashtag
    {
        String nombre;
        int matricula;
        int llave;
        Hashtable miHash = new Hashtable();
        int opc;


        public Hashtag()
        {
            do
            {
                Menu();
                MenuFinal();


            } while (opc == 1);


        }

        public void Menu()
        {
            Console.WriteLine("Que deseas realizar: ");
            Console.WriteLine("1.-Agregar");
            Console.WriteLine("2.-Modificar");
            Console.WriteLine("3.-Eliminar");
            Console.WriteLine("4.-Imprimir");
            opc = int.Parse(Console.ReadLine()); 

            switch (opc)
            {
                case 1:
                    Agregar();
                    break;

                case 2:
                    Modificar();
                    break;

                case 3:
                    Eliminar();
                    break;

                case 4:
                    Imprimir();
                    break;

                default:
                    Console.WriteLine("no se encontro la opcion elegida");
                    Console.ReadKey();
                    Menu();
                    break;
            }

        }

        public void Agregar()
        {
            Console.WriteLine("Introduce la matricula del alumno a guardar:");
            matricula = int.Parse(Console.ReadLine());
            Calcular(matricula);
            if (miHash.Contains(llave)==false)
            {
                Console.WriteLine("Inserte el nombre del alumno:");
                nombre = Console.ReadLine();
                miHash[llave] = nombre;
            }
            else
            {
                Console.WriteLine("El alumno ya esta registrado");
                Agregar();
            }
        }
        public void Modificar()
        {
            Console.WriteLine("Introduce la matricula del alumno a modificar:");
            matricula = int.Parse(Console.ReadLine());
            Calcular(matricula);
            if (miHash.Contains(llave) == false)
            {
                Console.WriteLine("El alumno no existe en la base de datos");
                Modificar();
            }
            else
            {
               
                Console.WriteLine("Inserte el nombre modificado del alumno:");
                nombre = Console.ReadLine();
                miHash[llave] = nombre;
            }

        }

        public void Eliminar()
        {
            Console.WriteLine("Introduce la matricula del alumno a eliminar:");
            matricula = int.Parse(Console.ReadLine());
            Calcular(matricula);
            if (miHash.Contains(llave) == false)
            {
                Console.WriteLine("El alumno no existe en la base de datos");
                Eliminar();
            }
            else
            {
                miHash.Remove(llave);
                Console.WriteLine("se elimin el alumno");
               
            }
        }
        public void Imprimir()
        {
            foreach(DictionaryEntry item in miHash)
            {
                Console.WriteLine("  " + item.Key + "  " + item.Value);
            }
        }
        public void MenuFinal()
        {
            Console.WriteLine("Deseas realizar mas consultas: 1.-si, 2.-no");
            opc = int.Parse(Console.ReadLine());
        }
        public int Calcular(int x)
        {
            llave = (x % 1000000);
            return llave;
        }




    }
}
