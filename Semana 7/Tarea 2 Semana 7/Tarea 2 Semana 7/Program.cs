
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_Semana_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n_Monto = 0, n_Descuento = 0, n_Tarjeta = 0, n_DescuentoTarjeta = 0, n_MontoF = 0, n_Total = 0;
            Console.WriteLine("¿Usted cuenta con código de descuento? Si = 1, No = 0");
            n_Tarjeta = Convert.ToDouble(Console.ReadLine());

            if (n_Tarjeta == 1)
            {
                Console.WriteLine("Si cuenta con código de descuento");
                n_DescuentoTarjeta = 0.05;
                Console.WriteLine("Ingrese el monto de su compra");
                n_Monto = Convert.ToDouble(Console.ReadLine());
                if (n_Monto <= 0)
                {
                    Console.WriteLine("ERROR");
                }
                else if (n_Monto < 400)
                {
                    n_Descuento = 0;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
                else if (n_Monto <= 1000)
                {
                    n_Descuento = 0.07;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
                else if (n_Monto <= 5000)
                {
                    n_Descuento = 0.1;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
                else if (n_Monto <= 15000)
                {
                    n_Descuento = 0.15;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
                else if (n_Monto > 15000)
                {
                    n_Descuento = 0.25;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
            }
            else if (n_Tarjeta == 0)
            {
                Console.WriteLine("No cuenta con código de descuento");
                n_DescuentoTarjeta = 0;
                Console.WriteLine("Ingrese el monto de su compra");
                n_Monto = Convert.ToDouble(Console.ReadLine());
                if (n_Monto <= 0)
                {
                    Console.WriteLine("ERROR");
                }
                else if (n_Monto < 400)
                {
                    n_Descuento = 0;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
                else if (n_Monto <= 1000)
                {
                    n_Descuento = 0.07;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
                else if (n_Monto <= 5000)
                {
                    n_Descuento = 0.1;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
                else if (n_Monto <= 15000)
                {
                    n_Descuento = 0.15;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
                else if (n_Monto > 15000)
                {
                    n_Descuento = 0.25;
                    n_MontoF = n_Monto - ((n_DescuentoTarjeta + n_Descuento) * n_Monto);
                    n_Total = (n_DescuentoTarjeta + n_Descuento) * 100;

                    Console.WriteLine("El descuento total aplicado es del " + n_Total + "%");
                    Console.WriteLine("El monto final es de Q" + n_MontoF);
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.ReadKey();
        }
    }
}
