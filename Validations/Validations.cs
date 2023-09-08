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
        public void unsignedNumerValidation(object sender, KeyPressEventArgs e, Label messageError)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                messageError.Text = "Solo se permite el ingreso de numeros";
            }
            else
            {
                messageError.Text = "";
            }
        }
        public void floatNumerValidation(object sender, KeyPressEventArgs e, Label messageError)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                messageError.Text = "Solo se permite: numeros, signo negativo y punto";
            }
            else
            {
                messageError.Text = "";
            }
        }
    }
}
