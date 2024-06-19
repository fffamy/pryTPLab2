namespace pryTPLab2
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            mnsPrincipal = new MenuStrip();
            mnsJuegos = new ToolStripMenuItem();
            mnsGalaga = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            stpBaseDeDatos = new StatusStrip();
            tstpConexionBD = new ToolStripStatusLabel();
            mnsPrincipal.SuspendLayout();
            stpBaseDeDatos.SuspendLayout();
            SuspendLayout();
            // 
            // mnsPrincipal
            // 
            mnsPrincipal.ImageScalingSize = new Size(20, 20);
            mnsPrincipal.Items.AddRange(new ToolStripItem[] { mnsJuegos, salirToolStripMenuItem });
            mnsPrincipal.Location = new Point(0, 0);
            mnsPrincipal.Name = "mnsPrincipal";
            mnsPrincipal.Padding = new Padding(7, 3, 0, 3);
            mnsPrincipal.Size = new Size(914, 30);
            mnsPrincipal.TabIndex = 0;
            mnsPrincipal.Text = "menuStrip1";
            // 
            // mnsJuegos
            // 
            mnsJuegos.DropDownItems.AddRange(new ToolStripItem[] { mnsGalaga });
            mnsJuegos.Name = "mnsJuegos";
            mnsJuegos.Size = new Size(68, 24);
            mnsJuegos.Text = "Juegos";
            // 
            // mnsGalaga
            // 
            mnsGalaga.Name = "mnsGalaga";
            mnsGalaga.Size = new Size(224, 26);
            mnsGalaga.Text = "Galaga";
            mnsGalaga.Click += mnsGalaga_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // stpBaseDeDatos
            // 
            stpBaseDeDatos.ImageScalingSize = new Size(20, 20);
            stpBaseDeDatos.Items.AddRange(new ToolStripItem[] { tstpConexionBD });
            stpBaseDeDatos.Location = new Point(0, 452);
            stpBaseDeDatos.Name = "stpBaseDeDatos";
            stpBaseDeDatos.Padding = new Padding(1, 0, 16, 0);
            stpBaseDeDatos.Size = new Size(914, 22);
            stpBaseDeDatos.TabIndex = 1;
            stpBaseDeDatos.Text = "statusStrip1";
            // 
            // tstpConexionBD
            // 
            tstpConexionBD.Name = "tstpConexionBD";
            tstpConexionBD.Size = new Size(0, 16);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_frmMenu;
            ClientSize = new Size(914, 474);
            Controls.Add(stpBaseDeDatos);
            Controls.Add(mnsPrincipal);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnsPrincipal;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            mnsPrincipal.ResumeLayout(false);
            mnsPrincipal.PerformLayout();
            stpBaseDeDatos.ResumeLayout(false);
            stpBaseDeDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsPrincipal;
        private ToolStripMenuItem mnsJuegos;
        private ToolStripMenuItem mnsGalaga;
        private StatusStrip stpBaseDeDatos;
        private ToolStripStatusLabel tstpConexionBD;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
