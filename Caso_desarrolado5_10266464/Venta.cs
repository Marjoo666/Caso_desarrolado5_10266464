using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_desarrolado5_10266464
{
    public class Venta
    {
        //ATRIBUTOS
        public string cliente { get; set; }
        public string ruc { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }

        //METODOS DE LA CLASE
        public double aignaPrecio()
        {
            switch (producto)
            {
                case "Lavadora": return 1500;
                case "Refrigerador": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "BluRay": return 250;
            }
            return 0;
            }
        //Metodo que calcula el subtotal 
        public double calculaSubtotal()
        {
            return asignaPrecio() * cantidad;
        }
        }
    }

