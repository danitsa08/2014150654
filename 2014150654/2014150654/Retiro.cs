using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150654
{
    public class Retiro
    {
        public int Efectivo {get ; private set;}
        public int NumTicket {get ; private set;}
        public ATM Atm { get; private set; }
         public Retiro()
         {

         }
        public Retiro (ATM atm)
        {
            Atm=atm;
        }
        public Retiro (int NumTicket)
        {
            NumTicket = NumTicket;
        }
         
        public void CalcularRetiro()
        {
         //   NumTicket = Atm; 
        }
        }
    }
