using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_desarrolado5_10266464
{
    public class Componente : Venta
    {
        public static int n;
        public Componente()
        {
            n++;
        }

        public int getN()
        {
            return n;
        }

        //Metodos de la clase comtado
        public double calculaDescuento(double subtotal)
        {
            if (subtotal < 1000)
                return 2.0 / 100 * subtotal;
            else if (subtotal >= 100 && subtotal <= 3000)
                return 5.0 / 100 * subtotal;
            return 12.0 / 100 * subtotal;
        }
        public double calculaNeto(double subtotal, double descuento)
        {
            return subtotal - descuento;
        }
    }
}
