namespace Lab3
{
    partial class nJuego
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
            this.pCantJ = new System.Windows.Forms.Panel();
            this.pInfoJuego = new System.Windows.Forms.Panel();
            this.txbValRegalo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbValEndulzadas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fechaFinJ = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.fechaIniJ = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfJue = new System.Windows.Forms.Button();
            this.txbEndulzadas = new System.Windows.Forms.TextBox();
            this.lblEndul = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.txbEndulzada = new System.Windows.Forms.TextBox();
            this.txbRegalo = new System.Windows.Forms.TextBox();
            this.btnInfJuga = new System.Windows.Forms.Button();
            this.pJugInfo = new System.Windows.Forms.Panel();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pCantJ.SuspendLayout();
            this.pInfoJuego.SuspendLayout();
            this.pJugInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(307, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear un nuevo juego";
            // 
            // lblCantJugadores
            // 
            this.lblCantJugadores.AutoSize = true;
            this.lblCantJugadores.BackColor = System.Drawing.Color.Transparent;
            this.lblCantJugadores.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantJugadores.Location = new System.Drawing.Point(20, 23);
            this.lblCantJugadores.Name = "lblCantJugadores";
            this.lblCantJugadores.Size = new System.Drawing.Size(239, 17);
            this.lblCantJugadores.TabIndex = 1;
            this.lblCantJugadores.Text = "¿Cuantas personas van a jugar?";
            // 
            // txtCantJugadores
            // 
            this.txtCantJugadores.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantJugadores.Location = new System.Drawing.Point(83, 52);
            this.txtCantJugadores.Name = "txtCantJugadores";
            this.txtCantJugadores.Size = new System.Drawing.Size(111, 25);
            this.txtCantJugadores.TabIndex = 2;
            // 
            // btnCantJugadores
            // 
            this.btnCantJugadores.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantJugadores.Location = new System.Drawing.Point(102, 83);
            this.btnCantJugadores.Name = "btnCantJugadores";
            this.btnCantJugadores.Size = new System.Drawing.Size(75, 33);
            this.btnCantJugadores.TabIndex = 3;
            this.btnCantJugadores.Text = "Enviar";
            this.btnCantJugadores.UseVisualStyleBackColor = true;
            this.btnCantJugadores.Click += new System.EventHandler(this.btnCantJugadores_Click);
            // 
            // pCantJ
            // 
            this.pCantJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pCantJ.Controls.Add(this.btnCantJugadores);
            this.pCantJ.Controls.Add(this.txtCantJugadores);
            this.pCantJ.Controls.Add(this.lblCantJugadores);
            this.pCantJ.Location = new System.Drawing.Point(327, 80);
            this.pCantJ.Name = "pCantJ";
            this.pCantJ.Size = new System.Drawing.Size(280, 139);
            this.pCantJ.TabIndex = 4;
            // 
            // pInfoJuego
            // 
            this.pInfoJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pInfoJuego.Controls.Add(this.txbValRegalo);
            this.pInfoJuego.Controls.Add(this.label2);
            this.pInfoJuego.Controls.Add(this.txbValEndulzadas);
            this.pInfoJuego.Controls.Add(this.label11);
            this.pInfoJuego.Controls.Add(this.label9);
            this.pInfoJuego.Controls.Add(this.fechaFinJ);
            this.pInfoJuego.Controls.Add(this.label8);
            this.pInfoJuego.Controls.Add(this.fechaIniJ);
            this.pInfoJuego.Controls.Add(this.label7);
            this.pInfoJuego.Controls.Add(this.txbDias);
            this.pInfoJuego.Controls.Add(this.label1);
            this.pInfoJuego.Controls.Add(this.btnInfJue);
            this.pInfoJuego.Controls.Add(this.txbEndulzadas);
            this.pInfoJuego.Controls.Add(this.lblEndul);
            this.pInfoJuego.Location = new System.Drawing.Point(29, 77);
            this.pInfoJuego.Name = "pInfoJuego";
            this.pInfoJuego.Size = new System.Drawing.Size(401, 580);
            this.pInfoJuego.TabIndex = 12;
            this.pInfoJuego.Visible = false;
            // 
            // txbValRegalo
            // 
            this.txbValRegalo.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValRegalo.Location = new System.Drawing.Point(248, 243);
            this.txbValRegalo.Name = "txbValRegalo";
            this.txbValRegalo.Size = new System.Drawing.Size(111, 25);
            this.txbValRegalo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 51);
            this.label2.TabIndex = 20;
            this.label2.Text = "Valor del regalo\r\n\r\n\r\n";
            // 
            // txbValEndulzadas
            // 
            this.txbValEndulzadas.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValEndulzadas.Location = new System.Drawing.Point(66, 243);
            this.txbValEndulzadas.Name = "txbValEndulzadas";
            this.txbValEndulzadas.Size = new System.Drawing.Size(111, 25);
            this.txbValEndulzadas.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Valor de las endulzadas\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(77, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "INFORMACIÓN DEL JUEGO";
            // 
            // fechaFinJ
            // 
            this.fechaFinJ.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(53)))), ((int)(((byte)(157)))));
            this.fechaFinJ.Location = new System.Drawing.Point(60, 389);
            this.fechaFinJ.Name = "fechaFinJ";
            this.fechaFinJ.Size = new System.Drawing.Size(276, 22);
            this.fechaFinJ.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha del descubrimiento\n";
            // 
            // fechaIniJ
            // 
            this.fechaIniJ.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(53)))), ((int)(((byte)(157)))));
            this.fechaIniJ.Location = new System.Drawing.Point(60, 328);
            this.fechaIniJ.Name = "fechaIniJ";
            this.fechaIniJ.Size = new System.Drawing.Size(276, 22);
            this.fechaIniJ.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de inicio\r\n";
            // 
            // txbDias
            // 
            this.txbDias.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDias.Location = new System.Drawing.Point(135, 174);
            this.txbDias.Name = "txbDias";
            this.txbDias.Size = new System.Drawing.Size(111, 25);
            this.txbDias.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Cada cuanto se van a endulzar? (En días)\r\n\r\n";
            // 
            // btnInfJue
            // 
            this.btnInfJue.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfJue.Location = new System.Drawing.Point(22, 517);
            this.btnInfJue.Name = "btnInfJue";
            this.btnInfJue.Size = new System.Drawing.Size(115, 34);
            this.btnInfJue.TabIndex = 3;
            this.btnInfJue.Text = "Guardar";
            this.btnInfJue.UseVisualStyleBackColor = true;
            this.btnInfJue.Click += new System.EventHandler(this.btnInfJue_Click);
            // 
            // txbEndulzadas
            // 
            this.txbEndulzadas.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndulzadas.Location = new System.Drawing.Point(135, 105);
            this.txbEndulzadas.Name = "txbEndulzadas";
            this.txbEndulzadas.Size = new System.Drawing.Size(111, 25);
            this.txbEndulzadas.TabIndex = 2;
            // 
            // lblEndul
            // 
            this.lblEndul.AutoSize = true;
            this.lblEndul.BackColor = System.Drawing.Color.Transparent;
            this.lblEndul.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndul.Location = new System.Drawing.Point(42, 85);
            this.lblEndul.Name = "lblEndul";
            this.lblEndul.Size = new System.Drawing.Size(310, 17);
            this.lblEndul.TabIndex = 1;
            this.lblEndul.Text = "¿Con cuantas endulzadas quieren jugar?\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Regalo Ideal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endulzada Ideal";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.Location = new System.Drawing.Point(164, 87);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(82, 17);
            this.lblJugador.TabIndex = 1;
            this.lblJugador.Text = "Jugador 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // txbNombre
            // 
            this.txbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbNombre.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(47, 138);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(308, 25);
            this.txbNombre.TabIndex = 6;
            // 
            // txbCorreo
            // 
            this.txbCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbCorreo.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCorreo.Location = new System.Drawing.Point(47, 202);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(308, 25);
            this.txbCorreo.TabIndex = 7;
            // 
            // txbEndulzada
            // 
            this.txbEndulzada.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbEndulzada.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndulzada.Location = new System.Drawing.Point(47, 268);
            this.txbEndulzada.Multiline = true;
            this.txbEndulzada.Name = "txbEndulzada";
            this.txbEndulzada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbEndulzada.Size = new System.Drawing.Size(308, 72);
            this.txbEndulzada.TabIndex = 8;
            // 
            // txbRegalo
            // 
            this.txbRegalo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbRegalo.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegalo.Location = new System.Drawing.Point(47, 381);
            this.txbRegalo.Multiline = true;
            this.txbRegalo.Name = "txbRegalo";
            this.txbRegalo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbRegalo.Size = new System.Drawing.Size(308, 72);
            this.txbRegalo.TabIndex = 9;
            // 
            // btnInfJuga
            // 
            this.btnInfJuga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnInfJuga.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfJuga.Location = new System.Drawing.Point(47, 517);
            this.btnInfJuga.Name = "btnInfJuga";
            this.btnInfJuga.Size = new System.Drawing.Size(115, 34);
            this.btnInfJuga.TabIndex = 10;
            this.btnInfJuga.Text = "Guardar";
            this.btnInfJuga.UseVisualStyleBackColor = true;
            this.btnInfJuga.Click += new System.EventHandler(this.btnInfJuga_Click);
            // 
            // pJugInfo
            // 
            this.pJugInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pJugInfo.Controls.Add(this.btnAsignar);
            this.pJugInfo.Controls.Add(this.label10);
            this.pJugInfo.Controls.Add(this.btnInfJuga);
            this.pJugInfo.Controls.Add(this.txbRegalo);
            this.pJugInfo.Controls.Add(this.txbEndulzada);
            this.pJugInfo.Controls.Add(this.txbCorreo);
            this.pJugInfo.Controls.Add(this.txbNombre);
            this.pJugInfo.Controls.Add(this.label4);
            this.pJugInfo.Controls.Add(this.lblJugador);
            this.pJugInfo.Controls.Add(this.label5);
            this.pJugInfo.Controls.Add(this.label6);
            this.pJugInfo.Controls.Add(this.label3);
            this.pJugInfo.Location = new System.Drawing.Point(510, 77);
            this.pJugInfo.Name = "pJugInfo";
            this.pJugInfo.Size = new System.Drawing.Size(401, 580);
            this.pJugInfo.TabIndex = 11;
            this.pJugInfo.Visible = false;
            // 
            // btnAsignar
            // 
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btnAsignar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(202, 494);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(153, 57);
            this.btnAsignar.TabIndex = 12;
            this.btnAsignar.Text = "Asignar \r\nAmigos Secretos";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Visible = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(43, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(323, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "INFORMACIÓN DE LOS JUGADORES\r\n";
            // 
            // nJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1007, 684);
            this.Controls.Add(this.pCantJ);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pInfoJuego);
            this.Controls.Add(this.pJugInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nJuego";
            this.Text = "nuevoJuego";
            this.pCantJ.ResumeLayout(false);
            this.pCantJ.PerformLayout();
            this.pInfoJuego.ResumeLayout(false);
            this.pInfoJuego.PerformLayout();
            this.pJugInfo.ResumeLayout(false);
            this.pJugInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantJugadores;
        private System.Windows.Forms.TextBox txtCantJugadores;
        private System.Windows.Forms.Button btnCantJugadores;
        private System.Windows.Forms.Panel pCantJ;
        private System.Windows.Forms.Panel pInfoJuego;
        private System.Windows.Forms.Button btnInfJue;
        private System.Windows.Forms.TextBox txbEndulzadas;
        private System.Windows.Forms.Label lblEndul;
        private System.Windows.Forms.TextBox txbDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.TextBox txbEndulzada;
        private System.Windows.Forms.TextBox txbRegalo;
        private System.Windows.Forms.Button btnInfJuga;
        private System.Windows.Forms.Panel pJugInfo;
        private System.Windows.Forms.DateTimePicker fechaIniJ;
        private System.Windows.Forms.DateTimePicker fechaFinJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txbValRegalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbValEndulzadas;
        private System.Windows.Forms.Label label11;
    }
}