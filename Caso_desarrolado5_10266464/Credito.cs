using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Caso_desarrolado5_10266464
{
    public class Credito : Venta
    {
        public static int x;
        public Credito()
        {
            x++;
        }
        public int getX()
        {
            return x;
        }
        //Atributos de la clase crdito
        public int letras { get; set }

        //Metodos de la clase credito
        public double calculoMontoInteres()
        {
            switch (letras)
            {
                case 3: return 5.9 / 100 * calculaSubtotal();
                case 6: return 10.0 / 100 * calculaSubtotal();
                case 9: return 15.0 / 100 * calculaSubtotal();
                case 12: return 25.0 / 100 * calculaSubtotal();
            }
            return 0;

        }
         public double calculaMontoMensual()
        {
            return (calculaSubtotal() + calculoMontoInteres()) / letras;
        }
    }
}
