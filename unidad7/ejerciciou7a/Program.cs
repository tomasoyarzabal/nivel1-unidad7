﻿using System;

namespace ejerciciou7a
{
    class Program
    {
        static void Main(string[] args)
        {
         // Hacer un programa que solicite 10 números enteros y los guarde en un vector.
         // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
         
            int [] numeros = new int [10];
            for(int x = 0; x < 10; x++)
            {
             Console.WriteLine("ingrese numeros");
             numeros [x]= int.Parse(Console.ReadLine());
            }
            int max = numeros[0];
            int pos = 1;
            for(int x = 0; x < 10; x++)
            {
                if(numeros [x] > max)
                
                   max = numeros [x];
                   pos = x + 1;
            }
            Console.WriteLine("el max es " + max);
            Console.WriteLine("en la posicion " + pos);
        }
    }
}
