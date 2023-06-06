namespace Practica_School
{
    partial class FrmExpedients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgEstudiants = new System.Windows.Forms.DataGridView();
            this.lbEstudiants = new System.Windows.Forms.Label();
            this.cbNomAlumne = new System.Windows.Forms.ComboBox();
            this.btnBotoBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEstudiants
            // 
            this.dgEstudiants.AllowUserToAddRows = false;
            this.dgEstudiants.AllowUserToDeleteRows = false;
            this.dgEstudiants.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgEstudiants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEstudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstudiants.Location = new System.Drawing.Point(40, 102);
            this.dgEstudiants.Margin = new System.Windows.Forms.Padding(4);
            this.dgEstudiants.MultiSelect = false;
            this.dgEstudiants.Name = "dgEstudiants";
            this.dgEstudiants.ReadOnly = true;
            this.dgEstudiants.RowHeadersVisible = false;
            this.dgEstudiants.RowHeadersWidth = 51;
            this.dgEstudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstudiants.Size = new System.Drawing.Size(498, 500);
            this.dgEstudiants.TabIndex = 32;
            this.dgEstudiants.Visible = false;
            // 
            // lbEstudiants
            // 
            this.lbEstudiants.AutoSize = true;
            this.lbEstudiants.BackColor = System.Drawing.Color.Orange;
            this.lbEstudiants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEstudiants.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstudiants.Location = new System.Drawing.Point(40, 70);
            this.lbEstudiants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstudiants.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbEstudiants.Name = "lbEstudiants";
            this.lbEstudiants.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbEstudiants.Size = new System.Drawing.Size(500, 34);
            this.lbEstudiants.TabIndex = 33;
            this.lbEstudiants.Text = "Aqui anira el ";
            this.lbEstudiants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEstudiants.Visible = false;
            // 
            // cbNomAlumne
            // 
            this.cbNomAlumne.FormattingEnabled = true;
            this.cbNomAlumne.Location = new System.Drawing.Point(40, 23);
            this.cbNomAlumne.Name = "cbNomAlumne";
            this.cbNomAlumne.Size = new System.Drawing.Size(247, 24);
            this.cbNomAlumne.TabIndex = 34;
            // 
            // btnBotoBuscar
            // 
            this.btnBotoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBotoBuscar.Location = new System.Drawing.Point(335, 18);
            this.btnBotoBuscar.Name = "btnBotoBuscar";
            this.btnBotoBuscar.Size = new System.Drawing.Size(87, 32);
            this.btnBotoBuscar.TabIndex = 35;
            this.btnBotoBuscar.Text = "Busca";
            this.btnBotoBuscar.UseVisualStyleBackColor = false;
            this.btnBotoBuscar.Click += new System.EventHandler(this.btnBotoBuscar_Click);
            // 
            // FrmExpedients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 655);
            this.Controls.Add(this.btnBotoBuscar);
            this.Controls.Add(this.cbNomAlumne);
            this.Controls.Add(this.dgEstudiants);
            this.Controls.Add(this.lbEstudiants);
            this.Name = "FrmExpedients";
            this.Text = "FrmExpedients";
            this.Load += new System.EventHandler(this.FrmExpedients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEstudiants;
        private System.Windows.Forms.Label lbEstudiants;
        private System.Windows.Forms.ComboBox cbNomAlumne;
        private System.Windows.Forms.Button btnBotoBuscar;
    }
}