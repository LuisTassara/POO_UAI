namespace Alquiler_de_Canchas_2._0
{
    partial class Form1
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
            this.lb_Desde = new System.Windows.Forms.Label();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.cbo_Cancha = new System.Windows.Forms.ComboBox();
            this.lbl_Cancha = new System.Windows.Forms.Label();
            this.btn_Reservar = new System.Windows.Forms.Button();
            this.lbl_RC5 = new System.Windows.Forms.Label();
            this.lbl_RC6 = new System.Windows.Forms.Label();
            this.lbl_RC7 = new System.Windows.Forms.Label();
            this.lbl_Rtotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_Hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Desde
            // 
            this.lb_Desde.AutoSize = true;
            this.lb_Desde.Location = new System.Drawing.Point(36, 45);
            this.lb_Desde.Name = "lb_Desde";
            this.lb_Desde.Size = new System.Drawing.Size(56, 20);
            this.lb_Desde.TabIndex = 0;
            this.lb_Desde.Text = "Desde";
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Location = new System.Drawing.Point(36, 117);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(52, 20);
            this.lbl_Hasta.TabIndex = 1;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // cbo_Cancha
            // 
            this.cbo_Cancha.FormattingEnabled = true;
            this.cbo_Cancha.Location = new System.Drawing.Point(121, 184);
            this.cbo_Cancha.Name = "cbo_Cancha";
            this.cbo_Cancha.Size = new System.Drawing.Size(174, 28);
            this.cbo_Cancha.TabIndex = 4;
            // 
            // lbl_Cancha
            // 
            this.lbl_Cancha.AutoSize = true;
            this.lbl_Cancha.Location = new System.Drawing.Point(36, 187);
            this.lbl_Cancha.Name = "lbl_Cancha";
            this.lbl_Cancha.Size = new System.Drawing.Size(64, 20);
            this.lbl_Cancha.TabIndex = 5;
            this.lbl_Cancha.Text = "Cancha";
            // 
            // btn_Reservar
            // 
            this.btn_Reservar.Location = new System.Drawing.Point(40, 255);
            this.btn_Reservar.Name = "btn_Reservar";
            this.btn_Reservar.Size = new System.Drawing.Size(255, 39);
            this.btn_Reservar.TabIndex = 6;
            this.btn_Reservar.Text = "Reservar";
            this.btn_Reservar.UseVisualStyleBackColor = true;
            // 
            // lbl_RC5
            // 
            this.lbl_RC5.AutoSize = true;
            this.lbl_RC5.Location = new System.Drawing.Point(6, 28);
            this.lbl_RC5.Name = "lbl_RC5";
            this.lbl_RC5.Size = new System.Drawing.Size(172, 20);
            this.lbl_RC5.TabIndex = 7;
            this.lbl_RC5.Text = "Recaudado Cancha 5: ";
            // 
            // lbl_RC6
            // 
            this.lbl_RC6.AutoSize = true;
            this.lbl_RC6.Location = new System.Drawing.Point(6, 68);
            this.lbl_RC6.Name = "lbl_RC6";
            this.lbl_RC6.Size = new System.Drawing.Size(172, 20);
            this.lbl_RC6.TabIndex = 8;
            this.lbl_RC6.Text = "Recaudado Cancha 6: ";
            // 
            // lbl_RC7
            // 
            this.lbl_RC7.AutoSize = true;
            this.lbl_RC7.Location = new System.Drawing.Point(6, 111);
            this.lbl_RC7.Name = "lbl_RC7";
            this.lbl_RC7.Size = new System.Drawing.Size(172, 20);
            this.lbl_RC7.TabIndex = 9;
            this.lbl_RC7.Text = "Recaudado Cancha 7: ";
            // 
            // lbl_Rtotal
            // 
            this.lbl_Rtotal.AutoSize = true;
            this.lbl_Rtotal.Location = new System.Drawing.Point(6, 155);
            this.lbl_Rtotal.Name = "lbl_Rtotal";
            this.lbl_Rtotal.Size = new System.Drawing.Size(160, 20);
            this.lbl_Rtotal.TabIndex = 10;
            this.lbl_Rtotal.Text = "Recaudación Predio: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_RC7);
            this.groupBox1.Controls.Add(this.lbl_Rtotal);
            this.groupBox1.Controls.Add(this.lbl_RC5);
            this.groupBox1.Controls.Add(this.lbl_RC6);
            this.groupBox1.Location = new System.Drawing.Point(40, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 183);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recaudación";
            // 
            // dtp_Desde
            // 
            this.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Desde.Location = new System.Drawing.Point(121, 39);
            this.dtp_Desde.MinDate = new System.DateTime(2020, 7, 19, 0, 0, 0, 0);
            this.dtp_Desde.Name = "dtp_Desde";
            this.dtp_Desde.Size = new System.Drawing.Size(262, 26);
            this.dtp_Desde.TabIndex = 11;
            // 
            // dtp_Hasta
            // 
            this.dtp_Hasta.Location = new System.Drawing.Point(121, 112);
            this.dtp_Hasta.Name = "dtp_Hasta";
            this.dtp_Hasta.Size = new System.Drawing.Size(262, 26);
            this.dtp_Hasta.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 545);
            this.Controls.Add(this.dtp_Hasta);
            this.Controls.Add(this.dtp_Desde);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Reservar);
            this.Controls.Add(this.lbl_Cancha);
            this.Controls.Add(this.cbo_Cancha);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lb_Desde);
            this.Name = "Form1";
            this.Text = "Reserva Canchas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Desde;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.ComboBox cbo_Cancha;
        private System.Windows.Forms.Label lbl_Cancha;
        private System.Windows.Forms.Button btn_Reservar;
        private System.Windows.Forms.Label lbl_RC5;
        private System.Windows.Forms.Label lbl_RC6;
        private System.Windows.Forms.Label lbl_RC7;
        private System.Windows.Forms.Label lbl_Rtotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_Desde;
        private System.Windows.Forms.DateTimePicker dtp_Hasta;
    }
}

