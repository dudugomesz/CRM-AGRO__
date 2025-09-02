namespace CRM_AGRO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtPessoaCtt = new TextBox();
            label3 = new Label();
            txtLocCliente = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxSTS = new ComboBox();
            txtNome_empresa = new TextBox();
            txtForma_contato = new TextBox();
            txtCatego_cliente = new TextBox();
            label7 = new Label();
            button_salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(243, 115);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome da empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(477, 115);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 1;
            label2.Text = "Pessoa de contato";
            // 
            // txtPessoaCtt
            // 
            txtPessoaCtt.Location = new Point(477, 153);
            txtPessoaCtt.Name = "txtPessoaCtt";
            txtPessoaCtt.Size = new Size(182, 31);
            txtPessoaCtt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(243, 220);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 4;
            label3.Text = "Forma de contato";
            // 
            // txtLocCliente
            // 
            txtLocCliente.Location = new Point(477, 258);
            txtLocCliente.Name = "txtLocCliente";
            txtLocCliente.Size = new Size(182, 31);
            txtLocCliente.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(477, 220);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 6;
            label4.Text = "Localização Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(243, 320);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 8;
            label5.Text = "Categoria do cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(477, 320);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 10;
            label6.Text = "Status";
            // 
            // comboBoxSTS
            // 
            comboBoxSTS.FormattingEnabled = true;
            comboBoxSTS.Location = new Point(477, 356);
            comboBoxSTS.Name = "comboBoxSTS";
            comboBoxSTS.Size = new Size(182, 33);
            comboBoxSTS.TabIndex = 11;
            // 
            // txtNome_empresa
            // 
            txtNome_empresa.Location = new Point(243, 153);
            txtNome_empresa.Name = "txtNome_empresa";
            txtNome_empresa.Size = new Size(182, 31);
            txtNome_empresa.TabIndex = 12;
            // 
            // txtForma_contato
            // 
            txtForma_contato.Location = new Point(243, 258);
            txtForma_contato.Name = "txtForma_contato";
            txtForma_contato.Size = new Size(182, 31);
            txtForma_contato.TabIndex = 13;
            // 
            // txtCatego_cliente
            // 
            txtCatego_cliente.Location = new Point(243, 358);
            txtCatego_cliente.Name = "txtCatego_cliente";
            txtCatego_cliente.Size = new Size(182, 31);
            txtCatego_cliente.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(335, 30);
            label7.Name = "label7";
            label7.Size = new Size(265, 45);
            label7.TabIndex = 15;
            label7.Text = "Cadastro Cliente";
            // 
            // button_salvar
            // 
            button_salvar.ForeColor = Color.Black;
            button_salvar.Location = new Point(394, 412);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(112, 44);
            button_salvar.TabIndex = 16;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += button_salvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 468);
            Controls.Add(button_salvar);
            Controls.Add(label7);
            Controls.Add(txtCatego_cliente);
            Controls.Add(txtForma_contato);
            Controls.Add(txtNome_empresa);
            Controls.Add(comboBoxSTS);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLocCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPessoaCtt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPessoaCtt;
        private Label label3;
        private TextBox txtLocCliente;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxSTS;
        private TextBox txtNome_empresa;
        private TextBox txtForma_contato;
        private TextBox txtCatego_cliente;
        private Label label7;
        private Button button_salvar;
    }
}
