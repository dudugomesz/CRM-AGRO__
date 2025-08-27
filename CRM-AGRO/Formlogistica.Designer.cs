namespace CRM_AGRO
{
    partial class Formlogistica
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
            txtTransportadora = new TextBox();
            label3 = new Label();
            txtFrete = new TextBox();
            label4 = new Label();
            txtDestino = new TextBox();
            Frete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 47);
            label1.Name = "label1";
            label1.Size = new Size(252, 45);
            label1.TabIndex = 0;
            label1.Text = "Frete e Logistica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 116);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 1;
            label2.Text = "Transportadora";
            // 
            // txtTransportadora
            // 
            txtTransportadora.Location = new Point(277, 144);
            txtTransportadora.Name = "txtTransportadora";
            txtTransportadora.Size = new Size(150, 31);
            txtTransportadora.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 204);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 3;
            label3.Text = "Frete";
            // 
            // txtFrete
            // 
            txtFrete.Location = new Point(277, 232);
            txtFrete.Name = "txtFrete";
            txtFrete.Size = new Size(150, 31);
            txtFrete.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 299);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 5;
            label4.Text = "Destino";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(277, 327);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(150, 31);
            txtDestino.TabIndex = 6;
            // 
            // Frete
            // 
            Frete.Location = new Point(581, 204);
            Frete.Name = "Frete";
            Frete.Size = new Size(127, 56);
            Frete.TabIndex = 7;
            Frete.Text = "Fretar";
            Frete.UseVisualStyleBackColor = true;
            Frete.Click += Frete_Click;
            // 
            // Formlogistica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Frete);
            Controls.Add(txtDestino);
            Controls.Add(label4);
            Controls.Add(txtFrete);
            Controls.Add(label3);
            Controls.Add(txtTransportadora);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formlogistica";
            Text = "Formlogistica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTransportadora;
        private Label label3;
        private TextBox txtFrete;
        private Label label4;
        private TextBox txtDestino;
        private Button Frete;
    }
}