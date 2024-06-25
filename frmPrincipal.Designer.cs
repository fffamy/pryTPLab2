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
            dgvPuntaje = new DataGridView();
            stpBaseDeDatos = new StatusStrip();
            tstpConexionBD = new ToolStripStatusLabel();
            btnJugar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPuntaje).BeginInit();
            stpBaseDeDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPuntaje
            // 
            dgvPuntaje.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvPuntaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuntaje.GridColor = Color.Black;
            dgvPuntaje.Location = new Point(12, 66);
            dgvPuntaje.Name = "dgvPuntaje";
            dgvPuntaje.RowHeadersWidth = 51;
            dgvPuntaje.RowTemplate.Height = 29;
            dgvPuntaje.Size = new Size(303, 393);
            dgvPuntaje.TabIndex = 2;
            dgvPuntaje.CellContentClick += dgvPuntaje_CellContentClick;
            // 
            // stpBaseDeDatos
            // 
            stpBaseDeDatos.ImageScalingSize = new Size(20, 20);
            stpBaseDeDatos.Items.AddRange(new ToolStripItem[] { tstpConexionBD });
            stpBaseDeDatos.Location = new Point(0, 462);
            stpBaseDeDatos.Name = "stpBaseDeDatos";
            stpBaseDeDatos.Padding = new Padding(1, 0, 16, 0);
            stpBaseDeDatos.Size = new Size(327, 22);
            stpBaseDeDatos.TabIndex = 1;
            stpBaseDeDatos.Text = "statusStrip1";
            // 
            // tstpConexionBD
            // 
            tstpConexionBD.Name = "tstpConexionBD";
            tstpConexionBD.Size = new Size(0, 16);
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.Black;
            btnJugar.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnJugar.ForeColor = Color.Red;
            btnJugar.Location = new Point(103, 12);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(135, 46);
            btnJugar.TabIndex = 3;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(327, 484);
            Controls.Add(btnJugar);
            Controls.Add(dgvPuntaje);
            Controls.Add(stpBaseDeDatos);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPuntaje).EndInit();
            stpBaseDeDatos.ResumeLayout(false);
            stpBaseDeDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip stpBaseDeDatos;
        private ToolStripStatusLabel tstpConexionBD;
        private DataGridView dgvPuntaje;
        private Button btnJugar;
    }
}
