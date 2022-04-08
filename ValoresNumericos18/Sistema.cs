using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos18
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            decimal numeroUno;
 
            Validador.Bienvenida();

            numeroUno = Validador.PedirNumeroDecimal("\n Ingrese un valor numérico.");

            Console.Clear();
            
            
            decimal numeroFinal = decimal.Round(numeroUno, 2);

            Console.Clear();
            Console.WriteLine(" \n Usted Ingreso el numero: *" + numeroUno + "*. \n El número ingresado a 2 decimales es:" +
                               + numeroFinal );
            
            Console.WriteLine(" \n Si el resultado no fue el esperado es porque ignoró la recomendación e ingreso" +
                              " un punto en vez de una coma");


            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
