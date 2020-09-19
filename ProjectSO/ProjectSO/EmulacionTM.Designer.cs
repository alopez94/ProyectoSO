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
            this.ViewDetalleProceso = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReloadLista = new System.Windows.Forms.Button();
            this.dgvMMUDisplay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DetalleQuantumCPU = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.detalleAlgoritmoCPU = new System.Windows.Forms.Label();
            this.DetalleAlgoritmoMMU = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DetallePaginasMMU = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lvDetallesMMU = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEjecucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMMUDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
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
            this.btnEjecutarProcesos.Location = new System.Drawing.Point(62, 56);
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
            this.dgvListadoEjecucion.Location = new System.Drawing.Point(61, 139);
            this.dgvListadoEjecucion.Name = "dgvListadoEjecucion";
            this.dgvListadoEjecucion.Size = new System.Drawing.Size(545, 215);
            this.dgvListadoEjecucion.TabIndex = 26;
            this.dgvListadoEjecucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewDetalleProceso
            // 
            this.ViewDetalleProceso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ViewDetalleProceso.HideSelection = false;
            this.ViewDetalleProceso.Location = new System.Drawing.Point(648, 139);
            this.ViewDetalleProceso.Name = "ViewDetalleProceso";
            this.ViewDetalleProceso.Size = new System.Drawing.Size(405, 215);
            this.ViewDetalleProceso.TabIndex = 27;
            this.ViewDetalleProceso.UseCompatibleStateImageBehavior = false;
            this.ViewDetalleProceso.View = System.Windows.Forms.View.Details;
            this.ViewDetalleProceso.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estado";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tiempo Restante";
            this.columnHeader4.Width = 93;
            // 
            // btnReloadLista
            // 
            this.btnReloadLista.Location = new System.Drawing.Point(179, 56);
            this.btnReloadLista.Name = "btnReloadLista";
            this.btnReloadLista.Size = new System.Drawing.Size(112, 31);
            this.btnReloadLista.TabIndex = 28;
            this.btnReloadLista.Text = "Reload";
            this.btnReloadLista.UseVisualStyleBackColor = true;
            this.btnReloadLista.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvMMUDisplay
            // 
            this.dgvMMUDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMMUDisplay.Location = new System.Drawing.Point(61, 417);
            this.dgvMMUDisplay.Name = "dgvMMUDisplay";
            this.dgvMMUDisplay.Size = new System.Drawing.Size(545, 202);
            this.dgvMMUDisplay.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Detalle Ejecucion CPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Detalle Manejo Memoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Quantum:";
            // 
            // DetalleQuantumCPU
            // 
            this.DetalleQuantumCPU.AutoSize = true;
            this.DetalleQuantumCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleQuantumCPU.Location = new System.Drawing.Point(550, 91);
            this.DetalleQuantumCPU.Name = "DetalleQuantumCPU";
            this.DetalleQuantumCPU.Size = new System.Drawing.Size(38, 15);
            this.DetalleQuantumCPU.TabIndex = 33;
            this.DetalleQuantumCPU.Text = " here ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Algoritmo:";
            // 
            // detalleAlgoritmoCPU
            // 
            this.detalleAlgoritmoCPU.AutoSize = true;
            this.detalleAlgoritmoCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleAlgoritmoCPU.Location = new System.Drawing.Point(550, 115);
            this.detalleAlgoritmoCPU.Name = "detalleAlgoritmoCPU";
            this.detalleAlgoritmoCPU.Size = new System.Drawing.Size(38, 15);
            this.detalleAlgoritmoCPU.TabIndex = 35;
            this.detalleAlgoritmoCPU.Text = " here ";
            // 
            // DetalleAlgoritmoMMU
            // 
            this.DetalleAlgoritmoMMU.AutoSize = true;
            this.DetalleAlgoritmoMMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleAlgoritmoMMU.Location = new System.Drawing.Point(561, 395);
            this.DetalleAlgoritmoMMU.Name = "DetalleAlgoritmoMMU";
            this.DetalleAlgoritmoMMU.Size = new System.Drawing.Size(38, 15);
            this.DetalleAlgoritmoMMU.TabIndex = 39;
            this.DetalleAlgoritmoMMU.Text = " here ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Algoritmo:";
            // 
            // DetallePaginasMMU
            // 
            this.DetallePaginasMMU.AutoSize = true;
            this.DetallePaginasMMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetallePaginasMMU.Location = new System.Drawing.Point(561, 371);
            this.DetallePaginasMMU.Name = "DetallePaginasMMU";
            this.DetallePaginasMMU.Size = new System.Drawing.Size(38, 15);
            this.DetallePaginasMMU.TabIndex = 37;
            this.DetallePaginasMMU.Text = " here ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(503, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Paginas:";
            // 
            // lvDetallesMMU
            // 
            this.lvDetallesMMU.HideSelection = false;
            this.lvDetallesMMU.Location = new System.Drawing.Point(648, 417);
            this.lvDetallesMMU.Name = "lvDetallesMMU";
            this.lvDetallesMMU.Size = new System.Drawing.Size(405, 202);
            this.lvDetallesMMU.TabIndex = 40;
            this.lvDetallesMMU.UseCompatibleStateImageBehavior = false;
            this.lvDetallesMMU.View = System.Windows.Forms.View.List;
            // 
            // VentanaAProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 663);
            this.Controls.Add(this.lvDetallesMMU);
            this.Controls.Add(this.DetalleAlgoritmoMMU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DetallePaginasMMU);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.detalleAlgoritmoCPU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetalleQuantumCPU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMMUDisplay);
            this.Controls.Add(this.btnReloadLista);
            this.Controls.Add(this.ViewDetalleProceso);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMMUDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProcess;
        private System.Windows.Forms.DataGridView dgvListadoEjecucion;
        private System.Windows.Forms.Button btnEjecutarProcesos;
        private System.Windows.Forms.ListView ViewDetalleProceso;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnReloadLista;
        private System.Windows.Forms.DataGridView dgvMMUDisplay;
        private System.Windows.Forms.Label DetalleQuantumCPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label detalleAlgoritmoCPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DetalleAlgoritmoMMU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DetallePaginasMMU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvDetallesMMU;
    }
}

