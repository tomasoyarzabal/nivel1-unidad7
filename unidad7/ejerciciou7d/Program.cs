using System;

namespace ejerciciou7d
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //Número de Artículo (1 a 15)
            //Cantidad Vendida 
            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.


            int nroArticulo;
            int cantidad;
            int[] totalcantvendida = new int[15];
            for (int x = 0; x < 15; x++)
            {
                totalcantvendida[x] = 0;

            }

            Console.WriteLine("ingrese el nro de articulo");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {

            totalcantvendida[nroArticulo - 1] += cantidad;
            Console.WriteLine("ingrese el nro de articulo");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());
            }
            int maxcantidad = totalcantvendida[0];
            int nroMaximo = 1;
            for (int x = 0; x < 15; x++)
            {
                if(totalcantvendida[x] > maxcantidad){
                    maxcantidad = totalcantvendida[x];
                    nroArticulo = x + 1;
                }
            }
            Console.WriteLine("el producto mas vendido es " + nroArticulo + "con " + maxcantidad);
            for (int x = 0; x < 15; x++)
            {
                if(totalcantvendida[x] == 0){
                    Console.WriteLine("el producto" + (x + 1) + "no tuvo ventas");
                }
            }
            Console.WriteLine("la cantidad vendida del producto 10 es " + totalcantvendida[9]);


          

        }
    }
}
