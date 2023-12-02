using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parametros_Cinet.Desings;
using Parametros_Cinet.Models;
using Serilog;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Parametros_Cinet.Class
{
    internal class QuerysParametros
    {
        public void HabilitarParametro(string para_codigo, string para_descripcion,string valorParametro)
        {
            ConexionDB conexionDB = new ConexionDB();

            string cadenaConexion = conexionDB.StringConexion();

            string queryUpdateS = $"IF NOT EXISTS (SELECT * FROM PARAMETROS WHERE PARA_CODIGO = '{para_codigo}') INSERT INTO PARAMETROS VALUES ('{para_codigo}','{para_descripcion}','S',NULL,NULL) ELSE UPDATE PARAMETROS SET PARA_VALOR = 'S' WHERE PARA_CODIGO = '{para_codigo}'";
            string queryUpdateN = $"UPDATE PARAMETROS SET PARA_VALOR = 'N' WHERE PARA_CODIGO = '{para_codigo}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    CinetPdvForm cinetPdvForm = new CinetPdvForm();

                    if (valorParametro != "S")
                    {
                        using (SqlCommand command = new SqlCommand(queryUpdateS, connection)) { 
                            command.ExecuteNonQuery(); 
                            cinetPdvForm.SERV_DVY.Text = valorParametro;
                        }

                        Log.Information("SQL Query: \n" + queryUpdateS);
                    }
                    else if (valorParametro == "S")
                    {
                        using (SqlCommand command = new SqlCommand(queryUpdateN, connection)) { 
                            command.ExecuteNonQuery();
                            cinetPdvForm.SERV_DVY.Text = valorParametro;
                        }

                        Log.Information("SQL Query: \n" + queryUpdateN);
                    }
                    MessageBox.Show($"Se actualizó el parametro {para_codigo}");
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                // Registra el error en el log
                Log.Error("ERROR QUERY: n" + ex.ToString());
                // Muestra un mensaje de error al usuario
                MessageBox.Show("No se realizó el cambio. \nVer Error: " + ex.Message);
            }
        }
    }
}
