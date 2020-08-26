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
            System.Windows.Forms.ColumnHeader Prioridad;
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
            this.queueProcesosLista = new System.Windows.Forms.ListView();
            this.NombreProceso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TiempoLlegada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEjecutarProcesos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminarProceso = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantumText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            Prioridad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Prioridad.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 16.25F);
            this.label2.Location = new System.Drawing.Point(240, 98);
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
            this.label7.Location = new System.Drawing.Point(111, 395);
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
            // queueProcesosLista
            // 
            this.queueProcesosLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreProceso,
            this.TiempoLlegada,
            this.CPU,
            Prioridad});
            this.queueProcesosLista.FullRowSelect = true;
            this.queueProcesosLista.GridLines = true;
            this.queueProcesosLista.HideSelection = false;
            this.queueProcesosLista.Location = new System.Drawing.Point(115, 437);
            this.queueProcesosLista.Name = "queueProcesosLista";
            this.queueProcesosLista.Size = new System.Drawing.Size(369, 153);
            this.queueProcesosLista.TabIndex = 14;
            this.queueProcesosLista.UseCompatibleStateImageBehavior = false;
            this.queueProcesosLista.View = System.Windows.Forms.View.Details;
            this.queueProcesosLista.SelectedIndexChanged += new System.EventHandler(this.queueProcesosLista_SelectedIndexChanged);
            // 
            // NombreProceso
            // 
            this.NombreProceso.Text = "Nombre Proceso";
            this.NombreProceso.Width = 92;
            // 
            // TiempoLlegada
            // 
            this.TiempoLlegada.Text = "Tiempo Llegada";
            this.TiempoLlegada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TiempoLlegada.Width = 90;
            // 
            // CPU
            // 
            this.CPU.Text = "Tiempo CPU";
            this.CPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CPU.Width = 90;
            // 
            // btnEjecutarProcesos
            // 
            this.btnEjecutarProcesos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEjecutarProcesos.ForeColor = System.Drawing.Color.White;
            this.btnEjecutarProcesos.Location = new System.Drawing.Point(737, 186);
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
            this.btnEliminarProceso.Click += new System.EventHandler(this.btnEliminarProceso_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ForeColor = System.Drawing.Color.Red;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(570, 230);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 360);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Uso CPU";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "En Ejecucion";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Listo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bloqueado";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 147;
            // 
            // QuantumText
            // 
            this.QuantumText.Location = new System.Drawing.Point(786, 133);
            this.QuantumText.Name = "QuantumText";
            this.QuantumText.Size = new System.Drawing.Size(121, 20);
            this.QuantumText.TabIndex = 19;
            this.QuantumText.TextChanged += new System.EventHandler(this.QuantumText_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(646, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Quantum CPU:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VentanaAProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1046, 663);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.QuantumText);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEliminarProceso);
            this.Controls.Add(this.btnEjecutarProcesos);
            this.Controls.Add(this.queueProcesosLista);
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
        private System.Windows.Forms.ListView queueProcesosLista;
        private System.Windows.Forms.Button btnEjecutarProcesos;
        private System.Windows.Forms.ColumnHeader NombreProceso;
        private System.Windows.Forms.ColumnHeader TiempoLlegada;
        private System.Windows.Forms.ColumnHeader CPU;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEliminarProceso;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox QuantumText;
        private System.Windows.Forms.Label label9;
    }
}

