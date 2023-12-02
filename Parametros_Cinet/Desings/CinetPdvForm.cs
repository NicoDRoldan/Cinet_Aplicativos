using Parametros_Cinet.Class;
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
    public partial class CinetPdvForm : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        LoginForm loginForm = new LoginForm();
        QuerysParametros querysParametros = new QuerysParametros();

        public CinetPdvForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            SERV_DVY.Text = conexionDB.ObtenerValorDesdeBD("Select para_valor from parametros where para_codigo = 'SERV_DVY'");
        }

        private void SERV_DVY_Click(object sender, EventArgs e)
        {
            querysParametros.HabilitarParametro(SERV_DVY.Name, "POSEE SERV. DVY HERO", SERV_DVY.Text);
            SERV_DVY.Text = conexionDB.ObtenerValorDesdeBD("Select para_valor from parametros where para_codigo = 'SERV_DVY'");
        }

    }
}
