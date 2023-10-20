namespace Lab3
{
    partial class informacionJuego
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pIngInfo = new System.Windows.Forms.Panel();
            this.calFecha = new System.Windows.Forms.DateTimePicker();
            this.btnInfoJuego = new System.Windows.Forms.Button();
            this.lblEndulz = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProxEndul = new System.Windows.Forms.Label();
            this.lblFJ = new System.Windows.Forms.Label();
            this.btnProxE = new System.Windows.Forms.Button();
            this.pIngInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(316, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(313, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Información del Juego";
            // 
            // pIngInfo
            // 
            this.pIngInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pIngInfo.Controls.Add(this.calFecha);
            this.pIngInfo.Controls.Add(this.btnInfoJuego);
            this.pIngInfo.Controls.Add(this.lblEndulz);
            this.pIngInfo.Controls.Add(this.label5);
            this.pIngInfo.Controls.Add(this.label1);
            this.pIngInfo.Controls.Add(this.lblProxEndul);
            this.pIngInfo.Controls.Add(this.lblFJ);
            this.pIngInfo.Controls.Add(this.btnProxE);
            this.pIngInfo.Location = new System.Drawing.Point(32, 82);
            this.pIngInfo.Name = "pIngInfo";
            this.pIngInfo.Size = new System.Drawing.Size(940, 540);
            this.pIngInfo.TabIndex = 13;
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(86, 94);
            this.calFecha.Name = "calFecha";
            this.calFecha.Size = new System.Drawing.Size(253, 22);
            this.calFecha.TabIndex = 24;
            // 
            // btnInfoJuego
            // 
            this.btnInfoJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnInfoJuego.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoJuego.Location = new System.Drawing.Point(599, 166);
            this.btnInfoJuego.Name = "btnInfoJuego";
            this.btnInfoJuego.Size = new System.Drawing.Size(198, 65);
            this.btnInfoJuego.TabIndex = 23;
            this.btnInfoJuego.Text = "Imprimir la Información del Juego";
            this.btnInfoJuego.UseVisualStyleBackColor = true;
            this.btnInfoJuego.Click += new System.EventHandler(this.btnInfoJuego_Click);
            // 
            // lblEndulz
            // 
            this.lblEndulz.AutoSize = true;
            this.lblEndulz.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndulz.Location = new System.Drawing.Point(56, 166);
            this.lblEndulz.Name = "lblEndulz";
            this.lblEndulz.Size = new System.Drawing.Size(0, 17);
            this.lblEndulz.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(57, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "¿Cuándo es la próxima endulzada?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Selecciona una fecha";
            // 
            // lblProxEndul
            // 
            this.lblProxEndul.AutoSize = true;
            this.lblProxEndul.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxEndul.Location = new System.Drawing.Point(208, 366);
            this.lblProxEndul.Name = "lblProxEndul";
            this.lblProxEndul.Size = new System.Drawing.Size(0, 17);
            this.lblProxEndul.TabIndex = 19;
            // 
            // lblFJ
            // 
            this.lblFJ.AutoSize = true;
            this.lblFJ.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFJ.Location = new System.Drawing.Point(56, 415);
            this.lblFJ.Name = "lblFJ";
            this.lblFJ.Size = new System.Drawing.Size(0, 17);
            this.lblFJ.TabIndex = 12;
            // 
            // btnProxE
            // 
            this.btnProxE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnProxE.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxE.Location = new System.Drawing.Point(59, 319);
            this.btnProxE.Name = "btnProxE";
            this.btnProxE.Size = new System.Drawing.Size(308, 34);
            this.btnProxE.TabIndex = 10;
            this.btnProxE.Text = "Calcular\r\n";
            this.btnProxE.UseVisualStyleBackColor = true;
            this.btnProxE.Click += new System.EventHandler(this.btnProxE_Click_1);
            // 
            // informacionJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1007, 684);
            this.Controls.Add(this.pIngInfo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "informacionJuego";
            this.Text = "informacionJuego";
            this.pIngInfo.ResumeLayout(false);
            this.pIngInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pIngInfo;
        private System.Windows.Forms.Label lblFJ;
        private System.Windows.Forms.Button btnProxE;
        private System.Windows.Forms.Label lblProxEndul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInfoJuego;
        public System.Windows.Forms.Label lblEndulz;
        private System.Windows.Forms.DateTimePicker calFecha;
    }
}