namespace Practica_School
{
    partial class FrmEstudiants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiants));
            this.dgEstudiants = new System.Windows.Forms.DataGridView();
            this.lbEstudiants = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
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
            this.dgEstudiants.Location = new System.Drawing.Point(13, 45);
            this.dgEstudiants.Margin = new System.Windows.Forms.Padding(4);
            this.dgEstudiants.MultiSelect = false;
            this.dgEstudiants.Name = "dgEstudiants";
            this.dgEstudiants.ReadOnly = true;
            this.dgEstudiants.RowHeadersVisible = false;
            this.dgEstudiants.RowHeadersWidth = 51;
            this.dgEstudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstudiants.Size = new System.Drawing.Size(498, 500);
            this.dgEstudiants.TabIndex = 30;
            this.dgEstudiants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstudiants_CellDoubleClick);
            // 
            // lbEstudiants
            // 
            this.lbEstudiants.AutoSize = true;
            this.lbEstudiants.BackColor = System.Drawing.Color.Orange;
            this.lbEstudiants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEstudiants.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstudiants.Location = new System.Drawing.Point(13, 13);
            this.lbEstudiants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstudiants.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbEstudiants.Name = "lbEstudiants";
            this.lbEstudiants.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbEstudiants.Size = new System.Drawing.Size(500, 34);
            this.lbEstudiants.TabIndex = 31;
            this.lbEstudiants.Text = "Estudiants";
            this.lbEstudiants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.Location = new System.Drawing.Point(519, 471);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 29;
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btNou
            // 
            this.btNou.BackColor = System.Drawing.Color.Transparent;
            this.btNou.FlatAppearance.BorderSize = 0;
            this.btNou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNou.ForeColor = System.Drawing.Color.Transparent;
            this.btNou.Image = ((System.Drawing.Image)(resources.GetObject("btNou.Image")));
            this.btNou.Location = new System.Drawing.Point(519, 408);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 28;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // FrmEstudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 578);
            this.Controls.Add(this.dgEstudiants);
            this.Controls.Add(this.lbEstudiants);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Name = "FrmEstudiants";
            this.Text = "FrmEstudiants";
            this.Load += new System.EventHandler(this.FrmEstudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEstudiants;
        private System.Windows.Forms.Label lbEstudiants;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
    }
}