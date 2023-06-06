namespace Practica_School
{
    partial class FrmMain
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
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.gestióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrículesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesPerCursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestióToolStripMenuItem,
            this.consultesToolStripMenuItem});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(800, 28);
            this.mStrip.TabIndex = 0;
            this.mStrip.Text = "menuStrip1";
            // 
            // gestióToolStripMenuItem
            // 
            this.gestióToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantsToolStripMenuItem,
            this.matrículesToolStripMenuItem,
            this.notesPerCursToolStripMenuItem});
            this.gestióToolStripMenuItem.Name = "gestióToolStripMenuItem";
            this.gestióToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.gestióToolStripMenuItem.Text = "Gestió";
            // 
            // estudiantsToolStripMenuItem
            // 
            this.estudiantsToolStripMenuItem.Name = "estudiantsToolStripMenuItem";
            this.estudiantsToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.estudiantsToolStripMenuItem.Text = "Estudiants";
            this.estudiantsToolStripMenuItem.Click += new System.EventHandler(this.estudiantsToolStripMenuItem_Click);
            // 
            // matrículesToolStripMenuItem
            // 
            this.matrículesToolStripMenuItem.Name = "matrículesToolStripMenuItem";
            this.matrículesToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.matrículesToolStripMenuItem.Text = "Matrícules";
            this.matrículesToolStripMenuItem.Click += new System.EventHandler(this.matrículesToolStripMenuItem_Click);
            // 
            // notesPerCursToolStripMenuItem
            // 
            this.notesPerCursToolStripMenuItem.Name = "notesPerCursToolStripMenuItem";
            this.notesPerCursToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.notesPerCursToolStripMenuItem.Text = "Notes per curs";
            this.notesPerCursToolStripMenuItem.Click += new System.EventHandler(this.notesPerCursToolStripMenuItem_Click);
            // 
            // consultesToolStripMenuItem
            // 
            this.consultesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expedientsToolStripMenuItem,
            this.cursosToolStripMenuItem});
            this.consultesToolStripMenuItem.Name = "consultesToolStripMenuItem";
            this.consultesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultesToolStripMenuItem.Text = "Consultes";
            // 
            // expedientsToolStripMenuItem
            // 
            this.expedientsToolStripMenuItem.Name = "expedientsToolStripMenuItem";
            this.expedientsToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.expedientsToolStripMenuItem.Text = "Expedients";
            this.expedientsToolStripMenuItem.Click += new System.EventHandler(this.expedientsToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStrip;
            this.Name = "FrmMain";
            this.Text = "Pagina Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem gestióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrículesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesPerCursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
    }
}

