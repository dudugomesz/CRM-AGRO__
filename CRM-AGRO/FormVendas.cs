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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }
        public static class ConexaoBD
        {
            public static string conexao = "Server=localhost;Database=crm_agro;Uid=root;Pwd=;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormVendas_Load(object sender, EventArgs e)
        {

        }

        private void vender_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConexaoBD.conexao))
            {
                conn.Open();

                string query = @"INSERT INTO vendas (safra, tipo_grao, quantidade, valor) 
                                 VALUES (@safra, @grao, @qtd, @valor)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@safra", txtSafra.Text);
                cmd.Parameters.AddWithValue("@grao", txtgrao.Text);
                cmd.Parameters.AddWithValue("@qtd", txtQuantidade.Text);
                cmd.Parameters.AddWithValue("@valor", txtValor.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Venda registrada com sucesso!");
            }
        }
    }
}
