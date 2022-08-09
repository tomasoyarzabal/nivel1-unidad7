using System;

namespace ejerciociou7b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            //Luego recorrer ese vector para calcular el promedio.
            //Mostrar por pantalla los valores que son mayores al promedio.

            int con = 0;
            int acu = 0;
            int promedio = 0;
            int [] numeros = new int [10];
            for(int x = 0; x < 10; x++)
            {   con++;
                Console.WriteLine("ingrese numeros");
                numeros [x] = int.Parse(Console.ReadLine());
            }
            for(int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }
            promedio = acu / con;
             Console.WriteLine("el promedio es " + promedio);
               for(int x = 0; x < 10; x++)
               {
                if(numeros[x] > promedio)
                
                  Console.WriteLine(" el numero mayor al promedio es : " + numeros[x]);
               }

        


            
        }
    }
}
