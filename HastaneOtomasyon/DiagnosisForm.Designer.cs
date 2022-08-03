namespace HastaneOtomasyon
{
    partial class DiagnosisForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagnosisTb = new System.Windows.Forms.TextBox();
            this.SymptomsTb = new System.Windows.Forms.TextBox();
            this.PatNameTb = new System.Windows.Forms.TextBox();
            this.DiagId = new System.Windows.Forms.TextBox();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.MedicineTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DiagnosisGV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(931, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(421, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(299, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.BackColor = System.Drawing.Color.Gainsboro;
            this.DiagnosisTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DiagnosisTb.Location = new System.Drawing.Point(522, 163);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(180, 29);
            this.DiagnosisTb.TabIndex = 12;
            this.DiagnosisTb.Text = "Diagnosis";
            this.DiagnosisTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.BackColor = System.Drawing.Color.Gainsboro;
            this.SymptomsTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SymptomsTb.Location = new System.Drawing.Point(522, 119);
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.Size = new System.Drawing.Size(180, 29);
            this.SymptomsTb.TabIndex = 11;
            this.SymptomsTb.Text = "Symptoms";
            this.SymptomsTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatNameTb
            // 
            this.PatNameTb.BackColor = System.Drawing.Color.Gainsboro;
            this.PatNameTb.Enabled = false;
            this.PatNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatNameTb.Location = new System.Drawing.Point(295, 207);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.Size = new System.Drawing.Size(180, 29);
            this.PatNameTb.TabIndex = 10;
            this.PatNameTb.Text = "Patient Name";
            this.PatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiagId
            // 
            this.DiagId.BackColor = System.Drawing.Color.Gainsboro;
            this.DiagId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DiagId.Location = new System.Drawing.Point(295, 119);
            this.DiagId.Name = "DiagId";
            this.DiagId.Size = new System.Drawing.Size(180, 29);
            this.DiagId.TabIndex = 9;
            this.DiagId.Text = "Diagnosis ID";
            this.DiagId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Location = new System.Drawing.Point(295, 164);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(180, 28);
            this.PatientIdCb.TabIndex = 13;
            this.PatientIdCb.Text = "Patient ID";
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // MedicineTb
            // 
            this.MedicineTb.BackColor = System.Drawing.Color.Gainsboro;
            this.MedicineTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedicineTb.Location = new System.Drawing.Point(522, 208);
            this.MedicineTb.Name = "MedicineTb";
            this.MedicineTb.Size = new System.Drawing.Size(180, 29);
            this.MedicineTb.TabIndex = 14;
            this.MedicineTb.Text = "Medicines";
            this.MedicineTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Tomato;
            this.button4.Location = new System.Drawing.Point(449, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 50);
            this.button4.TabIndex = 21;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(549, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 50);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(449, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(350, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiagnosisGV
            // 
            this.DiagnosisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosisGV.Location = new System.Drawing.Point(190, 402);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.Size = new System.Drawing.Size(644, 158);
            this.DiagnosisGV.TabIndex = 22;
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(406, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 27);
            this.label9.TabIndex = 24;
            this.label9.Text = "DIAGNOSIS LIST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Return To Log-In Page";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(68, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 37);
            this.label5.TabIndex = 27;
            this.label5.Text = "☚";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 572);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicineTb);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.PatNameTb);
            this.Controls.Add(this.DiagId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiagnosisTb;
        private System.Windows.Forms.TextBox SymptomsTb;
        private System.Windows.Forms.TextBox PatNameTb;
        private System.Windows.Forms.TextBox DiagId;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private System.Windows.Forms.TextBox MedicineTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DiagnosisGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}