namespace ProjectSO
{
    partial class VentanaAProcesos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEjecutarProcesos = new System.Windows.Forms.Button();
            this.dgvListadoEjecucion = new System.Windows.Forms.DataGridView();
            this.dgvProcesosDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEjecucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesosDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Procesos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEjecutarProcesos
            // 
            this.btnEjecutarProcesos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEjecutarProcesos.ForeColor = System.Drawing.Color.White;
            this.btnEjecutarProcesos.Location = new System.Drawing.Point(61, 171);
            this.btnEjecutarProcesos.Name = "btnEjecutarProcesos";
            this.btnEjecutarProcesos.Size = new System.Drawing.Size(111, 31);
            this.btnEjecutarProcesos.TabIndex = 15;
            this.btnEjecutarProcesos.Text = "Ejecutar";
            this.btnEjecutarProcesos.UseVisualStyleBackColor = false;
            this.btnEjecutarProcesos.Click += new System.EventHandler(this.btnEjecutarProcesos_Click);
            // 
            // dgvListadoEjecucion
            // 
            this.dgvListadoEjecucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEjecucion.Location = new System.Drawing.Point(61, 217);
            this.dgvListadoEjecucion.Name = "dgvListadoEjecucion";
            this.dgvListadoEjecucion.Size = new System.Drawing.Size(499, 345);
            this.dgvListadoEjecucion.TabIndex = 26;
            this.dgvListadoEjecucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvProcesosDetalle
            // 
            this.dgvProcesosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesosDetalle.Location = new System.Drawing.Point(615, 217);
            this.dgvProcesosDetalle.Name = "dgvProcesosDetalle";
            this.dgvProcesosDetalle.Size = new System.Drawing.Size(440, 345);
            this.dgvProcesosDetalle.TabIndex = 27;
            // 
            // VentanaAProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 663);
            this.Controls.Add(this.dgvProcesosDetalle);
            this.Controls.Add(this.dgvListadoEjecucion);
            this.Controls.Add(this.btnEjecutarProcesos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "VentanaAProcesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto SO";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEjecucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesosDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProcess;
        private System.Windows.Forms.DataGridView dgvListadoEjecucion;
        private System.Windows.Forms.Button btnEjecutarProcesos;
        private System.Windows.Forms.DataGridView dgvProcesosDetalle;
    }
}

