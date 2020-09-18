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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEjecucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMMUDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 24);
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
            this.btnEjecutarProcesos.Location = new System.Drawing.Point(61, 66);
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
            this.dgvListadoEjecucion.Location = new System.Drawing.Point(61, 103);
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
            this.ViewDetalleProceso.Location = new System.Drawing.Point(663, 103);
            this.ViewDetalleProceso.Name = "ViewDetalleProceso";
            this.ViewDetalleProceso.Size = new System.Drawing.Size(349, 215);
            this.ViewDetalleProceso.TabIndex = 27;
            this.ViewDetalleProceso.UseCompatibleStateImageBehavior = false;
            this.ViewDetalleProceso.View = System.Windows.Forms.View.Details;
            this.ViewDetalleProceso.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
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
            this.btnReloadLista.Location = new System.Drawing.Point(494, 66);
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
            this.dgvMMUDisplay.Location = new System.Drawing.Point(61, 362);
            this.dgvMMUDisplay.Name = "dgvMMUDisplay";
            this.dgvMMUDisplay.Size = new System.Drawing.Size(545, 194);
            this.dgvMMUDisplay.TabIndex = 29;
            // 
            // VentanaAProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 663);
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
    }
}

