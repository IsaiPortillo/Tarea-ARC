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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void detectErrorsButton_Click(object sender, EventArgs e)
        {
            string inputData = inputTextBox.Text;

            if (ValidateInput(inputData))
            {
                int dataLength = inputData.Length;
                int parityBits = CalculateParityBitCount(dataLength);
                int totalBits = dataLength + parityBits;
                char[] encodedData = new char[totalBits];

                // Inicializa el arreglo de datos codificados con paridad
                for (int i = 0; i < totalBits; i++)
                {
                    encodedData[i] = '0';
                }

                int dataIndex = 0;
                int parityIndex = 0;

                // Llena los datos codificados con los datos de entrada
                for (int i = 0; i < totalBits; i++)
                {
                    if (!IsPowerOfTwo(i + 1))
                    {
                        encodedData[i] = inputData[dataIndex];
                        dataIndex++;
                    }
                }

                // Calcula los bits de paridad
                for (int i = 0; i < parityBits; i++)
                {
                    int parityBitIndex = (int)Math.Pow(2, i) - 1;
                    char parityBit = CalculateParityBit(encodedData, parityBitIndex, totalBits);
                    encodedData[parityBitIndex] = parityBit;
                }

                encodedTextBox.Text = new string(encodedData);

                // Simula un error en un bit aleatorio
                string corruptedData = SimulateError(encodedData);
                corruptedTextBox.Text = corruptedData;

                // Detecta y muestra la posición del error
                string errorPosition = DetectError(corruptedData);
                if (string.IsNullOrEmpty(errorPosition))
                {
                    resultLabel.Text = "No se detectaron errores.";
                }
                else
                {
                    resultLabel.Text = "Error detectado en la posición: " + errorPosition;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo 0s y 1s válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string AddHammingBits(string input)
        {
            int dataBits = input.Length;
            int parityBits = CalculateParityBitCount(dataBits);
            int totalBits = dataBits + parityBits;
            char[] encodedData = new char[totalBits];

            int dataIndex = 0;
            int parityIndex = 0;

            for (int i = 0; i < totalBits; i++)
            {
                // Posiciones de los bits de paridad (potencias de 2)
                if (IsPowerOfTwo(i + 1))
                {
                    encodedData[i] = '0'; // Inicialmente establece todos los bits de paridad en 0
                    parityIndex++;
                }
                else
                {
                    encodedData[i] = input[dataIndex];
                    dataIndex++;
                }
            }

            // Calcula los bits de paridad
            for (int i = 0; i < parityBits; i++)
            {
                int parityBitIndex = (int)Math.Pow(2, i) - 1; // Indices de bits de paridad (0, 1, 3, 7, ...)
                char parityBit = CalculateParityBit(encodedData, parityBitIndex, totalBits);
                encodedData[parityBitIndex] = parityBit;
            }

            return new string(encodedData);
        }

        private char CalculateParityBit(char[] data, int parityBitIndex, int totalBits)
        {
            char parityBit = '0';
            for (int i = parityBitIndex; i < totalBits; i++)
            {
                if (((i + 1) & (parityBitIndex + 1)) != 0)
                {
                    parityBit ^= data[i];
                }
            }
            return parityBit;
        }

        private string DetectError(string data)
        {
            int parityBits = (int)Math.Log(data.Length, 2);
            string errorPosition = "";

            for (int i = 0; i < parityBits; i++)
            {
                int parityBitIndex = (int)Math.Pow(2, i) - 1;
                char parityBit = CalculateParityBit(data.ToCharArray(), parityBitIndex, data.Length);

                if (parityBit != data[parityBitIndex])
                {
                    errorPosition = parityBitIndex.ToString();
                    break; // Se detiene en el primer error detectado
                }
            }

            return string.IsNullOrEmpty(errorPosition) ? "No se detectaron errores." : errorPosition;
        }

        private bool ValidateInput(string input)
        {
            return Regex.IsMatch(input, "^[01]+$");
        }

        private bool IsPowerOfTwo(int number)
        {
            return (number & (number - 1)) == 0;
        }

        private string SimulateError(char[] data)
        {
            Random random = new Random();
            int position = random.Next(0, data.Length);
            data[position] = (data[position] == '0') ? '1' : '0';

            return new string(data);
        }

        private int CalculateParityBitCount(int dataBits)
        {
            int parityBits = 0;
            while (Math.Pow(2, parityBits) < dataBits + parityBits + 1)
            {
                parityBits++;
            }
            return parityBits;
        }
    }
}
