namespace pryTPLab2
{
    partial class frmJuego
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuego));
            pctFondo = new PictureBox();
            pctNave = new PictureBox();
            lblContador = new Label();
            lblSalir = new Label();
            lblPausa = new Label();
            pnlPausa = new Panel();
            btnMenu = new Button();
            btnSalir = new Button();
            btnDespausar = new Button();
            pctLogo = new PictureBox();
            timerDetectarColision = new System.Windows.Forms.Timer(components);
            pctVidaUno = new PictureBox();
            pctVidaDos = new PictureBox();
            pctVidaTres = new PictureBox();
            pnlGameOver = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnReiniciar = new Button();
            pctGameOver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctNave).BeginInit();
            pnlPausa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaUno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaDos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaTres).BeginInit();
            pnlGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctGameOver).BeginInit();
            SuspendLayout();
            // 
            // pctFondo
            // 
            pctFondo.Dock = DockStyle.Fill;
            pctFondo.Image = Properties.Resources.galaga_espacio;
            pctFondo.Location = new Point(0, 0);
            pctFondo.Margin = new Padding(3, 4, 3, 4);
            pctFondo.Name = "pctFondo";
            pctFondo.Size = new Size(914, 600);
            pctFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFondo.TabIndex = 0;
            pctFondo.TabStop = false;
            // 
            // pctNave
            // 
            pctNave.BackColor = Color.Black;
            pctNave.Image = Properties.Resources.naveGalagaGod;
            pctNave.Location = new Point(438, 504);
            pctNave.Margin = new Padding(3, 4, 3, 4);
            pctNave.Name = "pctNave";
            pctNave.Size = new Size(77, 80);
            pctNave.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNave.TabIndex = 1;
            pctNave.TabStop = false;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.BackColor = Color.Black;
            lblContador.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblContador.ForeColor = Color.Lime;
            lblContador.Location = new Point(14, 16);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(77, 16);
            lblContador.TabIndex = 2;
            lblContador.Text = "Puntaje = ";
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.BackColor = Color.Black;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalir.ForeColor = Color.White;
            lblSalir.Location = new Point(874, 1);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(28, 32);
            lblSalir.TabIndex = 3;
            lblSalir.Text = "x";
            lblSalir.Click += lblSalir_Click;
            // 
            // lblPausa
            // 
            lblPausa.AutoSize = true;
            lblPausa.BackColor = Color.Black;
            lblPausa.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPausa.ForeColor = Color.Red;
            lblPausa.Location = new Point(795, 7);
            lblPausa.Name = "lblPausa";
            lblPausa.Size = new Size(73, 26);
            lblPausa.TabIndex = 4;
            lblPausa.Text = "Pausa";
            lblPausa.Click += lblPausa_Click;
            // 
            // pnlPausa
            // 
            pnlPausa.BackColor = Color.Black;
            pnlPausa.Controls.Add(btnMenu);
            pnlPausa.Controls.Add(btnSalir);
            pnlPausa.Controls.Add(btnDespausar);
            pnlPausa.Controls.Add(pctLogo);
            pnlPausa.Location = new Point(334, 99);
            pnlPausa.Margin = new Padding(3, 4, 3, 4);
            pnlPausa.Name = "pnlPausa";
            pnlPausa.Size = new Size(274, 348);
            pnlPausa.TabIndex = 5;
            pnlPausa.Visible = false;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Bauhaus 93", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(67, 223);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(138, 43);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Bauhaus 93", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(67, 279);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(138, 43);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Cerrar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnDespausar
            // 
            btnDespausar.Cursor = Cursors.Hand;
            btnDespausar.FlatStyle = FlatStyle.Flat;
            btnDespausar.Font = new Font("Bauhaus 93", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDespausar.ForeColor = Color.White;
            btnDespausar.Location = new Point(67, 167);
            btnDespausar.Margin = new Padding(3, 4, 3, 4);
            btnDespausar.Name = "btnDespausar";
            btnDespausar.Size = new Size(138, 43);
            btnDespausar.TabIndex = 1;
            btnDespausar.Text = "Despausar";
            btnDespausar.UseVisualStyleBackColor = true;
            btnDespausar.Click += btnDespausar_Click;
            // 
            // pctLogo
            // 
            pctLogo.Image = Properties.Resources.Galaga_logo_svg_Photoroom_png_Photoroom;
            pctLogo.Location = new Point(30, 24);
            pctLogo.Margin = new Padding(3, 4, 3, 4);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(215, 128);
            pctLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLogo.TabIndex = 0;
            pctLogo.TabStop = false;
            // 
            // timerDetectarColision
            // 
            timerDetectarColision.Enabled = true;
            // 
            // pctVidaUno
            // 
            pctVidaUno.Image = Properties.Resources.corazonBlanco;
            pctVidaUno.Location = new Point(14, 39);
            pctVidaUno.Margin = new Padding(3, 4, 3, 4);
            pctVidaUno.Name = "pctVidaUno";
            pctVidaUno.Size = new Size(43, 43);
            pctVidaUno.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVidaUno.TabIndex = 6;
            pctVidaUno.TabStop = false;
            // 
            // pctVidaDos
            // 
            pctVidaDos.Image = Properties.Resources.corazonBlanco;
            pctVidaDos.Location = new Point(64, 39);
            pctVidaDos.Margin = new Padding(3, 4, 3, 4);
            pctVidaDos.Name = "pctVidaDos";
            pctVidaDos.Size = new Size(43, 43);
            pctVidaDos.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVidaDos.TabIndex = 7;
            pctVidaDos.TabStop = false;
            // 
            // pctVidaTres
            // 
            pctVidaTres.Image = Properties.Resources.corazonBlanco;
            pctVidaTres.Location = new Point(114, 39);
            pctVidaTres.Margin = new Padding(3, 4, 3, 4);
            pctVidaTres.Name = "pctVidaTres";
            pctVidaTres.Size = new Size(43, 43);
            pctVidaTres.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVidaTres.TabIndex = 8;
            pctVidaTres.TabStop = false;
            // 
            // pnlGameOver
            // 
            pnlGameOver.Controls.Add(button2);
            pnlGameOver.Controls.Add(button1);
            pnlGameOver.Controls.Add(btnReiniciar);
            pnlGameOver.Controls.Add(pctGameOver);
            pnlGameOver.Location = new Point(268, 76);
            pnlGameOver.Margin = new Padding(3, 4, 3, 4);
            pnlGameOver.Name = "pnlGameOver";
            pnlGameOver.Size = new Size(445, 367);
            pnlGameOver.TabIndex = 9;
            pnlGameOver.Visible = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bauhaus 93", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(136, 293);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(177, 43);
            button2.TabIndex = 4;
            button2.Text = "Cerrar Juego";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bauhaus 93", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(136, 227);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(177, 43);
            button1.TabIndex = 4;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(136, 164);
            btnReiniciar.Margin = new Padding(3, 4, 3, 4);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(177, 45);
            btnReiniciar.TabIndex = 1;
            btnReiniciar.Text = "Volver a Intentarlo";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // pctGameOver
            // 
            pctGameOver.Enabled = false;
            pctGameOver.Image = Properties.Resources.gameOver;
            pctGameOver.Location = new Point(82, 24);
            pctGameOver.Margin = new Padding(3, 4, 3, 4);
            pctGameOver.Name = "pctGameOver";
            pctGameOver.Size = new Size(274, 117);
            pctGameOver.SizeMode = PictureBoxSizeMode.CenterImage;
            pctGameOver.TabIndex = 0;
            pctGameOver.TabStop = false;
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(914, 600);
            Controls.Add(lblContador);
            Controls.Add(pnlGameOver);
            Controls.Add(pctVidaTres);
            Controls.Add(pctVidaDos);
            Controls.Add(pctVidaUno);
            Controls.Add(lblSalir);
            Controls.Add(lblPausa);
            Controls.Add(pnlPausa);
            Controls.Add(pctNave);
            Controls.Add(pctFondo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galaga";
            KeyDown += frmJuego_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctNave).EndInit();
            pnlPausa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaUno).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaDos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaTres).EndInit();
            pnlGameOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctGameOver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctFondo;
        private PictureBox pctNave;
        private Label lblContador;
        private Label lblSalir;
        private Label lblPausa;
        private Panel pnlPausa;
        private Button btnDespausar;
        private PictureBox pctLogo;
        private Button btnMenu;
        private Button btnSalir;
        private System.Windows.Forms.Timer timerDetectarColision;
        private PictureBox pctVidaUno;
        private PictureBox pctVidaDos;
        private PictureBox pctVidaTres;
        private Panel pnlGameOver;
        private Button btnReiniciar;
        private PictureBox pctGameOver;
        private Button button2;
        private Button button1;
    }
}