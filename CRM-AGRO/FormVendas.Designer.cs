namespace CRM_AGRO
{
    partial class FormVendas
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
            txtSafra = new TextBox();
            label3 = new Label();
            txtgrao = new TextBox();
            label4 = new Label();
            txtQuantidade = new TextBox();
            label5 = new Label();
            txtValor = new TextBox();
            vender = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 30);
            label1.Name = "label1";
            label1.Size = new Size(265, 45);
            label1.TabIndex = 0;
            label1.Text = "Fazer Uma Venda";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 118);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 1;
            label2.Text = "Safra";
            // 
            // txtSafra
            // 
            txtSafra.Location = new Point(236, 148);
            txtSafra.Name = "txtSafra";
            txtSafra.Size = new Size(150, 31);
            txtSafra.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 207);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 3;
            label3.Tag = "";
            label3.Text = "Grão";
            // 
            // txtgrao
            // 
            txtgrao.Location = new Point(230, 235);
            txtgrao.Name = "txtgrao";
            txtgrao.Size = new Size(150, 31);
            txtgrao.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 279);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 5;
            label4.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(230, 307);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(150, 31);
            txtQuantidade.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 351);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 7;
            label5.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(230, 379);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 31);
            txtValor.TabIndex = 8;
            // 
            // vender
            // 
            vender.Location = new Point(531, 222);
            vender.Name = "vender";
            vender.Size = new Size(149, 56);
            vender.TabIndex = 9;
            vender.Text = "Vender";
            vender.UseVisualStyleBackColor = true;
            vender.Click += vender_Click;
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vender);
            Controls.Add(txtValor);
            Controls.Add(label5);
            Controls.Add(txtQuantidade);
            Controls.Add(label4);
            Controls.Add(txtgrao);
            Controls.Add(label3);
            Controls.Add(txtSafra);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormVendas";
            Text = "FormVendas";
            Load += FormVendas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSafra;
        private Label label3;
        private TextBox txtgrao;
        private Label label4;
        private TextBox txtQuantidade;
        private Label label5;
        private TextBox txtValor;
        private Button vender;
    }
}