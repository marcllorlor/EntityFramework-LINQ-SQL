namespace Practica_School
{
    partial class FrmNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            this.btnBotoBuscar = new System.Windows.Forms.Button();
            this.cbNomAssignatura = new System.Windows.Forms.ComboBox();
            this.dgEstudiants = new System.Windows.Forms.DataGridView();
            this.lbNomAssignatura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiants)).BeginInit();
            this.SuspendLayout();
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.Location = new System.Drawing.Point(519, 470);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 37;
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Visible = false;
            // 
            // btNou
            // 
            this.btNou.BackColor = System.Drawing.Color.Transparent;
            this.btNou.FlatAppearance.BorderSize = 0;
            this.btNou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNou.ForeColor = System.Drawing.Color.Transparent;
            this.btNou.Image = ((System.Drawing.Image)(resources.GetObject("btNou.Image")));
            this.btNou.Location = new System.Drawing.Point(519, 407);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 36;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Visible = false;
            // 
            // btnBotoBuscar
            // 
            this.btnBotoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBotoBuscar.Location = new System.Drawing.Point(308, 10);
            this.btnBotoBuscar.Name = "btnBotoBuscar";
            this.btnBotoBuscar.Size = new System.Drawing.Size(87, 32);
            this.btnBotoBuscar.TabIndex = 41;
            this.btnBotoBuscar.Text = "Busca";
            this.btnBotoBuscar.UseVisualStyleBackColor = false;
            this.btnBotoBuscar.Click += new System.EventHandler(this.btnBotoBuscar_Click);
            // 
            // cbNomAssignatura
            // 
            this.cbNomAssignatura.FormattingEnabled = true;
            this.cbNomAssignatura.Location = new System.Drawing.Point(13, 15);
            this.cbNomAssignatura.Name = "cbNomAssignatura";
            this.cbNomAssignatura.Size = new System.Drawing.Size(247, 24);
            this.cbNomAssignatura.TabIndex = 40;
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
            this.dgEstudiants.Location = new System.Drawing.Point(13, 94);
            this.dgEstudiants.Margin = new System.Windows.Forms.Padding(4);
            this.dgEstudiants.MultiSelect = false;
            this.dgEstudiants.Name = "dgEstudiants";
            this.dgEstudiants.ReadOnly = true;
            this.dgEstudiants.RowHeadersVisible = false;
            this.dgEstudiants.RowHeadersWidth = 51;
            this.dgEstudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstudiants.Size = new System.Drawing.Size(498, 500);
            this.dgEstudiants.TabIndex = 38;
            this.dgEstudiants.Visible = false;
            // 
            // lbNomAssignatura
            // 
            this.lbNomAssignatura.AutoSize = true;
            this.lbNomAssignatura.BackColor = System.Drawing.Color.Orange;
            this.lbNomAssignatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNomAssignatura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomAssignatura.Location = new System.Drawing.Point(13, 62);
            this.lbNomAssignatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomAssignatura.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbNomAssignatura.Name = "lbNomAssignatura";
            this.lbNomAssignatura.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbNomAssignatura.Size = new System.Drawing.Size(500, 34);
            this.lbNomAssignatura.TabIndex = 39;
            this.lbNomAssignatura.Text = "Aqui anira el ";
            this.lbNomAssignatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNomAssignatura.Visible = false;
            // 
            // FrmNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 616);
            this.Controls.Add(this.btnBotoBuscar);
            this.Controls.Add(this.cbNomAssignatura);
            this.Controls.Add(this.dgEstudiants);
            this.Controls.Add(this.lbNomAssignatura);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Name = "FrmNotes";
            this.Text = "FrmNotes";
            this.Load += new System.EventHandler(this.FrmNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
        private System.Windows.Forms.Button btnBotoBuscar;
        private System.Windows.Forms.ComboBox cbNomAssignatura;
        private System.Windows.Forms.DataGridView dgEstudiants;
        private System.Windows.Forms.Label lbNomAssignatura;
    }
}