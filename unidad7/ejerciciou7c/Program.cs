﻿using System;

namespace ejerciciou7c
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
            //Mostrar el resultado en pantalla.
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"
            char[] frase = new char[30];
            char letraActual;
            char letraNueva;
            char letra;
            int indice = 0;

            Console.WriteLine("ingrese una letra para la  frase ");
            letra = char.Parse(Console.ReadLine());
            while (letra != '0' && indice < 30)
            {
                frase[indice] = letra;
                Console.WriteLine("ingrese otra letra para la frase");
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
                frase[indice] = '\0';
                Console.WriteLine("la frase completa es: ");
                indice = 0;
           while (frase[indice] != '\0')
            {
                 Console.Write(frase[indice]);
                 indice++;
            }
                Console.WriteLine(" ingrese la letra a cambiar");
                letraActual = char.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la nuvea letra");
                letraNueva = char.Parse(Console.ReadLine());

                indice = 0;
                while (frase[indice] != '\0')
                {
                    if(frase[indice] == letraActual)
                    
                      frase[indice] = letraNueva;
                    
                      indice++;
                }
                Console.WriteLine("la frase nueva es ");
                indice = 0;
                while (frase[indice] != '\0')
                {
                    Console.Write(frase[indice]);
                    indice++;
                }


    
            
        }
    }
}
