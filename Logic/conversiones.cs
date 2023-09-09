using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_ARC.Logic
{
    public class conversiones
    {
        // Función para convertir la parte entera a binario
        public string EnteroABinario(int entero)
        {
            //si el entero ingreado es cero retornamos cero inmediatamente
            if (entero == 0)
                return "0";
            string binario="";//declaracion de variable que contendra la expresion binaria
            while (entero > 0)//bucle para realizar las divisiones mientras el numero entero sea mayor a 0
            {
                binario = (entero % 2) + binario;//verificamos cual bit corresponde agregar
                entero /= 2;//capturamos la parte entera de la division
            }
            return binario;//se retorna la informacion
        }

        // Función para convertir la parte decimal a binario
        public string DecimalABinario(double decimalPart, int precision)
        {
            string binario = "";//declaracion de variable para almacenar la respuesta
            for (int i = 0; i < precision; i++)//bucle para calcular el numero de bits segun la precision ingresada
            {
                decimalPart *= 2;//multiplicamos la parte decimal por 2
                binario += ((int)decimalPart).ToString();//la agregamos a la variable de respuesta, convertida a entero
                decimalPart -= (int)decimalPart;//restamos la parte entera a la respuesta encontrada
            }
            return binario;//retornamos la variable que contiene la parte decimal
        }
        public string RetornoBinario(string parteEntera, string parteDecimal, int signo)//funcion para unir parte decimal y entera del numero flotante ingresado
        {
            //si el numero ingresado es mayor a 0
            //suponemos que es signo positivo
            if(signo >0)
            {
                //agregamos el 0 para indicar el bit mas significativo en positivo, agregamos la parte entera, luego el punto decimal y por ultimo la expresion binaria del decimal
                return  "0"+parteEntera +"."+ parteDecimal;
            }
            else//si el numero es mejor a 0 indica que es negativo
            {
                //la misma logica anterioir pero se le asigna el 1 de primro como bit mas significativo para indicar la negativadad
                return "1"+parteEntera+"."+ parteDecimal;
            }
        }
    }
}
