using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaPizzaria
{
    class pedido
    {
        public double pizza, bebida;
         public pedido ()
        {
        }
        
        public double getValor (double valorPizza, double valorBebida )
        {
            double valorFinal = valorBebida + valorPizza;
            return valorFinal;
        }

    }
}
