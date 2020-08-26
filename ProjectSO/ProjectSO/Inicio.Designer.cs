namespace ProjectSO
{
    partial class Inicio
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
            System.Windows.Forms.ColumnHeader Prioridad;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LogoCeu = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.BtnAddtoQueue = new System.Windows.Forms.Button();
            this.ArriveTime = new System.Windows.Forms.TextBox();
            this.CPUTime = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.TextBox();
            this.queueProcesosLista = new System.Windows.Forms.ListView();
            this.btnEjecutarProcesos = new System.Windows.Forms.Button();
            this.NombreProceso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TiempoLlegada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Prioridad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.LogoCeu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 12);
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
            // LogoCeu
            // 
            this.LogoCeu.BackColor = System.Drawing.Color.White;
            this.LogoCeu.Image = global::ProjectSO.Properties.Resources.LOGOS_UNITEC_Y_CEUTEC_04;
            this.LogoCeu.InitialImage = global::ProjectSO.Properties.Resources.LOGOS_UNITEC_Y_CEUTEC_04;
            this.LogoCeu.Location = new System.Drawing.Point(44, 12);
            this.LogoCeu.Name = "LogoCeu";
            this.LogoCeu.Size = new System.Drawing.Size(146, 73);
            this.LogoCeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoCeu.TabIndex = 6;
            this.LogoCeu.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 16.25F);
            this.label7.Location = new System.Drawing.Point(95, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Queue de Procesos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 13.25F);
            this.label8.Location = new System.Drawing.Point(336, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Grupo #1";
            // 
            // ProcessName
            // 
            this.ProcessName.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.ProcessName.Location = new System.Drawing.Point(288, 142);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(153, 28);
            this.ProcessName.TabIndex = 9;
            // 
            // BtnAddtoQueue
            // 
            this.BtnAddtoQueue.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddtoQueue.ForeColor = System.Drawing.Color.White;
            this.BtnAddtoQueue.Location = new System.Drawing.Point(267, 321);
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
            // btnEjecutarProcesos
            // 
            this.btnEjecutarProcesos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEjecutarProcesos.ForeColor = System.Drawing.Color.White;
            this.btnEjecutarProcesos.Location = new System.Drawing.Point(244, 608);
            this.btnEjecutarProcesos.Name = "btnEjecutarProcesos";
            this.btnEjecutarProcesos.Size = new System.Drawing.Size(111, 31);
            this.btnEjecutarProcesos.TabIndex = 15;
            this.btnEjecutarProcesos.Text = "Ejecutar";
            this.btnEjecutarProcesos.UseVisualStyleBackColor = false;
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
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Prioridad.Width = 90;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 663);
            this.Controls.Add(this.btnEjecutarProcesos);
            this.Controls.Add(this.queueProcesosLista);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.CPUTime);
            this.Controls.Add(this.ArriveTime);
            this.Controls.Add(this.BtnAddtoQueue);
            this.Controls.Add(this.ProcessName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LogoCeu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto SO";
            ((System.ComponentModel.ISupportInitialize)(this.LogoCeu)).EndInit();
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
        private System.Windows.Forms.PictureBox LogoCeu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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
    }
}

