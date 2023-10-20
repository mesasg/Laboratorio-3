namespace Lab3
{
    partial class informacionJugadores
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
            this.btImInf = new System.Windows.Forms.Button();
            this.btnVerIn = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pIngInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(274, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(410, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Información de los Jugadores";
            // 
            // pIngInfo
            // 
            this.pIngInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pIngInfo.Controls.Add(this.btImInf);
            this.pIngInfo.Controls.Add(this.btnVerIn);
            this.pIngInfo.Controls.Add(this.btnSig);
            this.pIngInfo.Controls.Add(this.btnAnt);
            this.pIngInfo.Controls.Add(this.label2);
            this.pIngInfo.Controls.Add(this.lblInfo);
            this.pIngInfo.Location = new System.Drawing.Point(32, 82);
            this.pIngInfo.Name = "pIngInfo";
            this.pIngInfo.Size = new System.Drawing.Size(940, 540);
            this.pIngInfo.TabIndex = 12;
            // 
            // btImInf
            // 
            this.btImInf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btImInf.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImInf.Location = new System.Drawing.Point(201, 355);
            this.btImInf.Name = "btImInf";
            this.btImInf.Size = new System.Drawing.Size(115, 34);
            this.btImInf.TabIndex = 15;
            this.btImInf.Text = "Imprimir";
            this.btImInf.UseVisualStyleBackColor = true;
            this.btImInf.Visible = false;
            this.btImInf.Click += new System.EventHandler(this.btImInf_Click);
            // 
            // btnVerIn
            // 
            this.btnVerIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnVerIn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerIn.Location = new System.Drawing.Point(102, 56);
            this.btnVerIn.Name = "btnVerIn";
            this.btnVerIn.Size = new System.Drawing.Size(316, 34);
            this.btnVerIn.TabIndex = 15;
            this.btnVerIn.Text = "Ver Información de los jugadores";
            this.btnVerIn.UseVisualStyleBackColor = true;
            this.btnVerIn.Click += new System.EventHandler(this.btnVerIn_Click);
            // 
            // btnSig
            // 
            this.btnSig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnSig.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.Location = new System.Drawing.Point(262, 315);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(115, 34);
            this.btnSig.TabIndex = 11;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Visible = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnAnt.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnt.Location = new System.Drawing.Point(141, 315);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(115, 34);
            this.btnAnt.TabIndex = 10;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Visible = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(206, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 1;
            this.label2.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(139, 148);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Visible = false;
            // 
            // informacionJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1007, 684);
            this.Controls.Add(this.pIngInfo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "informacionJugadores";
            this.Text = "informacionJugadores";
            this.pIngInfo.ResumeLayout(false);
            this.pIngInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pIngInfo;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btImInf;
        private System.Windows.Forms.Button btnVerIn;
    }
}