namespace ProjectSO
{
    partial class ConfigCPU
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
            this.btnGuardarCPUConfig = new System.Windows.Forms.Button();
            this.txtCPUConfig = new System.Windows.Forms.ComboBox();
            this.txtQuantumCPUConfig = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(12, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Metodo de Ejecucion: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(63, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quantum CPU:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardarCPUConfig
            // 
            this.btnGuardarCPUConfig.Location = new System.Drawing.Point(174, 132);
            this.btnGuardarCPUConfig.Name = "btnGuardarCPUConfig";
            this.btnGuardarCPUConfig.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCPUConfig.TabIndex = 26;
            this.btnGuardarCPUConfig.Text = "Guardar";
            this.btnGuardarCPUConfig.UseVisualStyleBackColor = true;
            this.btnGuardarCPUConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCPUConfig
            // 
            this.txtCPUConfig.FormattingEnabled = true;
            this.txtCPUConfig.Items.AddRange(new object[] {
            "Prioridad",
            "CPU",
            "Mixto"});
            this.txtCPUConfig.Location = new System.Drawing.Point(203, 51);
            this.txtCPUConfig.Name = "txtCPUConfig";
            this.txtCPUConfig.Size = new System.Drawing.Size(121, 21);
            this.txtCPUConfig.TabIndex = 27;
            this.txtCPUConfig.TextChanged += new System.EventHandler(this.txtCPUConfig_TextChanged);
            // 
            // txtQuantumCPUConfig
            // 
            this.txtQuantumCPUConfig.Location = new System.Drawing.Point(203, 86);
            this.txtQuantumCPUConfig.Name = "txtQuantumCPUConfig";
            this.txtQuantumCPUConfig.Size = new System.Drawing.Size(121, 20);
            this.txtQuantumCPUConfig.TabIndex = 28;
            // 
            // ConfigCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 241);
            this.Controls.Add(this.txtQuantumCPUConfig);
            this.Controls.Add(this.txtCPUConfig);
            this.Controls.Add(this.btnGuardarCPUConfig);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ConfigCPU";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConfigCPU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardarCPUConfig;
        private System.Windows.Forms.ComboBox txtCPUConfig;
        private System.Windows.Forms.TextBox txtQuantumCPUConfig;
    }
}