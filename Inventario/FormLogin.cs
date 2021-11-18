using DevExpress.Data.Utils;
using Inventario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventario
{
    public partial class FormLogin : Form
    {
        private Registro_TiendasEntities3 db = new Registro_TiendasEntities3();
        private Helpers help = new Helpers();
        private EmailValido mail = new EmailValido();
        public static int id_encargado;
        public static String nombre_encargado;
        public static int id_rol;


        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string error = "";
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                error = "Debe ingresar un email \n";
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                error += "Debe ingresar una contraseña";
            if (error != "")
                MessageBox.Show(error);
            else
            {
                //consulta para verficar existencia del usuario 
                Encargado encargado = db.Encargado.FirstOrDefault(en => en.correo.Equals(txtEmail.Text.Trim()) && en.contraseña.Equals(txtPassword.Text));
                if (encargado != null)
                {
                    //una vez logeado se asignan los valores a las variables statics
                    id_encargado = encargado.id_encargado;
                    nombre_encargado = encargado.nombre + " " + encargado.apellido;
                    id_rol = encargado.id_rol;

                    FormHome home = new FormHome();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email o Contraseña no son correctos");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != string.Empty)
            {
                if (!mail.emailValido(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("El email no tiene el formato corrcto (mail@mail.com)");
                }
            }
        }
    }
}
