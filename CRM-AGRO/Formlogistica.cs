using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM_AGRO
{
    public partial class Formlogistica : Form
    {
        public Formlogistica()
        {
            InitializeComponent();
        }
        public static class ConexaoBD
        {
            public static string conexao = "Server=127.0.0.1;Port=3306;Database=agro;Uid=root;Pwd=;";
        }
            private void Frete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConexaoBD.conexao))
            {
                conn.Open();

                string query = @"INSERT INTO logistica (transportadora, frete, destino) 
                                 VALUES (@transp, @frete, @destino)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@transp", txtTransportadora.Text);
                cmd.Parameters.AddWithValue("@frete", txtFrete.Text);
                cmd.Parameters.AddWithValue("@destino", txtDestino.Text);

                cmd.ExecuteNonQuery();
                long idLogistica = cmd.LastInsertedId;
                conn.Close();

                MessageBox.Show("Registro de logística salvo com sucesso!");

                FormRelatorio telaRelatorio = new FormRelatorio();
                telaRelatorio.Show();
            }
        }
    }
}
