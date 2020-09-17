namespace ProjectSO
{
    partial class ConfigMMU
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPaginasMMU = new System.Windows.Forms.ComboBox();
            this.txtAlgoritmoMMU = new System.Windows.Forms.ComboBox();
            this.btnconfigGuardarMMU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(84, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Algoritmo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(84, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "# Paginas:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtPaginasMMU
            // 
            this.txtPaginasMMU.FormattingEnabled = true;
            this.txtPaginasMMU.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.txtPaginasMMU.Location = new System.Drawing.Point(201, 109);
            this.txtPaginasMMU.Name = "txtPaginasMMU";
            this.txtPaginasMMU.Size = new System.Drawing.Size(121, 21);
            this.txtPaginasMMU.TabIndex = 28;
            // 
            // txtAlgoritmoMMU
            // 
            this.txtAlgoritmoMMU.FormattingEnabled = true;
            this.txtAlgoritmoMMU.Items.AddRange(new object[] {
            "Reemplazo de Paginas Optimo",
            "FIFO",
            "Algoritmo de Segunda Oportunidad",
            "Reloj",
            "LRU"});
            this.txtAlgoritmoMMU.Location = new System.Drawing.Point(201, 74);
            this.txtAlgoritmoMMU.Name = "txtAlgoritmoMMU";
            this.txtAlgoritmoMMU.Size = new System.Drawing.Size(121, 21);
            this.txtAlgoritmoMMU.TabIndex = 29;
            // 
            // btnconfigGuardarMMU
            // 
            this.btnconfigGuardarMMU.Location = new System.Drawing.Point(181, 168);
            this.btnconfigGuardarMMU.Name = "btnconfigGuardarMMU";
            this.btnconfigGuardarMMU.Size = new System.Drawing.Size(75, 23);
            this.btnconfigGuardarMMU.TabIndex = 30;
            this.btnconfigGuardarMMU.Text = "Guardar";
            this.btnconfigGuardarMMU.UseVisualStyleBackColor = true;
            this.btnconfigGuardarMMU.Click += new System.EventHandler(this.btnconfigGuardarMMU_Click);
            // 
            // ConfigMMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 245);
            this.Controls.Add(this.btnconfigGuardarMMU);
            this.Controls.Add(this.txtAlgoritmoMMU);
            this.Controls.Add(this.txtPaginasMMU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "ConfigMMU";
            this.Text = "ConfigMMU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtPaginasMMU;
        private System.Windows.Forms.ComboBox txtAlgoritmoMMU;
        private System.Windows.Forms.Button btnconfigGuardarMMU;
    }
}