namespace DatabaseManagementSystem
{
    partial class ISSUE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ISSUE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBookName = new System.Windows.Forms.ComboBox();
            this.tdpBookIssue = new System.Windows.Forms.DateTimePicker();
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblBookIssueDate = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentContactNo = new System.Windows.Forms.TextBox();
            this.txtStudentBatch = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentContactNo = new System.Windows.Forms.Label();
            this.lblStudentBatch = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIsbnNo = new System.Windows.Forms.TextBox();
            this.lblIsbnNo = new System.Windows.Forms.Label();
            this.imgStudent = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBookIssue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pnlRight);
            this.panel1.Controls.Add(this.pnlLeft);
            this.panel1.Controls.Add(this.pnlTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 682);
            this.panel1.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.cmbBookName);
            this.pnlRight.Controls.Add(this.tdpBookIssue);
            this.pnlRight.Controls.Add(this.btnIssue);
            this.pnlRight.Controls.Add(this.lblBookIssueDate);
            this.pnlRight.Controls.Add(this.lblBookName);
            this.pnlRight.Controls.Add(this.txtStudentEmail);
            this.pnlRight.Controls.Add(this.txtStudentContactNo);
            this.pnlRight.Controls.Add(this.txtStudentBatch);
            this.pnlRight.Controls.Add(this.txtFaculty);
            this.pnlRight.Controls.Add(this.txtStudentName);
            this.pnlRight.Controls.Add(this.lblStudentEmail);
            this.pnlRight.Controls.Add(this.lblStudentContactNo);
            this.pnlRight.Controls.Add(this.lblStudentBatch);
            this.pnlRight.Controls.Add(this.lblFaculty);
            this.pnlRight.Controls.Add(this.lblStudentName);
            this.pnlRight.Controls.Add(this.lblDetails);
            this.pnlRight.Location = new System.Drawing.Point(535, 90);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(573, 592);
            this.pnlRight.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(67, 555);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Maximum 3 books can be issued to one student.";
            // 
            // cmbBookName
            // 
            this.cmbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Items.AddRange(new object[] {
            "Database Management Studies",
            "Java",
            "C#",
            "C language",
            "Introduction to Computer Science"});
            this.cmbBookName.Location = new System.Drawing.Point(243, 343);
            this.cmbBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.Size = new System.Drawing.Size(292, 28);
            this.cmbBookName.TabIndex = 19;
            // 
            // tdpBookIssue
            // 
            this.tdpBookIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdpBookIssue.Location = new System.Drawing.Point(243, 394);
            this.tdpBookIssue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tdpBookIssue.Name = "tdpBookIssue";
            this.tdpBookIssue.Size = new System.Drawing.Size(292, 26);
            this.tdpBookIssue.TabIndex = 18;
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Brown;
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(217, 473);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(165, 49);
            this.btnIssue.TabIndex = 17;
            this.btnIssue.Text = "ISSUE";
            this.btnIssue.UseVisualStyleBackColor = false;
            // 
            // lblBookIssueDate
            // 
            this.lblBookIssueDate.AutoSize = true;
            this.lblBookIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIssueDate.Location = new System.Drawing.Point(45, 395);
            this.lblBookIssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookIssueDate.Name = "lblBookIssueDate";
            this.lblBookIssueDate.Size = new System.Drawing.Size(173, 20);
            this.lblBookIssueDate.TabIndex = 14;
            this.lblBookIssueDate.Text = "Book Issue Date      : ";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(45, 347);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(176, 20);
            this.lblBookName.TabIndex = 13;
            this.lblBookName.Text = "Book Name               :";
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.Location = new System.Drawing.Point(243, 298);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(292, 26);
            this.txtStudentEmail.TabIndex = 12;
            // 
            // txtStudentContactNo
            // 
            this.txtStudentContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentContactNo.Location = new System.Drawing.Point(243, 252);
            this.txtStudentContactNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentContactNo.Name = "txtStudentContactNo";
            this.txtStudentContactNo.Size = new System.Drawing.Size(292, 26);
            this.txtStudentContactNo.TabIndex = 11;
            // 
            // txtStudentBatch
            // 
            this.txtStudentBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentBatch.Location = new System.Drawing.Point(243, 207);
            this.txtStudentBatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentBatch.Name = "txtStudentBatch";
            this.txtStudentBatch.Size = new System.Drawing.Size(292, 26);
            this.txtStudentBatch.TabIndex = 10;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaculty.Location = new System.Drawing.Point(243, 160);
            this.txtFaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(292, 26);
            this.txtFaculty.TabIndex = 9;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(243, 113);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(292, 26);
            this.txtStudentName.TabIndex = 8;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.Location = new System.Drawing.Point(45, 302);
            this.lblStudentEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(178, 20);
            this.lblStudentEmail.TabIndex = 7;
            this.lblStudentEmail.Text = "Student Email            :";
            // 
            // lblStudentContactNo
            // 
            this.lblStudentContactNo.AutoSize = true;
            this.lblStudentContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentContactNo.Location = new System.Drawing.Point(45, 256);
            this.lblStudentContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentContactNo.Name = "lblStudentContactNo";
            this.lblStudentContactNo.Size = new System.Drawing.Size(165, 20);
            this.lblStudentContactNo.TabIndex = 6;
            this.lblStudentContactNo.Text = "Student Contact No :";
            // 
            // lblStudentBatch
            // 
            this.lblStudentBatch.AutoSize = true;
            this.lblStudentBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentBatch.Location = new System.Drawing.Point(45, 210);
            this.lblStudentBatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentBatch.Name = "lblStudentBatch";
            this.lblStudentBatch.Size = new System.Drawing.Size(175, 20);
            this.lblStudentBatch.TabIndex = 5;
            this.lblStudentBatch.Text = "Student Batch           :";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(45, 164);
            this.lblFaculty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(188, 20);
            this.lblFaculty.TabIndex = 4;
            this.lblFaculty.Text = "Faculty                        :";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(45, 117);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(170, 20);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Student Name          :";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDetails.Location = new System.Drawing.Point(211, 23);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(145, 35);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "DETAILS";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlLeft.Controls.Add(this.btnSearch);
            this.pnlLeft.Controls.Add(this.txtIsbnNo);
            this.pnlLeft.Controls.Add(this.lblIsbnNo);
            this.pnlLeft.Controls.Add(this.imgStudent);
            this.pnlLeft.Location = new System.Drawing.Point(0, 90);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(535, 592);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Brown;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(179, 384);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 49);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIsbnNo
            // 
            this.txtIsbnNo.Location = new System.Drawing.Point(263, 300);
            this.txtIsbnNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsbnNo.Name = "txtIsbnNo";
            this.txtIsbnNo.Size = new System.Drawing.Size(132, 22);
            this.txtIsbnNo.TabIndex = 2;
            // 
            // lblIsbnNo
            // 
            this.lblIsbnNo.AutoSize = true;
            this.lblIsbnNo.ForeColor = System.Drawing.Color.White;
            this.lblIsbnNo.Location = new System.Drawing.Point(144, 304);
            this.lblIsbnNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsbnNo.Name = "lblIsbnNo";
            this.lblIsbnNo.Size = new System.Drawing.Size(68, 17);
            this.lblIsbnNo.TabIndex = 1;
            this.lblIsbnNo.Text = "ISBN NO:";
            // 
            // imgStudent
            // 
            this.imgStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgStudent.BackgroundImage")));
            this.imgStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgStudent.Location = new System.Drawing.Point(179, 80);
            this.imgStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgStudent.Name = "imgStudent";
            this.imgStudent.Size = new System.Drawing.Size(165, 140);
            this.imgStudent.TabIndex = 0;
            this.imgStudent.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.lblBookIssue);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1108, 682);
            this.pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, -21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1071, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBookIssue
            // 
            this.lblBookIssue.AutoSize = true;
            this.lblBookIssue.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBookIssue.Location = new System.Drawing.Point(537, 25);
            this.lblBookIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookIssue.Name = "lblBookIssue";
            this.lblBookIssue.Size = new System.Drawing.Size(226, 38);
            this.lblBookIssue.TabIndex = 0;
            this.lblBookIssue.Text = "ISSUE BOOK";
            // 
            // ISSUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 682);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ISSUE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ISSUE_Load);
            this.panel1.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBookIssue;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIsbnNo;
        private System.Windows.Forms.Label lblIsbnNo;
        private System.Windows.Forms.PictureBox imgStudent;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentContactNo;
        private System.Windows.Forms.TextBox txtStudentBatch;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblStudentContactNo;
        private System.Windows.Forms.Label lblStudentBatch;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblBookIssueDate;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.DateTimePicker tdpBookIssue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}