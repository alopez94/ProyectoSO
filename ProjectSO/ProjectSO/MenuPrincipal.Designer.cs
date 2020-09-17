namespace ProjectSO
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LogoCeu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCeu)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 13.25F);
            this.label8.Location = new System.Drawing.Point(270, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Grupo #1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proyecto Sistemas Operativos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Configuracion CPU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 13.25F);
            this.label2.Location = new System.Drawing.Point(252, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Menu Principal";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Configuracion MMU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Definicion Lista Ejecucion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(202, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Emulacion Task Manager";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(202, 549);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(218, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Task Manager";
            // 
            // LogoCeu
            // 
            this.LogoCeu.BackColor = System.Drawing.Color.White;
            this.LogoCeu.Image = global::ProjectSO.Properties.Resources.LOGOS_UNITEC_Y_CEUTEC_04;
            this.LogoCeu.InitialImage = global::ProjectSO.Properties.Resources.LOGOS_UNITEC_Y_CEUTEC_04;
            this.LogoCeu.Location = new System.Drawing.Point(512, 605);
            this.LogoCeu.Name = "LogoCeu";
            this.LogoCeu.Size = new System.Drawing.Size(109, 50);
            this.LogoCeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoCeu.TabIndex = 7;
            this.LogoCeu.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 667);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LogoCeu);
            this.Name = "MenuPrincipal";
            this.Text = "Proyecto SO";
            ((System.ComponentModel.ISupportInitialize)(this.LogoCeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoCeu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
    }
}