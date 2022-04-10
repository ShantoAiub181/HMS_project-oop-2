
namespace HMS_project_oop_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagID = new System.Windows.Forms.TextBox();
            this.PatientIDCb = new System.Windows.Forms.ComboBox();
            this.PatientTb = new System.Windows.Forms.TextBox();
            this.SymptomsTb = new System.Windows.Forms.TextBox();
            this.DiagnosisTb = new System.Windows.Forms.TextBox();
            this.MedicineTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DiagnosisLbl = new System.Windows.Forms.Label();
            this.MediciensLbl = new System.Windows.Forms.Label();
            this.SymptomsLbl = new System.Windows.Forms.Label();
            this.PatientNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisGV = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 100);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(1195, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cyberdyne", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(495, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cyberdyne", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOSPITAL MANAGEMANT SYSTEM";
            // 
            // DiagID
            // 
            this.DiagID.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiagID.Location = new System.Drawing.Point(27, 155);
            this.DiagID.Name = "DiagID";
            this.DiagID.Size = new System.Drawing.Size(184, 26);
            this.DiagID.TabIndex = 3;
            this.DiagID.Text = "DiagnosisID";
            // 
            // PatientIDCb
            // 
            this.PatientIDCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientIDCb.FormattingEnabled = true;
            this.PatientIDCb.Location = new System.Drawing.Point(27, 187);
            this.PatientIDCb.Name = "PatientIDCb";
            this.PatientIDCb.Size = new System.Drawing.Size(184, 25);
            this.PatientIDCb.TabIndex = 8;
            this.PatientIDCb.Text = "PatientID";
            this.PatientIDCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIDCb_SelectionChangeCommitted);
            // 
            // PatientTb
            // 
            this.PatientTb.Enabled = false;
            this.PatientTb.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PatientTb.Location = new System.Drawing.Point(27, 218);
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.Size = new System.Drawing.Size(184, 26);
            this.PatientTb.TabIndex = 9;
            this.PatientTb.Text = "PatientName";
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SymptomsTb.Location = new System.Drawing.Point(258, 155);
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.Size = new System.Drawing.Size(184, 26);
            this.SymptomsTb.TabIndex = 10;
            this.SymptomsTb.Text = "Symptoms";
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiagnosisTb.Location = new System.Drawing.Point(258, 187);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(184, 26);
            this.DiagnosisTb.TabIndex = 11;
            this.DiagnosisTb.Text = "Diagnosis";
            // 
            // MedicineTb
            // 
            this.MedicineTb.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedicineTb.Location = new System.Drawing.Point(258, 219);
            this.MedicineTb.Name = "MedicineTb";
            this.MedicineTb.Size = new System.Drawing.Size(184, 26);
            this.MedicineTb.TabIndex = 12;
            this.MedicineTb.Text = "Mediciens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cyberdyne", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(459, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "DIAGNOSIS LIST";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(188, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 45);
            this.button4.TabIndex = 21;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(284, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 45);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(188, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(88, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DiagnosisLbl);
            this.panel2.Controls.Add(this.MediciensLbl);
            this.panel2.Controls.Add(this.SymptomsLbl);
            this.panel2.Controls.Add(this.PatientNameLbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(619, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 357);
            this.panel2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(215, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Sahriyar&Team";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(160, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "HospitalManagementSystem\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(426, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 21);
            this.label9.TabIndex = 9;
            // 
            // DiagnosisLbl
            // 
            this.DiagnosisLbl.AutoSize = true;
            this.DiagnosisLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.DiagnosisLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DiagnosisLbl.Location = new System.Drawing.Point(298, 96);
            this.DiagnosisLbl.Name = "DiagnosisLbl";
            this.DiagnosisLbl.Size = new System.Drawing.Size(82, 21);
            this.DiagnosisLbl.TabIndex = 8;
            this.DiagnosisLbl.Text = "Diagnosis";
            // 
            // MediciensLbl
            // 
            this.MediciensLbl.AutoSize = true;
            this.MediciensLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.MediciensLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MediciensLbl.Location = new System.Drawing.Point(298, 151);
            this.MediciensLbl.Name = "MediciensLbl";
            this.MediciensLbl.Size = new System.Drawing.Size(98, 21);
            this.MediciensLbl.TabIndex = 7;
            this.MediciensLbl.Text = "Medicienes";
            // 
            // SymptomsLbl
            // 
            this.SymptomsLbl.AutoSize = true;
            this.SymptomsLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.SymptomsLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SymptomsLbl.Location = new System.Drawing.Point(77, 151);
            this.SymptomsLbl.Name = "SymptomsLbl";
            this.SymptomsLbl.Size = new System.Drawing.Size(90, 21);
            this.SymptomsLbl.TabIndex = 6;
            this.SymptomsLbl.Text = "Symptoms";
            // 
            // PatientNameLbl
            // 
            this.PatientNameLbl.AutoSize = true;
            this.PatientNameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.PatientNameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PatientNameLbl.Location = new System.Drawing.Point(77, 96);
            this.PatientNameLbl.Name = "PatientNameLbl";
            this.PatientNameLbl.Size = new System.Drawing.Size(115, 21);
            this.PatientNameLbl.TabIndex = 5;
            this.PatientNameLbl.Text = "PatientName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cyberdyne", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(95, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // DiagnosisGV
            // 
            this.DiagnosisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosisGV.Location = new System.Drawing.Point(38, 532);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowTemplate.Height = 25;
            this.DiagnosisGV.Size = new System.Drawing.Size(1163, 194);
            this.DiagnosisGV.TabIndex = 23;
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(860, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 35);
            this.button5.TabIndex = 24;
            this.button5.Text = "PRINT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1235, 738);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MedicineTb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.PatientIDCb);
            this.Controls.Add(this.DiagID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiagID;
        private System.Windows.Forms.ComboBox PatientIDCb;
        private System.Windows.Forms.TextBox PatientTb;
        private System.Windows.Forms.TextBox SymptomsTb;
        private System.Windows.Forms.TextBox DiagnosisTb;
        private System.Windows.Forms.TextBox MedicineTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DiagnosisLbl;
        private System.Windows.Forms.Label MediciensLbl;
        private System.Windows.Forms.Label SymptomsLbl;
        private System.Windows.Forms.Label PatientNameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DiagnosisGV;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
    }
}