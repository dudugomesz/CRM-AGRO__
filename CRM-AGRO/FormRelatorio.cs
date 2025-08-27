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
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }
        public static string conexao = "Server=127.0.0.1;Port=3306;Database=agro;Uid=root;Pwd=;";

        private void button_gerar_relatorio_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string query = @"
                    SELECT vendas.id_venda,
                           vendas.safra,
                           vendas.grao,
                           vendas.qtd,
                           vendas.valor,
                           clientes.nome_empresa,
                           clientes.categoria_cliente,
                           clientes.pessoa_ctt,
                           clientes.forma_ctt,
                           clientes.localizacao,
                           clientes.status_cliente,
                           logistica.transportadora,
                           logistica.frete,
                           logistica.destino
                    FROM vendas
                    JOIN clientes ON clientes.id = vendas.id_venda
                    JOIN logistica ON logistica.id_log = vendas.id_venda
                    ORDER BY vendas.id_venda DESC;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
        }
    }
}
