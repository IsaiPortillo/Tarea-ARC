<<<<<<< HEAD
﻿using System;
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
            if (entero == 0)
                return "0";
            string binario="";
            while (entero > 0)
            {
                binario = (entero % 2) + binario;
                entero /= 2;
            }
            return binario;
        }

        // Función para convertir la parte decimal a binario
        public string DecimalABinario(double decimalPart, int precision)
        {
            string binario = "";
            for (int i = 0; i < precision; i++)
            {
                decimalPart *= 2;
                binario += ((int)decimalPart).ToString();
                decimalPart -= (int)decimalPart;
            }
            return binario;
        }
        public string RetornoBinario(string parteEntera, string parteDecimal, int signo)
        {
            if(signo >0)
            {
                return  "0"+parteEntera +"."+ parteDecimal;
            }
            else
            {
                return "1"+parteEntera+"."+ parteDecimal;
            }
        }
    }
}
=======
﻿using System;
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
            if (entero == 0)
                return "0";
            string binario="";
            while (entero > 0)
            {
                binario = (entero % 2) + binario;
                entero /= 2;
            }
            return binario;
        }

        // Función para convertir la parte decimal a binario
        public string DecimalABinario(double decimalPart, int precision)
        {
            string binario = "";
            for (int i = 0; i < precision; i++)
            {
                decimalPart *= 2;
                binario += ((int)decimalPart).ToString();
                decimalPart -= (int)decimalPart;
            }
            return binario;
        }
        public string RetornoBinario(string parteEntera, string parteDecimal, int signo)
        {
            if(signo >0)
            {
                return  "0"+parteEntera +"."+ parteDecimal;
            }
            else
            {
                return "1"+parteEntera+"."+ parteDecimal;
            }
        }
    }
}
>>>>>>> be6c091345e2b0eed020b7d344c2669326d0371c
