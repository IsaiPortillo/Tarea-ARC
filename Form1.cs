using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_ARC.Validations;

namespace Tarea_ARC
{
    public partial class Form1 : Form
    {
        private validar validator;
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void dataTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Alerta()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            string message = "No se puede representar el numero ingresado porque se ha sobrepasado la capacidad del procesador\n--> 16 BITS";
            string caption = "Limite de capacidad";

            // Mostrar el cuadro de diálogo de mensaje
            MessageBox.Show(message, caption, buttons, icon);
            valueTextBox.Text = "";
            binaryOutputLabel.Text = "";
        }

        private void InitializeComboBox()
        {
            dataTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dataTypeComboBox.Items.AddRange(new string[] { "Entero sin signo", "Entero con signo", "Flotante", "Carácter", "Cadena de caracteres" });
            dataTypeComboBox.SelectedIndex = 0;
            lblError.Text = "";
            validator = new validar();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataTypeComboBox.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: // Entero sin signo
                    try
                    {
                        if(int.Parse(valueTextBox.Text) <= 32767)
                        {
                            uint unsignedIntValue = uint.Parse(valueTextBox.Text);
                            binaryOutputLabel.Text = Convert.ToString(unsignedIntValue, 2).PadLeft(16, '0');
                        }
                        else
                        {
                            Alerta();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                    break;

                case 1: // Entero con signo
                    try
                    {
                        if(int.Parse(valueTextBox.Text) <= 32768)
                        {
                            short signedIntValue = short.Parse("-"+valueTextBox.Text);
                            binaryOutputLabel.Text = Convert.ToString(signedIntValue, 2).PadLeft(16, signedIntValue < 0 ? '1' : '0');
                        }
                        else { Alerta(); }
                    }
                    catch
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                    
                    break;

                case 2: // Flotante (simplificado)
                    float floatValue = float.Parse(valueTextBox.Text);
                    byte[] floatBytes = BitConverter.GetBytes(floatValue);
                    string binaryRepresentation = string.Join("", floatBytes);
                    binaryOutputLabel.Text = binaryRepresentation;
                    break;

                case 3: // Carácter
                    char charValue = valueTextBox.Text[0];
                    binaryOutputLabel.Text = Convert.ToString(charValue, 2).PadLeft(16, '0');
                    break;

                case 4: // Cadena de caracteres
                    string stringValue = valueTextBox.Text;
                    string binaryString = "";
                    foreach (char c in stringValue)
                    {
                        binaryString += Convert.ToString(c, 2).PadLeft(16, '0');
                    }
                    binaryOutputLabel.Text = binaryString;
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(dataTypeComboBox.SelectedIndex == 0 || dataTypeComboBox.SelectedIndex == 1) {
                validator.unsignedNumerValidation(sender, e, lblError);
            }
        }
    }
}
