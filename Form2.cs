using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_ARC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calculateParityButton_Click(object sender, EventArgs e)
        {
            string inputData = inputTextBox.Text;

            if (ValidateInput(inputData))
            {
                int countOnes = CountOnes(inputData);
                bool isEvenParity = (countOnes % 2 == 0);

                outputTextBox.Text = inputData + (isEvenParity ? "0" : "1");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo 0s y 1s válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simulateErrorButton_Click(object sender, EventArgs e)
        {
            string inputDataWithParity = outputTextBox.Text;

            if (ValidateInput(inputDataWithParity))
            {
                int countOnes = CountOnes(inputDataWithParity);
                bool isEvenParity = (countOnes % 2 == 0);

                if (isEvenParity)
                {
                    resultLabel.Text = "Verificación de paridad: Datos sin errores.";
                }
                else
                {
                    resultLabel.Text = "Verificación de paridad: Datos con errores.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo 0s y 1s válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CountOnes(string data)
        {
            int count = 0;
            foreach (char bit in data)
            {
                if (bit == '1')
                {
                    count++;
                }
            }
            return count;
        }

        private string SimulateError(string data)
        {
            Random random = new Random();
            int position = random.Next(0, data.Length);
            char[] dataArray = data.ToCharArray();

            // Cambia el bit en la posición aleatoria
            dataArray[position] = (dataArray[position] == '0') ? '1' : '0';

            return new string(dataArray);
        }

        private bool ValidateInput(string input)
        {
            return Regex.IsMatch(input, "^[01]+$");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Menu de opciones de los metodos
        private void btnMetodos_Click(object sender, EventArgs e)
        {
            //Al dar click se mostraran las opciones
            Opciones.Visible = true;

        }

        private void btnPariedad_Click(object sender, EventArgs e)
        {
            Opciones.Visible = false;
        }

        private void btnHamming_Click(object sender, EventArgs e)
        {
            Opciones.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
