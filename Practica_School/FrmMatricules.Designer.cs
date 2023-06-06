namespace Practica_School
{
    partial class FrmMatricules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatricules));
            this.dgMatricules = new System.Windows.Forms.DataGridView();
            this.lbMatricules = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatricules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMatricules
            // 
            this.dgMatricules.AllowUserToAddRows = false;
            this.dgMatricules.AllowUserToDeleteRows = false;
            this.dgMatricules.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgMatricules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMatricules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatricules.Location = new System.Drawing.Point(13, 46);
            this.dgMatricules.Margin = new System.Windows.Forms.Padding(4);
            this.dgMatricules.MultiSelect = false;
            this.dgMatricules.Name = "dgMatricules";
            this.dgMatricules.ReadOnly = true;
            this.dgMatricules.RowHeadersVisible = false;
            this.dgMatricules.RowHeadersWidth = 51;
            this.dgMatricules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMatricules.Size = new System.Drawing.Size(642, 500);
            this.dgMatricules.TabIndex = 34;
            this.dgMatricules.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMatricules_CellDoubleClick);
            // 
            // lbMatricules
            // 
            this.lbMatricules.AutoSize = true;
            this.lbMatricules.BackColor = System.Drawing.Color.Orange;
            this.lbMatricules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMatricules.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatricules.Location = new System.Drawing.Point(89, 9);
            this.lbMatricules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatricules.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbMatricules.Name = "lbMatricules";
            this.lbMatricules.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbMatricules.Size = new System.Drawing.Size(500, 34);
            this.lbMatricules.TabIndex = 35;
            this.lbMatricules.Text = "Matricules";
            this.lbMatricules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.Location = new System.Drawing.Point(663, 476);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 33;
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
            this.btNou.Location = new System.Drawing.Point(663, 413);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 32;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // FrmMatricules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 565);
            this.Controls.Add(this.dgMatricules);
            this.Controls.Add(this.lbMatricules);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Name = "FrmMatricules";
            this.Text = "FrmMatricules";
            this.Load += new System.EventHandler(this.FrmMatricules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMatricules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMatricules;
        private System.Windows.Forms.Label lbMatricules;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
    }
}