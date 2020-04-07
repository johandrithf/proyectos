using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Ahorro : Cuenta
    {

        public Ahorro(decimal saldo) : base(Saldo)
        {
            Saldo = saldo;
        }


        public override string Consignar(decimal valor)
        {

             

            if (valor > 0)
            {
                Saldo += valor;
                AgregarMovimiento(valor, "Consignó");
                return $"Se Consignò {valor} su nuevo saldo es {Saldo}";

            }
           
                return $"No es posible consignar valores negativos o un valor, su saldo es {Saldo}";
            
            
        }

        public override string Retirar(decimal valor)
        {
            if (valor > 0 && valor<= Saldo)
            {
                Saldo -= valor;
                AgregarMovimiento(valor, "Retiró");
                return $"Se retirò {valor} su nuevo saldo es {Saldo}";

            }

            return $"No es posible retirar màs de lo que tiene disponible en su saldo, su saldo es {Saldo}";
        }
    }
}
