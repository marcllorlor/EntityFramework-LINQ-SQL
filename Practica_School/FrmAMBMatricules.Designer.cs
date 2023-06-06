namespace Practica_School
{
    partial class FrmAMBMatricules
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
            this.lbNomAlumne = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNomCurs = new System.Windows.Forms.ComboBox();
            this.cbNomAlumne = new System.Windows.Forms.ComboBox();
            this.nudNotaAlumne = new System.Windows.Forms.NumericUpDown();
            this.cbPosarNota = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotaAlumne)).BeginInit();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Tomato;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(331, 209);
            this.btNo.Margin = new System.Windows.Forms.Padding(4);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(128, 44);
            this.btNo.TabIndex = 30;
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
            this.btOK.Location = new System.Drawing.Point(171, 209);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(128, 44);
            this.btOK.TabIndex = 29;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbNomAlumne
            // 
            this.lbNomAlumne.AutoSize = true;
            this.lbNomAlumne.BackColor = System.Drawing.Color.Gray;
            this.lbNomAlumne.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomAlumne.ForeColor = System.Drawing.Color.White;
            this.lbNomAlumne.Location = new System.Drawing.Point(13, 58);
            this.lbNomAlumne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomAlumne.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbNomAlumne.Name = "lbNomAlumne";
            this.lbNomAlumne.Padding = new System.Windows.Forms.Padding(4);
            this.lbNomAlumne.Size = new System.Drawing.Size(123, 26);
            this.lbNomAlumne.TabIndex = 27;
            this.lbNomAlumne.Text = "Nom Alumne";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.Gray;
            this.lbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(25, 9);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(4);
            this.lbNom.Size = new System.Drawing.Size(100, 26);
            this.lbNom.TabIndex = 25;
            this.lbNom.Text = "Nom Curs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(123, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nota Alumne";
            // 
            // cbNomCurs
            // 
            this.cbNomCurs.FormattingEnabled = true;
            this.cbNomCurs.Location = new System.Drawing.Point(240, 12);
            this.cbNomCurs.Name = "cbNomCurs";
            this.cbNomCurs.Size = new System.Drawing.Size(190, 24);
            this.cbNomCurs.TabIndex = 32;
            // 
            // cbNomAlumne
            // 
            this.cbNomAlumne.FormattingEnabled = true;
            this.cbNomAlumne.Location = new System.Drawing.Point(240, 60);
            this.cbNomAlumne.Name = "cbNomAlumne";
            this.cbNomAlumne.Size = new System.Drawing.Size(190, 24);
            this.cbNomAlumne.TabIndex = 33;
            // 
            // nudNotaAlumne
            // 
            this.nudNotaAlumne.DecimalPlaces = 2;
            this.nudNotaAlumne.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudNotaAlumne.Location = new System.Drawing.Point(238, 120);
            this.nudNotaAlumne.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNotaAlumne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudNotaAlumne.Name = "nudNotaAlumne";
            this.nudNotaAlumne.Size = new System.Drawing.Size(120, 22);
            this.nudNotaAlumne.TabIndex = 34;
            // 
            // cbPosarNota
            // 
            this.cbPosarNota.AutoSize = true;
            this.cbPosarNota.Checked = true;
            this.cbPosarNota.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPosarNota.Location = new System.Drawing.Point(171, 120);
            this.cbPosarNota.Name = "cbPosarNota";
            this.cbPosarNota.Size = new System.Drawing.Size(61, 20);
            this.cbPosarNota.TabIndex = 35;
            this.cbPosarNota.Text = "Nota:";
            this.cbPosarNota.UseVisualStyleBackColor = true;
            this.cbPosarNota.CheckedChanged += new System.EventHandler(this.cbPosarNota_CheckedChanged);
            // 
            // FrmAMBMatricules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 298);
            this.Controls.Add(this.cbPosarNota);
            this.Controls.Add(this.nudNotaAlumne);
            this.Controls.Add(this.cbNomAlumne);
            this.Controls.Add(this.cbNomCurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbNomAlumne);
            this.Controls.Add(this.lbNom);
            this.Name = "FrmAMBMatricules";
            this.Text = "FrmAMBMatricules";
            this.Load += new System.EventHandler(this.FrmAMBMatricules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNotaAlumne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbNomAlumne;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNomCurs;
        private System.Windows.Forms.ComboBox cbNomAlumne;
        private System.Windows.Forms.NumericUpDown nudNotaAlumne;
        private System.Windows.Forms.CheckBox cbPosarNota;
    }
}