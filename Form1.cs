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
using Tarea_ARC.Logic;

namespace Tarea_ARC
{
    public partial class Form1 : Form
    {
        private validar validator;//declaracion de objeto que contiene validaciones
        private conversiones conversion;//declaracion de objetos para realizar conversiones
        public Form1()
        {
            InitializeComponent();
            //inicializamos las opciones que se mostraran en el comboBox al cargar el formulario
            InitializeComboBox();
        }

        private void dataTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Opciones_EnteroS.Items.Clear();

            // Obténiendo la selección actual de el ComboBox principal
            string seleccion = dataTypeComboBox.SelectedItem.ToString();

            //Verificamos si la opccion seleccionada es elentero con signo
            if (seleccion == "Entero con signo")
            {
                //De ser asi hacemos visible un nuevo comboBox
                Opciones_EnteroS.Visible = true;
                //Agregamos las opciones
                Opciones_EnteroS.Items.Add("Representacion en Exceso 2");
                Opciones_EnteroS.Items.Add("Representacion por Bit mas significativo");
                Opciones_EnteroS.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                //Si no es entero con signo el combo sera invisible
                Opciones_EnteroS.Visible = false;
            }

        }

        //funcion que nos permitira mostrar una alerta
        public void Alerta()
        {
            //declaramos los botones que se mostraran en el MessageBox
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            //icono del MessageBox
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            //mensaje que se mostrara
            string message = "No se puede representar el numero ingresado porque se ha sobrepasado la capacidad del procesador\n--> 16 BITS";
            //titulo del MessageBox
            string caption = "Limite de capacidad";

            // Mostrar el cuadro de diálogo de mensaje
            MessageBox.Show(message, caption, buttons, icon);
            //reiniciamos los valores de los textBox donde estan los valores ingresados y mostrados
            valueTextBox.Text = "";
            binaryOutputLabel.Text = "";
            res.Text = "";
        }
        //funcion para cargar informacion al iniciar el form
        private void InitializeComboBox()
        {
            //elementos del ComboBox
            dataTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dataTypeComboBox.Items.AddRange(new string[] { "Entero sin signo", "Entero con signo", "Flotante", "Carácter", "Cadena de caracteres" });
            dataTypeComboBox.SelectedIndex = 0;
            //label que estara mostrando el error
            lblError.Text = "";
            //inicializacion de los objetos para validaciones y conversiones
            validator = new validar();
            conversion = new conversiones();
        }
        //mostrar el calculo
        private void convertButton_Click(object sender, EventArgs e)
        {
            //capturamos la opcion que se ha seleccionado
            int selectedIndex = dataTypeComboBox.SelectedIndex;
            //realizamos acciones de acuerdo a cada una de las opciones
            switch (selectedIndex)
            {
                case 0: // Entero sin signo
                    //manejo de excepciones
                    try
                    {
                        //si el numero ingresado no sobrepasa el limite hacemos el calculo
                        if(int.Parse(valueTextBox.Text) <= 32767)
                        {
                            //convertimos el numero a una expresion uint
                            uint unsignedIntValue = uint.Parse(valueTextBox.Text);
                            //convertimos a binario y al mismo tiempo el resultado se le asigna al textBox donde estara el resultado
                            binaryOutputLabel.Text = Convert.ToString(unsignedIntValue, 2).PadLeft(16, '0');
                            res.Text = valueTextBox.Text + " =";
                            valueTextBox.Clear();
                            errorProvider1.Clear();
                        }
                        else//si se sobrepasa el limite se muestra la alerta
                        {
                            Alerta();
                        }
                    }
                    catch//calquier excepcion producida mostramos un MessageBox para indicar que ha surgido un error
                    {
                        errorProvider1.SetError(convertButton, "Hay campos vacios");
                        MessageBox.Show("Ha ocurrido un error");
                        
                    }
                    break;

                case 1: // Entero con signo
                    try
                    {
                        if (Opciones_EnteroS.Text == "Representacion en Exceso 2")
                        {
                            //verificamos si el numero es menor al limite de datos permitidos
                            if (int.Parse(valueTextBox.Text) <= 32768)
                            {
                                //convetimos el numero negativo en una expresion short que nos permite manejar numeros negativos para poder ser 
                                //convertidos a binarios
                                short signedIntValue = short.Parse("-" + valueTextBox.Text);
                                //convertimos el numero a binario y asignamos ese valor al TextBox donde se muestra el resultado
                                binaryOutputLabel.Text = Convert.ToString(signedIntValue, 2).PadLeft(16, signedIntValue < 0 ? '1' : '0');
                                res.Text ="-"+ valueTextBox.Text + " =";
                                valueTextBox.Clear();
                                errorProvider1.Clear();
                            }
                            else { Alerta(); }//si se sobrepasa el limite se mostrara la alerta
                        }
                        else if(Opciones_EnteroS.Text == "Representacion por Bit mas significativo")
                        {
                            if (int.Parse(valueTextBox.Text) <= 32767)
                            {
                                //capturamos el valor que se ha ingresado
                                int bitSignificativo = int.Parse(valueTextBox.Text);
                                //en esta variable se guarda la conversion de la parte entera que retorna el metodo EnteroABinario de la clase Validations
                                string conversionS = conversion.EnteroABinario(bitSignificativo);
                                //declaramos una variable que contendra la respuesta que deseamos mostrar, uniendo las variables anteriores
                                string valueSBinary = "1" + conversionS;
                                res.Text ="-"+ valueTextBox.Text + " =";
                                binaryOutputLabel.Text = valueSBinary;
                            }
                            else { Alerta(); }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar una alternativa de representacion");
                        }
                    }
                    catch//Manejo por si ocurre algun problema
                    {
                        errorProvider1.SetError(convertButton, "Hay campos vacios");
                        MessageBox.Show("Ha ocurrido un error");
                    }
                    
                    break;

                case 2: // Flotante (simplificado)
                    //manejo de cualquier error producido en la ejecucion
                    try
                    {
                        //capturamos el valor que se ha ingresado
                        double doubleValue = double.Parse(valueTextBox.Text);
                        //primero convertimos el numero a un entero y lo asignamos a una variable;
                        int parteEntera = (int)doubleValue;
                        //declaracion de otra variable que contrenda la parte decimal
                        double parteDecimal = doubleValue - parteEntera;
                        //en esta variable se guarda la conversion de la parte entera que retorna el metodo EnteroABinario de la clase Validations
                        string binarioParteEntera = conversion.EnteroABinario(Math.Abs(parteEntera));
                        //se almacena la conversion de la parte decimal que proviene del metodo DecimalABinario de la clase Validations
                        string binarioParteDecimal = conversion.DecimalABinario(Math.Abs(parteDecimal), 1);
                        //declaramos una variable que contendra la respuesta que deseamos mostrar, uniendo las variables anteriores
                        string valueBinary = conversion.RetornoBinario(binarioParteEntera, binarioParteDecimal, parteEntera);
                        if (valueBinary.Length <= 16)//verificamos que no se sobrepase el limite de bits de la maquina
                        {
                            binaryOutputLabel.Text = valueBinary;//mostramos el valor
                            res.Text = valueTextBox.Text + " =";
                            valueTextBox.Clear();
                            errorProvider1.Clear();
                        }
                        else//si se sobrepasa se muestra una alerta
                        {
                            Alerta();
                        }
                    }
                    catch//manejo de excepciones
                    {
                        errorProvider1.SetError(convertButton, "Hay campos vacios");
                        MessageBox.Show("Verifique que los campos no esten vacios\nVerifique que no se repita mas de un punto decimal\nCorrija la entrada proporcionada");
                    }
                    break;

                case 3: // Carácter
                    if (valueTextBox.Text == "")
                    {
                        errorProvider1.SetError(convertButton, "Hay campos vacios");
                        MessageBox.Show("Debe ingresar un dato");
                    }
                    else
                    {
                        //capturamos el caracter ingresado
                        char charValue = valueTextBox.Text[0];
                        //lo convertimos a binario y asignamos ese valor al campo de respuesta
                        binaryOutputLabel.Text = Convert.ToString(charValue, 2).PadLeft(16, '0');
                        res.Text = valueTextBox.Text + " =";
                        valueTextBox.Clear();
                        errorProvider1.Clear();
                    }
                    break;

                case 4: // Cadena de caracteres
                    //manejo de excepciones
                    try
                    {
                        if (valueTextBox.Text == "")
                        {
                            errorProvider1.SetError(convertButton, "Hay campos vacios");
                            MessageBox.Show("Debe ingresar un dato");
                        }
                        else
                        {
                            string stringValue = valueTextBox.Text;//capturamos la cadena de caracteres
                            string binaryString = "";//declaracion de variable para almacenar la expresion binaria
                            foreach (char c in stringValue)//recorremos la expresion ingresada para convertir letra por letra
                            {
                                binaryString += Convert.ToString(c, 2).PadLeft(8, '0');//a la variable de respuesta agregamos la expresion binaria de la conversion
                            }
                            res.Text = valueTextBox.Text + " =";
                            valueTextBox.Clear();
                            errorProvider1.Clear();
                            if (binaryString.Length > 16)//si la expresion sobrepasa el limite para representar, entonces se muestra la alerta
                            {
                                Alerta();
                            }
                            else//si no hay sobrepaso del limite, se manda la respuesta al TextBox
                            {
                                binaryOutputLabel.Text = binaryString;
                            }
                        }
                    }
                    catch//manejo de excepciones
                    {
                        
                        MessageBox.Show("Ha ocurrido un error");
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)//evento para manejar las teclas que se presionan
        {
            if(dataTypeComboBox.SelectedIndex == 0 || dataTypeComboBox.SelectedIndex == 1) {//para validar el ingreso de informacion
                //cuando son numeros con signo o sin signo
                valueTextBox.MaxLength = 32767;//declaracion del maximo de caracteres que se pueden ingresar
                validator.unsignedNumerValidation(sender, e, lblError);//se llama un metodo con el objeto validator proveniente de la carpeta validaciones
            }
            else if(dataTypeComboBox.SelectedIndex == 2)//validaciones para flotante
            {
                valueTextBox.MaxLength = 32767;//declaracion de la capacidad permitida en el textBox de ingreso
                validator.floatNumerValidation(sender, e, lblError);//metodo para validar el ingreso de informacion
            }
            else if(dataTypeComboBox.SelectedIndex == 3)//validacion para char
            {
                valueTextBox.MaxLength = 1;//el maximo de caracteres que se pueden asignar es 1
                if(valueTextBox.Text.Length >= 0)//si se sobrepasa mas de un caracter, se muestra un mensaje
                {
                    lblError.Text = "Solo se permite un caracter";
                }
                else
                {
                    lblError.Text = "";
                }
                validator.charValidation(sender, e, lblError);//validaciones para char
            }
            else if(dataTypeComboBox.SelectedIndex == 4)
            {
                lblError.Text = "";
            }
        }
    }
}
