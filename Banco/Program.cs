using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cuenta cuenta = new Ahorro(100000);
            Console.WriteLine(cuenta.Consignar(20000));
            /*foreach (var item in cuenta.movimientos)
            {
                Console.WriteLine($"Usted {item.Tipo} el {item.fecha} una cantidad de {item.Valor}");
            }*/

            cuenta.ConsultarMovimiento();
            
            

            Console.WriteLine(cuenta.Retirar(20000000000));

            Console.WriteLine(cuenta.Retirar(20000));
            Console.WriteLine(cuenta.ConsultarSaldo());
            

            Console.ReadKey();

            Cuenta cuentaCorriente = new Corriente(1000000);
            Console.WriteLine(cuentaCorriente.Retirar(200000));
            Console.WriteLine(cuentaCorriente.Consignar(300000));
            Console.WriteLine(cuentaCorriente.Consignar(100000));
            Console.WriteLine(cuentaCorriente.ConsultarSaldo());
            Console.ReadKey();

        }
    }
}
