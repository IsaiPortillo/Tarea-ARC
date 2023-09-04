using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_ARC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            abrirF<Form1>();
            //Cambiamos el color del button a dar click
            btnConversor.BackColor = Color.FromArgb(166, 166, 166);
        }

        #region Funcionalidad Barra de titulo
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Para cerrar nuestro form
            Application.Exit();
        }

        //Nos permite mover la ventana del formulario a traves de la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Indicamos que al dar click se minimice el formulario
            this.WindowState = FormWindowState.Minimized;
        }

        private void ContenedorForm_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region Adapatador de forms
        //Definimos un metodo que nos permita abrir formularios dentro de un panel
        public void abrirF<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscara en la coleccion el formulario si el formulario o instancia no existe
            formulario = ContenedorForm.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                //Creamos una nueva instancia
                formulario = new MiForm();
                //Indicamos que el formulario que se use sera secundario
                formulario.TopLevel = false;
                //Nos permetira que el formulario se acople al panel contenedor
                formulario.Dock = DockStyle.Fill;
                //Agregamos el formulario a la coleccion de controles del panel
                ContenedorForm.Controls.Add(formulario);
                //Especificamos la propiedad tag
                ContenedorForm.Tag = formulario;
                formulario.Show();//Se encarga de mostrar
                formulario.FormClosed += new FormClosedEventHandler(Close);

            }
            //Si el formulario o instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        #endregion

        //Metodo para regresar los buttons del menu a su color original al cerrar el form secundario
        private void Close(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Fomr1"] == null)
            {
                btnConversor.BackColor = Color.FromArgb(39, 52, 69);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCorreccion_Click(object sender, EventArgs e)
        {

        }
    }
    
}
