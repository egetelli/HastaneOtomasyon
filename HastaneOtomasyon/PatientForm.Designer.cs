namespace HastaneOtomasyon
{
    partial class PatientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.PatAddress = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.PatId = new System.Windows.Forms.TextBox();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.BloodCb = new System.Windows.Forms.ComboBox();
            this.MajorTb = new System.Windows.Forms.TextBox();
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(421, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENT";
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
            // PatPhone
            // 
            this.PatPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.PatPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatPhone.Location = new System.Drawing.Point(54, 248);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(180, 29);
            this.PatPhone.TabIndex = 8;
            this.PatPhone.Text = "Patient Phone";
            this.PatPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatAddress
            // 
            this.PatAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.PatAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatAddress.Location = new System.Drawing.Point(54, 213);
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.Size = new System.Drawing.Size(180, 29);
            this.PatAddress.TabIndex = 7;
            this.PatAddress.Text = "Patient Adress";
            this.PatAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatName
            // 
            this.PatName.BackColor = System.Drawing.Color.Gainsboro;
            this.PatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatName.Location = new System.Drawing.Point(54, 178);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(180, 29);
            this.PatName.TabIndex = 6;
            this.PatName.Text = "Patient Name";
            this.PatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatId
            // 
            this.PatId.BackColor = System.Drawing.Color.Gainsboro;
            this.PatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatId.Location = new System.Drawing.Point(54, 143);
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(180, 29);
            this.PatId.TabIndex = 5;
            this.PatId.Text = "Patient ID";
            this.PatId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatAge
            // 
            this.PatAge.BackColor = System.Drawing.Color.Gainsboro;
            this.PatAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatAge.Location = new System.Drawing.Point(54, 283);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(180, 29);
            this.PatAge.TabIndex = 9;
            this.PatAge.Text = "Patient Age";
            this.PatAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenderCb
            // 
            this.GenderCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(54, 318);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(180, 28);
            this.GenderCb.TabIndex = 10;
            this.GenderCb.Text = "Gender";
            // 
            // BloodCb
            // 
            this.BloodCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BloodCb.FormattingEnabled = true;
            this.BloodCb.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.BloodCb.Location = new System.Drawing.Point(54, 352);
            this.BloodCb.Name = "BloodCb";
            this.BloodCb.Size = new System.Drawing.Size(180, 28);
            this.BloodCb.TabIndex = 11;
            this.BloodCb.Text = "Blood Group";
            // 
            // MajorTb
            // 
            this.MajorTb.BackColor = System.Drawing.Color.Gainsboro;
            this.MajorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MajorTb.Location = new System.Drawing.Point(54, 386);
            this.MajorTb.Name = "MajorTb";
            this.MajorTb.Size = new System.Drawing.Size(180, 29);
            this.MajorTb.TabIndex = 12;
            this.MajorTb.Text = "Major Disease";
            this.MajorTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatientGV
            // 
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGV.Location = new System.Drawing.Point(279, 143);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.Size = new System.Drawing.Size(679, 408);
            this.PatientGV.TabIndex = 13;
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Tomato;
            this.button4.Location = new System.Drawing.Point(101, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 50);
            this.button4.TabIndex = 17;
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
            this.button3.Location = new System.Drawing.Point(190, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 50);
            this.button3.TabIndex = 16;
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
            this.button2.Location = new System.Drawing.Point(101, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 50);
            this.button2.TabIndex = 15;
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
            this.button1.Location = new System.Drawing.Point(12, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(527, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "PATIENTS LIST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(931, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.MajorTb);
            this.Controls.Add(this.BloodCb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.PatAddress);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.TextBox PatAddress;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox PatId;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.ComboBox BloodCb;
        private System.Windows.Forms.TextBox MajorTb;
        private System.Windows.Forms.DataGridView PatientGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}