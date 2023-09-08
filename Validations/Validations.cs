using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_ARC.Validations
{
    public class validar
    {
        //metodo para validar el ingreso de solamente numeros
        public void unsignedNumerValidation(object sender, KeyPressEventArgs e, Label messageError)
        {
            //si la tecla presionada no es un numero y no es la tecla de borrar o retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                //desabilitamos la escritura y mostramos mensaje de error
                e.Handled = true;
                messageError.Text = "Solo se permite el ingreso de numeros";
            }
            else//si todo esta bien eliminamos el mensaje de error
            {
                messageError.Text = "";
            }
        }
        //metodo para validar el ingreso de numeros flotantes
        public void floatNumerValidation(object sender, KeyPressEventArgs e, Label messageError)
        {
            //solo se permite el ingreso de numeros, el punto y el signo negativo
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                //si se presiona una tecla diferente a las permitidas se muestra un error
                e.Handled = true;
                messageError.Text = "Solo se permite: numeros, signo negativo y punto";
            }
            else//si todo esta bien eliminamos el mensaje de error
            {
                messageError.Text = "";
            }
        }
        //metodo para validar el ingreso de char
        public void charValidation(object sender, KeyPressEventArgs e, Label messageError)
        {
            //si se presiona la tecla de borrar, se borra lo que contenga el label donde se muestra el error
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
                messageError.Text = "";
            }
        }

    }
}
