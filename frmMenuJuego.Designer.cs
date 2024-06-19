namespace pryTPLab2
{
    partial class frmMenuJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuJuego));
            pctFondo = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pnlJugador = new Panel();
            txtNombre = new TextBox();
            lblJugador = new Label();
            lblSalir = new Label();
            ((System.ComponentModel.ISupportInitialize)pctFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlJugador.SuspendLayout();
            SuspendLayout();
            // 
            // pctFondo
            // 
            pctFondo.BackColor = Color.Black;
            pctFondo.Image = Properties.Resources.galaga_inicio;
            pctFondo.Location = new Point(-19, -11);
            pctFondo.Margin = new Padding(3, 4, 3, 4);
            pctFondo.Name = "pctFondo";
            pctFondo.Size = new Size(942, 611);
            pctFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFondo.TabIndex = 0;
            pctFondo.TabStop = false;
            pctFondo.Click += pctFondo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(330, 397);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(255, 172);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Location = new Point(330, -11);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(255, 97);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pnlJugador
            // 
            pnlJugador.BackColor = Color.Black;
            pnlJugador.Controls.Add(txtNombre);
            pnlJugador.Controls.Add(lblJugador);
            pnlJugador.Location = new Point(218, 295);
            pnlJugador.Margin = new Padding(3, 4, 3, 4);
            pnlJugador.Name = "pnlJugador";
            pnlJugador.Size = new Size(481, 65);
            pnlJugador.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Black;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(195, 27);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 22);
            txtNombre.TabIndex = 1;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Bauhaus 93", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugador.ForeColor = Color.White;
            lblJugador.Location = new Point(112, 25);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(77, 19);
            lblJugador.TabIndex = 0;
            lblJugador.Text = "Jugador :";
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.BackColor = Color.Black;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalir.ForeColor = Color.White;
            lblSalir.Location = new Point(877, 12);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(17, 20);
            lblSalir.TabIndex = 4;
            lblSalir.Text = "x";
            lblSalir.Click += lblSalir_Click;
            // 
            // frmMenuJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblSalir);
            Controls.Add(pnlJugador);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pctFondo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenuJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Galaga";
            ((System.ComponentModel.ISupportInitialize)pctFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlJugador.ResumeLayout(false);
            pnlJugador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctFondo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel pnlJugador;
        private Label lblJugador;
        private Label lblSalir;
        private TextBox txtNombre;
    }
}