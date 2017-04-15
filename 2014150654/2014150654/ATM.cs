using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150654
{
    public class ATM
    {
        private Teclado _teclado;
        private DispensadorEfectivo _dispensadorEfectivo;
        private Ranura_Deposito _ranuraDeposito;
        private Pantalla _pantalla;
        private Retiro _retiro;
        BaseDatos _baseDatos=null;

        public void comenzar() {

           // Console.Write("comenzar")

            _baseDatos = new BaseDatos();

            _baseDatos.llenarDatos();

             _baseDatos.AutenticarUsuario(234,1234);

            _baseDatos.ObtenerSaldoDisponible(234);
           
            _baseDatos.ObtenerSaldoTotal(234);
            Console.ReadKey();

        }


    }
}
