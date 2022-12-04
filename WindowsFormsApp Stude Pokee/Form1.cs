using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using Enlace;

namespace WindowsFormsApp_Stude_Pokee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo para ocultar y aparecer el mensaje de "Usuario"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        /// <summary>
        /// Efecto de ocultar datos en la contraseña y para ocultar y aparecer texto de "Contraseña"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true; //Activar caracteres ocultos
            }

        }
        
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.UseSystemPasswordChar = false;  //Desactivar caracteres olcultos 
            }
        }

        /// <summary>
        /// Metodo para el boton de Cerrar la aplicacion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Metodo para el boton de Minimizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Metodo para Utilizar la clase Enlace2 
        /// </summary>
        public void enlace2()
        {
            Class1 class1 = new Class1();
            string Usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            class1.logins(Usuario, contraseña);
        }
        /// <summary>
        /// Metodo del funcionamiento del boton Ingresar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlogin_Click(object sender, EventArgs e)
        {
            enlace2();
        }
    }
}
