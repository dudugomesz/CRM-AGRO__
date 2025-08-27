namespace CRM_AGRO
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnClientes = new Button();
            btnVendas = new Button();
            btnLogistica = new Button();
            btnRelatorios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 47);
            label1.Name = "label1";
            label1.Size = new Size(232, 45);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 138);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(310, 118);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(138, 64);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Cadastrar Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVendas
            // 
            btnVendas.Location = new Point(310, 199);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(138, 63);
            btnVendas.TabIndex = 3;
            btnVendas.Text = "Cadastrar Venda";
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnLogistica
            // 
            btnLogistica.Location = new Point(310, 281);
            btnLogistica.Name = "btnLogistica";
            btnLogistica.Size = new Size(138, 61);
            btnLogistica.TabIndex = 4;
            btnLogistica.Text = "Cadastrar Frete";
            btnLogistica.UseVisualStyleBackColor = true;
            btnLogistica.Click += btnLogistica_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.Location = new Point(310, 366);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(138, 72);
            btnRelatorios.TabIndex = 5;
            btnRelatorios.Text = "Imprimir Relatorios";
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRelatorios);
            Controls.Add(btnLogistica);
            Controls.Add(btnVendas);
            Controls.Add(btnClientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnClientes;
        private Button btnVendas;
        private Button btnLogistica;
        private Button btnRelatorios;
    }
}