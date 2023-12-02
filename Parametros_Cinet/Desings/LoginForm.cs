using QuerysApp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parametros_Cinet.Desings
{
    public partial class LoginForm : Form
    {
        ConexionDB conexionDB = new ConexionDB();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            traerBases();
        }

        private void traerBases()
        {
            ConexionDB.usuarioBase = textBoxUser.Text;
            ConexionDB.connectionPass = textBoxPass.Text;
            ConexionDB.direccionIP = textBoxIp.Text;
            ConexionDB.puertoSql = textBoxPort.Text;

            conexionDB.CargarNombresBasesDeDatos(comboBoxDataBase);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
