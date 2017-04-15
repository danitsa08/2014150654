using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150654
{
    public class BaseDatos
    {
        public Cuenta _cuenta;

        public List<Cuenta> _cuenta1;


        public BaseDatos ()
        {
            _cuenta = new Cuenta();
            
            _cuenta1 = new List<Cuenta>();
        }


        public void llenarDatos() {

          //  numCuenta = 123;

            Console.WriteLine("inicio de la  base de datos de las cuentas");

            try
            {

                _cuenta.numCuenta = 234;
                _cuenta.pin = 1234;
                _cuenta.saldoDisponible = 1234;
                _cuenta.saldoTotal = 1234;

                _cuenta1.Add(_cuenta);

                _cuenta.numCuenta = 2345;
                _cuenta.pin = 12345;
                _cuenta.saldoDisponible = 12345;
                _cuenta.saldoTotal = 12345;

                _cuenta1.Add(_cuenta);


                Console.WriteLine("se lleno la base de datos de las cuentas");

            }
            catch (Exception ex)
            {
                // Code to handle the exception goes here.
                // Only catch exceptions that you know how to handle.
                // Never catch base class System.Exception without
                // rethrowing it at the end of the catch block.
            }

        }



        public bool AutenticarUsuario (int numCuenta ,int  pin)
        {

            
            if (_cuenta1 == null)
            {
                Console.WriteLine("Entroo");
        

                return false;
            }
            else
            {

               

                for (int i = 0; i < _cuenta1.Count; i++)
                {

                    if (numCuenta == _cuenta1[i].numCuenta && pin == _cuenta1[i].pin)
                    {

                        Console.WriteLine("login Correcto");
        

                        return true;
                    }
                    



                }

                return false;

            }


        }
        
        public double ObtenerSaldoDisponible (int numCuenta)
        {

            int variabletmp=0;

                for (int k = 0; k < _cuenta1.Count; k++)
                {
                    if (numCuenta == _cuenta1[k].numCuenta)
                    {

                        variabletmp = k;

                        Console.WriteLine("tu saldo disponible es : " + variabletmp);
                    }
          
                }



                Console.WriteLine("tu saldo disponible es :" + _cuenta1[variabletmp].saldoDisponible);
        
          
         
                



                
                    return _cuenta1[variabletmp].saldoDisponible;
                
        
            }

        
        public double ObtenerSaldoTotal (int numCuenta)
        {


   

    
        int variabletmp=0;

            for (int j = 0; j < _cuenta1.Count; j++)
            {
                if(numCuenta == _cuenta1[j].numCuenta){

                    variabletmp = j;
                }

            }




            Console.WriteLine("tu saldo disponible es :" + _cuenta1[variabletmp].saldoTotal);

            return _cuenta1[variabletmp].saldoTotal;
               
        }
      
     public void Debitar(int numcuenta , double monto)
     {




     }
   
        public void acreditar(int numCuenta , double monto)
        {

        
        }
    }
}
