namespace Practica_School
{
    partial class FrmAMBPersones
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
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbCognom = new System.Windows.Forms.TextBox();
            this.lbCognom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Tomato;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(405, 218);
            this.btNo.Margin = new System.Windows.Forms.Padding(4);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(128, 44);
            this.btNo.TabIndex = 22;
            this.btNo.Text = "&Descartar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(245, 218);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(128, 44);
            this.btOK.TabIndex = 21;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbCognom
            // 
            this.tbCognom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCognom.Location = new System.Drawing.Point(156, 73);
            this.tbCognom.Margin = new System.Windows.Forms.Padding(4);
            this.tbCognom.MaxLength = 100;
            this.tbCognom.Name = "tbCognom";
            this.tbCognom.Size = new System.Drawing.Size(540, 26);
            this.tbCognom.TabIndex = 20;
            // 
            // lbCognom
            // 
            this.lbCognom.AutoSize = true;
            this.lbCognom.BackColor = System.Drawing.Color.Gray;
            this.lbCognom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCognom.ForeColor = System.Drawing.Color.White;
            this.lbCognom.Location = new System.Drawing.Point(13, 74);
            this.lbCognom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCognom.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbCognom.Name = "lbCognom";
            this.lbCognom.Padding = new System.Windows.Forms.Padding(4);
            this.lbCognom.Size = new System.Drawing.Size(123, 26);
            this.lbCognom.TabIndex = 19;
            this.lbCognom.Text = "Cognom";
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(156, 23);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.MaxLength = 10;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(540, 26);
            this.tbNom.TabIndex = 18;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.Gray;
            this.lbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(13, 25);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(4);
            this.lbNom.Size = new System.Drawing.Size(100, 26);
            this.lbNom.TabIndex = 17;
            this.lbNom.Text = "Nom";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.Gray;
            this.lbData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.White;
            this.lbData.Location = new System.Drawing.Point(13, 129);
            this.lbData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbData.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbData.Name = "lbData";
            this.lbData.Padding = new System.Windows.Forms.Padding(4);
            this.lbData.Size = new System.Drawing.Size(143, 26);
            this.lbData.TabIndex = 23;
            this.lbData.Text = "Data Matriculació";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(179, 133);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(327, 22);
            this.dtpData.TabIndex = 24;
            // 
            // FrmAMBPersones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 301);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbCognom);
            this.Controls.Add(this.lbCognom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Name = "FrmAMBPersones";
            this.Text = "FrmAMBEstudiants";
            this.Load += new System.EventHandler(this.FrmAMBPersones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbCognom;
        private System.Windows.Forms.Label lbCognom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}