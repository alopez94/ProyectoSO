namespace ProjectSO
{
    partial class procesoslista
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
            this.dgvListadoProcesos1 = new System.Windows.Forms.DataGridView();
            this.Priority = new System.Windows.Forms.TextBox();
            this.CPUTime = new System.Windows.Forms.TextBox();
            this.ArriveTime = new System.Windows.Forms.TextBox();
            this.BtnAddtoQueue = new System.Windows.Forms.Button();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProcesos1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoProcesos1
            // 
            this.dgvListadoProcesos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProcesos1.Location = new System.Drawing.Point(12, 306);
            this.dgvListadoProcesos1.Name = "dgvListadoProcesos1";
            this.dgvListadoProcesos1.Size = new System.Drawing.Size(543, 162);
            this.dgvListadoProcesos1.TabIndex = 37;
            this.dgvListadoProcesos1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProcesos1_CellContentClick);
            // 
            // Priority
            // 
            this.Priority.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.Priority.Location = new System.Drawing.Point(268, 196);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(67, 28);
            this.Priority.TabIndex = 36;
            this.Priority.TextChanged += new System.EventHandler(this.Priority_TextChanged);
            // 
            // CPUTime
            // 
            this.CPUTime.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.CPUTime.Location = new System.Drawing.Point(268, 157);
            this.CPUTime.Name = "CPUTime";
            this.CPUTime.Size = new System.Drawing.Size(67, 28);
            this.CPUTime.TabIndex = 35;
            // 
            // ArriveTime
            // 
            this.ArriveTime.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.ArriveTime.Location = new System.Drawing.Point(268, 117);
            this.ArriveTime.Name = "ArriveTime";
            this.ArriveTime.Size = new System.Drawing.Size(67, 28);
            this.ArriveTime.TabIndex = 34;
            // 
            // BtnAddtoQueue
            // 
            this.BtnAddtoQueue.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddtoQueue.ForeColor = System.Drawing.Color.White;
            this.BtnAddtoQueue.Location = new System.Drawing.Point(210, 239);
            this.BtnAddtoQueue.Name = "BtnAddtoQueue";
            this.BtnAddtoQueue.Size = new System.Drawing.Size(111, 31);
            this.BtnAddtoQueue.TabIndex = 33;
            this.BtnAddtoQueue.Text = "Agregar Proceso";
            this.BtnAddtoQueue.UseVisualStyleBackColor = false;
            this.BtnAddtoQueue.Click += new System.EventHandler(this.BtnAddtoQueue_Click);
            // 
            // ProcessName
            // 
            this.ProcessName.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.ProcessName.Location = new System.Drawing.Point(268, 73);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(153, 28);
            this.ProcessName.TabIndex = 32;
            this.ProcessName.TextChanged += new System.EventHandler(this.ProcessName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 16.25F);
            this.label7.Location = new System.Drawing.Point(12, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Queue de Procesos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(172, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Prioridad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(146, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tiempo CPU:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(91, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tiempo de Llegada:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F);
            this.label3.Location = new System.Drawing.Point(86, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre del Proceso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 16.25F);
            this.label2.Location = new System.Drawing.Point(197, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Configuración";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 27);
            this.button1.TabIndex = 38;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // procesoslista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvListadoProcesos1);
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
            this.Name = "procesoslista";
            this.Text = "procesoslista";
            this.Load += new System.EventHandler(this.procesoslista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProcesos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoProcesos1;
        private System.Windows.Forms.TextBox Priority;
        private System.Windows.Forms.TextBox CPUTime;
        private System.Windows.Forms.TextBox ArriveTime;
        private System.Windows.Forms.Button BtnAddtoQueue;
        private System.Windows.Forms.TextBox ProcessName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}