namespace UniversityDBApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewStudents = new DataGridView();
            txtStudentID = new TextBox();
            txtSSN = new TextBox();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtGrade = new TextBox();
            txtDOB = new TextBox();
            txtPassword = new TextBox();
            lblStudentID = new Label();
            lblSSN = new Label();
            lblFName = new Label();
            lblLName = new Label();
            lblGrade = new Label();
            lblDOB = new Label();
            lblPassword = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnGenerateReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 150);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(760, 300);
            dataGridViewStudents.TabIndex = 0;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(120, 20);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(150, 27);
            txtStudentID.TabIndex = 1;
            // 
            // txtSSN
            // 
            txtSSN.Location = new Point(120, 50);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(150, 27);
            txtSSN.TabIndex = 2;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(120, 80);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(150, 27);
            txtFName.TabIndex = 3;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(120, 110);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(150, 27);
            txtLName.TabIndex = 4;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(400, 20);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(150, 27);
            txtGrade.TabIndex = 5;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(400, 50);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(150, 27);
            txtDOB.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(400, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 27);
            txtPassword.TabIndex = 7;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(12, 20);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(82, 20);
            lblStudentID.TabIndex = 8;
            lblStudentID.Text = "Student ID:";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(12, 50);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(39, 20);
            lblSSN.TabIndex = 9;
            lblSSN.Text = "SSN:";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(12, 80);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(83, 20);
            lblFName.TabIndex = 10;
            lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(12, 110);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(82, 20);
            lblLName.TabIndex = 11;
            lblLName.Text = "Last Name:";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(300, 20);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(52, 20);
            lblGrade.TabIndex = 12;
            lblGrade.Text = "Grade:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(300, 50);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(203, 20);
            lblDOB.TabIndex = 13;
            lblDOB.Text = "Date of Birth (YYYY-MM-DD):";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(300, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password:";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 460);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 30);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(122, 460);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(232, 460);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(342, 460);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(100, 30);
            btnGenerateReport.TabIndex = 18;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 503);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(lblPassword);
            Controls.Add(lblDOB);
            Controls.Add(lblGrade);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(lblSSN);
            Controls.Add(lblStudentID);
            Controls.Add(txtPassword);
            Controls.Add(txtDOB);
            Controls.Add(txtGrade);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtSSN);
            Controls.Add(txtStudentID);
            Controls.Add(dataGridViewStudents);
            Name = "Form1";
            Text = "University Management System";
            Load += new System.EventHandler(this.Form1_Load);
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private TextBox txtStudentID;
        private TextBox txtSSN;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtGrade;
        private TextBox txtDOB;
        private TextBox txtPassword;
        private Label lblStudentID;
        private Label lblSSN;
        private Label lblFName;
        private Label lblLName;
        private Label lblGrade;
        private Label lblDOB;
        private Label lblPassword;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnGenerateReport;
    }
}