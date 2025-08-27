using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static CRM_AGRO.Form1;

namespace CRM_AGRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class ConexaoBD
        {
            public static string conexao = "Server=127.0.0.1;Port=3306;Database=agro;Uid=root;Pwd=;";
        }
        public class cliente
        {
           public string nome_empresa { get; set; }
            public string categoria_cliente { get; set; }
            public string pessoa_contato { get; set; }
            public string forma_contato { get; set; }
            public string localizacao_cliente { get; set; }
            public string status_cliente { get; set; }

           // MessageBox.Show("Cliente adicionado com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            cliente novoCliente = new cliente
            {
                nome_empresa = txtNome_empresa.Text, //aaaaaa
                categoria_cliente = txtCatego_cliente.Text,
                pessoa_contato = txtPessoaCtt.Text,
                forma_contato = txtForma_contato.Text,
                localizacao_cliente = txtLocCliente.Text,
                status_cliente = comboBoxSTS.Text
            };

            using (MySqlConnection conn = new MySqlConnection(ConexaoBD.conexao))
            {
                conn.Open();

                string query = @"INSERT INTO clientes 
                                (nome_empresa, categoria_cliente, pessoa_ctt, forma_ctt, localizacao, status_cliente) 
                                 VALUES (@nome_empresa, @categoria_cliente, @pessoa_ctt, @forma_ctt, @localizacao, @status_cliente)";

                MySqlCommand cmdCliente = new MySqlCommand(query, conn);
                cmdCliente.Parameters.AddWithValue("@nome_empresa", txtNome_empresa.Text);
                cmdCliente.Parameters.AddWithValue("@categoria_cliente", txtCatego_cliente.Text);
                cmdCliente.Parameters.AddWithValue("@pessoa_ctt", txtPessoaCtt.Text);
                cmdCliente.Parameters.AddWithValue("@forma_ctt", txtForma_contato.Text);
                cmdCliente.Parameters.AddWithValue("@localizacao", txtLocCliente.Text);
                cmdCliente.Parameters.AddWithValue("@status_cliente", comboBoxSTS.Text);

                int clienteID = Convert.ToInt32(cmdCliente.ExecuteScalar());
                conn.Close();

                MessageBox.Show("Cliente cadastrado com sucesso!");
               
            }
            FormVendas tela2 = new FormVendas();

            tela2.Show();

            this.Hide();
        }
    }
}
