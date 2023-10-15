namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInfoJugadores = new System.Windows.Forms.Button();
            this.btnInfoJuego = new System.Windows.Forms.Button();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloIni = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Controls.Add(this.panel4);
            this.menu.Controls.Add(this.panel3);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.btnInfoJugadores);
            this.menu.Controls.Add(this.btnInfoJuego);
            this.menu.Controls.Add(this.btnNuevoJuego);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(250, 608);
            this.menu.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panel4.Location = new System.Drawing.Point(0, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 66);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panel3.Location = new System.Drawing.Point(0, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 66);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panel2.Location = new System.Drawing.Point(0, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 54);
            this.panel2.TabIndex = 4;
            // 
            // btnInfoJugadores
            // 
            this.btnInfoJugadores.FlatAppearance.BorderSize = 0;
            this.btnInfoJugadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnInfoJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoJugadores.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoJugadores.Location = new System.Drawing.Point(0, 475);
            this.btnInfoJugadores.Name = "btnInfoJugadores";
            this.btnInfoJugadores.Size = new System.Drawing.Size(250, 66);
            this.btnInfoJugadores.TabIndex = 3;
            this.btnInfoJugadores.Text = "Información del\r\n Juego";
            this.btnInfoJugadores.UseVisualStyleBackColor = true;
            // 
            // btnInfoJuego
            // 
            this.btnInfoJuego.FlatAppearance.BorderSize = 0;
            this.btnInfoJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnInfoJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoJuego.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoJuego.Location = new System.Drawing.Point(0, 361);
            this.btnInfoJuego.Name = "btnInfoJuego";
            this.btnInfoJuego.Size = new System.Drawing.Size(250, 66);
            this.btnInfoJuego.TabIndex = 2;
            this.btnInfoJuego.Text = "Información de los\r\n Jugadores";
            this.btnInfoJuego.UseVisualStyleBackColor = true;
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.FlatAppearance.BorderSize = 0;
            this.btnNuevoJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnNuevoJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoJuego.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoJuego.Location = new System.Drawing.Point(0, 252);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(250, 54);
            this.btnNuevoJuego.TabIndex = 1;
            this.btnNuevoJuego.Text = "Nuevo Juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = true;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab3.Properties.Resources.amixsecreto_PhotoRoom_png_PhotoRoom;
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTituloIni
            // 
            this.lblTituloIni.AutoSize = true;
            this.lblTituloIni.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIni.Location = new System.Drawing.Point(309, 182);
            this.lblTituloIni.Name = "lblTituloIni";
            this.lblTituloIni.Size = new System.Drawing.Size(217, 31);
            this.lblTituloIni.TabIndex = 2;
            this.lblTituloIni.Text = "Amigo Secreto";
            this.lblTituloIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(50, 230);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(732, 17);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Con este programa puedes organizar tu amigo secreto, para comenzar selecciona \"Nu" +
    "evo Juego\".";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.panelMain.Controls.Add(this.lblInicio);
            this.panelMain.Controls.Add(this.lblTituloIni);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(822, 608);
            this.panelMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amigo Secreto";
            this.TopMost = true;
            
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInfoJugadores;
        private System.Windows.Forms.Button btnInfoJuego;
        private System.Windows.Forms.Button btnNuevoJuego;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituloIni;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Panel panelMain;
    }
}

