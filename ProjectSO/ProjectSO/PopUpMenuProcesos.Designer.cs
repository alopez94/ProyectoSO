namespace ProjectSO
{
    partial class PopUpMenuProcesos
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
            this.opcionesPopup = new System.Windows.Forms.ComboBox();
            this.btnProcesarPorMetodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opcionesPopup
            // 
            this.opcionesPopup.FormattingEnabled = true;
            this.opcionesPopup.Items.AddRange(new object[] {
            "Por Proceso",
            "Por CPU Time",
            "Por Prioridad",
            "Combinacion CPU Time/Prioridad"});
            this.opcionesPopup.Location = new System.Drawing.Point(51, 31);
            this.opcionesPopup.Name = "opcionesPopup";
            this.opcionesPopup.Size = new System.Drawing.Size(206, 21);
            this.opcionesPopup.TabIndex = 0;
            // 
            // btnProcesarPorMetodo
            // 
            this.btnProcesarPorMetodo.Location = new System.Drawing.Point(118, 71);
            this.btnProcesarPorMetodo.Name = "btnProcesarPorMetodo";
            this.btnProcesarPorMetodo.Size = new System.Drawing.Size(75, 23);
            this.btnProcesarPorMetodo.TabIndex = 1;
            this.btnProcesarPorMetodo.Text = "Aceptar";
            this.btnProcesarPorMetodo.UseVisualStyleBackColor = true;
            this.btnProcesarPorMetodo.Click += new System.EventHandler(this.btnProcesarPorMetodo_Click);
            // 
            // PopUpMenuProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 115);
            this.Controls.Add(this.btnProcesarPorMetodo);
            this.Controls.Add(this.opcionesPopup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUpMenuProcesos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccione Metodo de Procesamiento";
            this.Load += new System.EventHandler(this.PopUpMenuProcesos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox opcionesPopup;
        private System.Windows.Forms.Button btnProcesarPorMetodo;
    }
}