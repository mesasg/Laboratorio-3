namespace Lab3
{
    partial class nJuegoCantJ
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
            this.lblCantJugadores = new System.Windows.Forms.Label();
            this.txtCantJugadores = new System.Windows.Forms.TextBox();
            this.btnCantJugadores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(293, 100);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear un nuevo juego";
            // 
            // lblCantJugadores
            // 
            this.lblCantJugadores.AutoSize = true;
            this.lblCantJugadores.BackColor = System.Drawing.Color.Transparent;
            this.lblCantJugadores.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantJugadores.Location = new System.Drawing.Point(16, 17);
            this.lblCantJugadores.Name = "lblCantJugadores";
            this.lblCantJugadores.Size = new System.Drawing.Size(239, 17);
            this.lblCantJugadores.TabIndex = 1;
            this.lblCantJugadores.Text = "¿Cuantas personas van a jugar?";
            // 
            // txtCantJugadores
            // 
            this.txtCantJugadores.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantJugadores.Location = new System.Drawing.Point(19, 48);
            this.txtCantJugadores.Name = "txtCantJugadores";
            this.txtCantJugadores.Size = new System.Drawing.Size(111, 25);
            this.txtCantJugadores.TabIndex = 2;
            // 
            // btnCantJugadores
            // 
            this.btnCantJugadores.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantJugadores.Location = new System.Drawing.Point(19, 79);
            this.btnCantJugadores.Name = "btnCantJugadores";
            this.btnCantJugadores.Size = new System.Drawing.Size(75, 33);
            this.btnCantJugadores.TabIndex = 3;
            this.btnCantJugadores.Text = "Enviar";
            this.btnCantJugadores.UseVisualStyleBackColor = true;
            this.btnCantJugadores.Click += new System.EventHandler(this.btnCantJugadores_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnCantJugadores);
            this.panel1.Controls.Add(this.txtCantJugadores);
            this.panel1.Controls.Add(this.lblCantJugadores);
            this.panel1.Location = new System.Drawing.Point(266, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 131);
            this.panel1.TabIndex = 4;
            // 
            // nuevoJuego1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(835, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nuevoJuego1";
            this.Text = "nuevoJuego";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantJugadores;
        private System.Windows.Forms.TextBox txtCantJugadores;
        private System.Windows.Forms.Button btnCantJugadores;
        private System.Windows.Forms.Panel panel1;
    }
}