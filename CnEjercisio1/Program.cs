using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEjercisio1
{
    internal class Program
    {
        /// <summary>
        ///nombre:Juan Esteban Ortiz Rendon
        ///Fecha:28/08/2023
        ///Descripcion:Algoritmo que solicite nombre y edad del ususario y identificar si es mayor de edad y imprimir esta informacion en pantalla
        ///</summary>
        static void Main(string[] args)
        {
            EdadyNombre();
            Console.ReadKey();


        }
        public static void EdadyNombre()
        {
            Console.WriteLine("Porfavor escriba su nombre");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Porfavor digite su edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("La persona:_" + Name + "_Es mayor de edad pues cuenta con una edad de :" + edad);
            }
            else
            {
                Console.WriteLine("La persona:_" + Name + "_Es menor de edad pues cuenta con una edad de :" + edad);
            }

        }
    }

}