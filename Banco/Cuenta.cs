using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Cuenta
    {
        public  List<Movimiento> movimientos { get; set; }

        
        public static decimal Saldo { get; set; }
        public abstract string Consignar(decimal valor);

        public abstract string Retirar(decimal valor);

        public Cuenta(decimal saldo)
        {
           
            Saldo = saldo;
            movimientos = new List<Movimiento>();
        }


        public string ConsultarSaldo()
        {
            return $"Su saldo actual es {Saldo}";

        }
        public void AgregarMovimiento(decimal valor, string tipo)
        {
            Movimiento movimiento = new Movimiento();
            movimiento.fecha = DateTime.Now;
            movimiento.Valor = valor;
            movimiento.Saldo = Saldo;
            movimiento.Tipo = tipo;
            movimientos.Add(movimiento);
        }


       public void ConsultarMovimiento()
        {
            foreach (var item in movimientos)
            {
                Console.WriteLine($"Usted {item.Tipo} el {item.fecha} una cantidad de {item.Valor}");
            }
        }


    }
}
