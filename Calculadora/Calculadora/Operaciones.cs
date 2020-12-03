using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    class Operaciones
    {
        public double Operacion (double numero, double numero2, string signo)
        {
            double resultado=0;
            switch (signo)
            {
                case "N!":
                    resultado = 1;
                    for (int i = 1; i <= numero; i++)
                    {
                        resultado = resultado * i;
                    }                    
                    break;
                case "+":
                    resultado = numero + numero2;
                    break;
                case "-":
                    resultado = numero - numero2;
                    break;
                case "/":
                    resultado = numero / numero2;
                    break;
                case "*":
                    resultado = numero * numero2;
                    break;
                case "%":
                    resultado = (numero * numero2)/100;
                    break;               
                default:                   
                    break;
            }
            return resultado;
        }
    }
}
