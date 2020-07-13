namespace Recital
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
            this.cbo_Banda = new System.Windows.Forms.ComboBox();
            this.cbo_Fecha = new System.Windows.Forms.ComboBox();
            this.cbo_Entrada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_MTRL = new System.Windows.Forms.Label();
            this.lbl_MTCRM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TRecaudado = new System.Windows.Forms.Label();
            this.lbl_CEV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_Banda
            // 
            this.cbo_Banda.FormattingEnabled = true;
            this.cbo_Banda.Location = new System.Drawing.Point(91, 34);
            this.cbo_Banda.Name = "cbo_Banda";
            this.cbo_Banda.Size = new System.Drawing.Size(204, 28);
            this.cbo_Banda.TabIndex = 0;
            this.cbo_Banda.SelectedIndexChanged += new System.EventHandler(this.cbo_Banda_SelectedIndexChanged);
            // 
            // cbo_Fecha
            // 
            this.cbo_Fecha.FormattingEnabled = true;
            this.cbo_Fecha.Location = new System.Drawing.Point(91, 112);
            this.cbo_Fecha.Name = "cbo_Fecha";
            this.cbo_Fecha.Size = new System.Drawing.Size(204, 28);
            this.cbo_Fecha.TabIndex = 1;
            this.cbo_Fecha.SelectedIndexChanged += new System.EventHandler(this.cbo_Fecha_SelectedIndexChanged);
            // 
            // cbo_Entrada
            // 
            this.cbo_Entrada.FormattingEnabled = true;
            this.cbo_Entrada.Location = new System.Drawing.Point(91, 200);
            this.cbo_Entrada.Name = "cbo_Entrada";
            this.cbo_Entrada.Size = new System.Drawing.Size(204, 28);
            this.cbo_Entrada.TabIndex = 2;
            this.cbo_Entrada.SelectedIndexChanged += new System.EventHandler(this.cbo_Entrada_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Location = new System.Drawing.Point(315, 34);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(153, 194);
            this.btn_Comprar.TabIndex = 6;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(17, 268);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(53, 20);
            this.lbl_Precio.TabIndex = 7;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_MTRL
            // 
            this.lbl_MTRL.AutoSize = true;
            this.lbl_MTRL.Location = new System.Drawing.Point(29, 42);
            this.lbl_MTRL.Name = "lbl_MTRL";
            this.lbl_MTRL.Size = new System.Drawing.Size(258, 20);
            this.lbl_MTRL.TabIndex = 8;
            this.lbl_MTRL.Text = "Monto Total Recaudado La Renga:";
            // 
            // lbl_MTCRM
            // 
            this.lbl_MTCRM.AutoSize = true;
            this.lbl_MTCRM.Location = new System.Drawing.Point(29, 88);
            this.lbl_MTCRM.Name = "lbl_MTCRM";
            this.lbl_MTCRM.Size = new System.Drawing.Size(250, 20);
            this.lbl_MTCRM.TabIndex = 9;
            this.lbl_MTCRM.Text = "Monto Total Recaudado Metallica:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_CEV);
            this.groupBox1.Controls.Add(this.lbl_TRecaudado);
            this.groupBox1.Controls.Add(this.lbl_MTRL);
            this.groupBox1.Controls.Add(this.lbl_MTCRM);
            this.groupBox1.Location = new System.Drawing.Point(21, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // lbl_TRecaudado
            // 
            this.lbl_TRecaudado.AutoSize = true;
            this.lbl_TRecaudado.Location = new System.Drawing.Point(20, 130);
            this.lbl_TRecaudado.Name = "lbl_TRecaudado";
            this.lbl_TRecaudado.Size = new System.Drawing.Size(132, 20);
            this.lbl_TRecaudado.TabIndex = 10;
            this.lbl_TRecaudado.Text = "TotatlRecaudado";
            // 
            // lbl_CEV
            // 
            this.lbl_CEV.AutoSize = true;
            this.lbl_CEV.Location = new System.Drawing.Point(20, 167);
            this.lbl_CEV.Name = "lbl_CEV";
            this.lbl_CEV.Size = new System.Drawing.Size(213, 20);
            this.lbl_CEV.TabIndex = 11;
            this.lbl_CEV.Text = "CantidadEntradasVendidas: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Entrada);
            this.Controls.Add(this.cbo_Fecha);
            this.Controls.Add(this.cbo_Banda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Banda;
        private System.Windows.Forms.ComboBox cbo_Fecha;
        private System.Windows.Forms.ComboBox cbo_Entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_MTRL;
        private System.Windows.Forms.Label lbl_MTCRM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TRecaudado;
        private System.Windows.Forms.Label lbl_CEV;
    }
}

