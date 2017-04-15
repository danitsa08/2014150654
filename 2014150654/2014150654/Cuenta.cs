using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150654
{
    public class Cuenta
    {
        public int numCuenta { get;  set; }
        public int pin { get;  set; }
       public double saldoTotal{ get;  set; }
        public double saldoDisponible { get;  set; }


        public Cuenta() { 
        
        }

        public Cuenta(int numCuenta, int pin , double saldoTotal , double SaldoDisponible)
        {
            this.numCuenta = numCuenta;
            this.pin = pin;
           
            this.saldoTotal = saldoTotal;
            this.saldoDisponible = SaldoDisponible;

        }

    }
}
