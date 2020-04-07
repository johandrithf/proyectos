using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    


    public class Corriente : Cuenta
    {
        public decimal Cupo { get; set; }

        public Corriente(decimal cupo): base (Saldo) 
        {

            Cupo = cupo;

        }
        public override string Consignar(decimal valor)
        {
            if (valor >= 0 && valor<=Saldo)
            {
                Saldo = Saldo - valor;
                Cupo += valor;
                AgregarMovimiento(valor, "Consignó");
                return $"Ahora le debe al banco{Saldo} y su cupo es de {Cupo}";
            }
            return $"No puede consignar valores negativos o mayores al cupo,  le debe al banco{Saldo}";
        }

        public override string Retirar(decimal valor)
        {
            if (valor >= 0 && valor<=Cupo)
            {
                Cupo = Cupo - valor;
                Saldo = Saldo + valor;
                AgregarMovimiento(valor, "Retiró");
                return $"Ahora su cupo es de {Cupo} y su deuda es de {Saldo}";
                
            }
            return $"No puede retirar valores negativos {valor}";
        }
    }
}
