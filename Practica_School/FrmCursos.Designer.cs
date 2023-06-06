namespace Practica_School
{
    partial class FrmCursos
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
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.lbCursos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCursos
            // 
            this.dgCursos.AllowUserToAddRows = false;
            this.dgCursos.AllowUserToDeleteRows = false;
            this.dgCursos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgCursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Location = new System.Drawing.Point(13, 54);
            this.dgCursos.Margin = new System.Windows.Forms.Padding(4);
            this.dgCursos.MultiSelect = false;
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.ReadOnly = true;
            this.dgCursos.RowHeadersVisible = false;
            this.dgCursos.RowHeadersWidth = 51;
            this.dgCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCursos.Size = new System.Drawing.Size(498, 500);
            this.dgCursos.TabIndex = 32;
            // 
            // lbCursos
            // 
            this.lbCursos.AutoSize = true;
            this.lbCursos.BackColor = System.Drawing.Color.Orange;
            this.lbCursos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCursos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCursos.Location = new System.Drawing.Point(13, 16);
            this.lbCursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCursos.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbCursos.Size = new System.Drawing.Size(500, 34);
            this.lbCursos.TabIndex = 33;
            this.lbCursos.Text = "Cursos";
            this.lbCursos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 598);
            this.Controls.Add(this.dgCursos);
            this.Controls.Add(this.lbCursos);
            this.Name = "FrmCursos";
            this.Text = "FrmCursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCursos;
        private System.Windows.Forms.Label lbCursos;
    }
}