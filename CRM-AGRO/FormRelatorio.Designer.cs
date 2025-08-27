namespace CRM_AGRO
{
    partial class FormRelatorio
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
            dataGridView1 = new DataGridView();
            button_gerar_relatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(735, 335);
            dataGridView1.TabIndex = 0;
            // 
            // button_gerar_relatorio
            // 
            button_gerar_relatorio.Location = new Point(325, 424);
            button_gerar_relatorio.Name = "button_gerar_relatorio";
            button_gerar_relatorio.Size = new Size(178, 34);
            button_gerar_relatorio.TabIndex = 1;
            button_gerar_relatorio.Text = "Gerar Relatório";
            button_gerar_relatorio.UseVisualStyleBackColor = true;
            button_gerar_relatorio.Click += button_gerar_relatorio_Click;
            // 
            // FormRelatorio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 503);
            Controls.Add(button_gerar_relatorio);
            Controls.Add(dataGridView1);
            Name = "FormRelatorio";
            Text = "FormRelatorio";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_gerar_relatorio;
    }
}