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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.BtnAddtoQueue = new System.Windows.Forms.Button();
            this.ArriveTime = new System.Windows.Forms.TextBox();
            this.CPUTime = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.TextBox();
            this.btnEjecutarProcesos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminarProceso = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvListadoProcesos1 = new System.Windows.Forms.DataGridView();
            this.dgvListadoEjecucion = new System.Windows.Forms.DataGridView();
            this.CPU1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejecucio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Listo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProcesos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEjecucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 16.25F);
            this.label2.Location = new System.Drawing.Point(192, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Configuración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label3.Location = new System.Drawing.Point(106, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Proceso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(111, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo de Llegada:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(166, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiempo CPU:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(192, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prioridad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 16.25F);
            this.label7.Location = new System.Drawing.Point(12, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Queue de Procesos:";
            // 
            // ProcessName
            // 
            this.ProcessName.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.ProcessName.Location = new System.Drawing.Point(288, 142);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(153, 28);
            this.ProcessName.TabIndex = 9;
            this.ProcessName.TextChanged += new System.EventHandler(this.ProcessName_TextChanged);
            // 
            // BtnAddtoQueue
            // 
            this.BtnAddtoQueue.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddtoQueue.ForeColor = System.Drawing.Color.White;
            this.BtnAddtoQueue.Location = new System.Drawing.Point(267, 330);
            this.BtnAddtoQueue.Name = "BtnAddtoQueue";
            this.BtnAddtoQueue.Size = new System.Drawing.Size(111, 31);
            this.BtnAddtoQueue.TabIndex = 10;
            this.BtnAddtoQueue.Text = "Agregar Proceso";
            this.BtnAddtoQueue.UseVisualStyleBackColor = false;
            this.BtnAddtoQueue.Click += new System.EventHandler(this.AddtoQueue_Click);
            // 
            // ArriveTime
            // 
            this.ArriveTime.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.ArriveTime.Location = new System.Drawing.Point(288, 186);
            this.ArriveTime.Name = "ArriveTime";
            this.ArriveTime.Size = new System.Drawing.Size(67, 28);
            this.ArriveTime.TabIndex = 11;
            this.ArriveTime.TextChanged += new System.EventHandler(this.ArriveTime_TextChanged);
            // 
            // CPUTime
            // 
            this.CPUTime.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.CPUTime.Location = new System.Drawing.Point(288, 226);
            this.CPUTime.Name = "CPUTime";
            this.CPUTime.Size = new System.Drawing.Size(67, 28);
            this.CPUTime.TabIndex = 12;
            // 
            // Priority
            // 
            this.Priority.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.Priority.Location = new System.Drawing.Point(288, 265);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(67, 28);
            this.Priority.TabIndex = 13;
            this.Priority.TextChanged += new System.EventHandler(this.Priority_TextChanged);
            // 
            // btnEjecutarProcesos
            // 
            this.btnEjecutarProcesos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEjecutarProcesos.ForeColor = System.Drawing.Color.White;
            this.btnEjecutarProcesos.Location = new System.Drawing.Point(828, 188);
            this.btnEjecutarProcesos.Name = "btnEjecutarProcesos";
            this.btnEjecutarProcesos.Size = new System.Drawing.Size(111, 31);
            this.btnEjecutarProcesos.TabIndex = 15;
            this.btnEjecutarProcesos.Text = "Ejecutar";
            this.btnEjecutarProcesos.UseVisualStyleBackColor = false;
            this.btnEjecutarProcesos.Click += new System.EventHandler(this.btnEjecutarProcesos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEliminarProceso
            // 
            this.btnEliminarProceso.BackColor = System.Drawing.Color.Red;
            this.btnEliminarProceso.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProceso.Location = new System.Drawing.Point(233, 608);
            this.btnEliminarProceso.Name = "btnEliminarProceso";
            this.btnEliminarProceso.Size = new System.Drawing.Size(111, 31);
            this.btnEliminarProceso.TabIndex = 16;
            this.btnEliminarProceso.Text = "Eliminar";
            this.btnEliminarProceso.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(679, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Quantum CPU:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantum
            // 
            this.txtQuantum.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.txtQuantum.Location = new System.Drawing.Point(819, 126);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(153, 28);
            this.txtQuantum.TabIndex = 22;
            this.txtQuantum.UseWaitCursor = true;
            this.txtQuantum.TextChanged += new System.EventHandler(this.txtQuantum_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(628, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Metodo de Ejecucion: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Por Tiempo de Llegada",
            "Por Tiempo de CPU",
            "Por Prioridad",
            "Por CPU/Tiempo Llegada"});
            this.comboBox1.Location = new System.Drawing.Point(819, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // dgvListadoProcesos1
            // 
            this.dgvListadoProcesos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProcesos1.Location = new System.Drawing.Point(12, 419);
            this.dgvListadoProcesos1.Name = "dgvListadoProcesos1";
            this.dgvListadoProcesos1.Size = new System.Drawing.Size(543, 162);
            this.dgvListadoProcesos1.TabIndex = 25;
            this.dgvListadoProcesos1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvListadoProcesos1_UserDeletingRow);
            // 
            // dgvListadoEjecucion
            // 
            this.dgvListadoEjecucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEjecucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPU1,
            this.Ejecucio,
            this.Listo,
            this.Bloqueo});
            this.dgvListadoEjecucion.Location = new System.Drawing.Point(638, 236);
            this.dgvListadoEjecucion.Name = "dgvListadoEjecucion";
            this.dgvListadoEjecucion.Size = new System.Drawing.Size(445, 345);
            this.dgvListadoEjecucion.TabIndex = 26;
            this.dgvListadoEjecucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CPU1
            // 
            this.CPU1.HeaderText = "CPU Time";
            this.CPU1.Name = "CPU1";
            // 
            // Ejecucio
            // 
            this.Ejecucio.HeaderText = "En Ejecucion";
            this.Ejecucio.Name = "Ejecucio";
            // 
            // Listo
            // 
            this.Listo.HeaderText = "Listo";
            this.Listo.Name = "Listo";
            // 
            // Bloqueo
            // 
            this.Bloqueo.HeaderText = "Bloqueo";
            this.Bloqueo.Name = "Bloqueo";
            // 
            // VentanaAProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 663);
            this.Controls.Add(this.dgvListadoEjecucion);
            this.Controls.Add(this.dgvListadoProcesos1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminarProceso);
            this.Controls.Add(this.btnEjecutarProcesos);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.CPUTime);
            this.Controls.Add(this.ArriveTime);
            this.Controls.Add(this.BtnAddtoQueue);
            this.Controls.Add(this.ProcessName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "VentanaAProcesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto SO";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProcesos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEjecucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProcessName;
        private System.Windows.Forms.Button BtnAddtoQueue;
        private System.Windows.Forms.TextBox ArriveTime;
        private System.Windows.Forms.TextBox CPUTime;
        private System.Windows.Forms.TextBox Priority;
        private System.Windows.Forms.Button btnEjecutarProcesos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEliminarProceso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListadoEjecucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejecucio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Listo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloqueo;
        private System.Windows.Forms.DataGridView dgvListadoProcesos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProcess;
    }
}

