namespace DatabaseManagementSystem
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.btnCheckCopyNo = new System.Windows.Forms.Button();
            this.tdpBookReturn = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.tdpBookIssue = new System.Windows.Forms.DateTimePicker();
            this.lblBookIssueDate = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imgStudent = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBookIssue = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 524);
            this.panel1.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.dgvIssuedBooks);
            this.pnlRight.Controls.Add(this.btnAdd);
            this.pnlRight.Controls.Add(this.dgvBookDetails);
            this.pnlRight.Controls.Add(this.btnCheckCopyNo);
            this.pnlRight.Controls.Add(this.tdpBookReturn);
            this.pnlRight.Controls.Add(this.lblReturnDate);
            this.pnlRight.Controls.Add(this.tdpBookIssue);
            this.pnlRight.Controls.Add(this.lblBookIssueDate);
            this.pnlRight.Controls.Add(this.txtEmail);
            this.pnlRight.Controls.Add(this.txtContactNo);
            this.pnlRight.Controls.Add(this.txtISBN);
            this.pnlRight.Controls.Add(this.txtMemberName);
            this.pnlRight.Controls.Add(this.lblEmail);
            this.pnlRight.Controls.Add(this.lblContactNo);
            this.pnlRight.Controls.Add(this.lblISBN);
            this.pnlRight.Controls.Add(this.lblMemberName);
            this.pnlRight.Controls.Add(this.btnIssue);
            this.pnlRight.Controls.Add(this.lblDetails);
            this.pnlRight.Location = new System.Drawing.Point(401, 73);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(669, 451);
            this.pnlRight.TabIndex = 2;
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.AllowUserToAddRows = false;
            this.dgvBookDetails.AllowUserToDeleteRows = false;
            this.dgvBookDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvBookDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBookDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBookDetails.Location = new System.Drawing.Point(6, 217);
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.Size = new System.Drawing.Size(494, 83);
            this.dgvBookDetails.TabIndex = 42;
            // 
            // btnCheckCopyNo
            // 
            this.btnCheckCopyNo.BackColor = System.Drawing.Color.Brown;
            this.btnCheckCopyNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCopyNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckCopyNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCopyNo.ForeColor = System.Drawing.Color.White;
            this.btnCheckCopyNo.Location = new System.Drawing.Point(468, 178);
            this.btnCheckCopyNo.Name = "btnCheckCopyNo";
            this.btnCheckCopyNo.Size = new System.Drawing.Size(57, 23);
            this.btnCheckCopyNo.TabIndex = 41;
            this.btnCheckCopyNo.Text = "Check";
            this.btnCheckCopyNo.UseVisualStyleBackColor = false;
            this.btnCheckCopyNo.Click += new System.EventHandler(this.btnCheckCopyNo_Click);
            // 
            // tdpBookReturn
            // 
            this.tdpBookReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tdpBookReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdpBookReturn.Location = new System.Drawing.Point(222, 344);
            this.tdpBookReturn.Name = "tdpBookReturn";
            this.tdpBookReturn.Size = new System.Drawing.Size(220, 22);
            this.tdpBookReturn.TabIndex = 40;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(74, 345);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(141, 16);
            this.lblReturnDate.TabIndex = 39;
            this.lblReturnDate.Text = "Book Return Date       : ";
            // 
            // tdpBookIssue
            // 
            this.tdpBookIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tdpBookIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdpBookIssue.Location = new System.Drawing.Point(222, 306);
            this.tdpBookIssue.Name = "tdpBookIssue";
            this.tdpBookIssue.Size = new System.Drawing.Size(220, 22);
            this.tdpBookIssue.TabIndex = 35;
            // 
            // lblBookIssueDate
            // 
            this.lblBookIssueDate.AutoSize = true;
            this.lblBookIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIssueDate.Location = new System.Drawing.Point(74, 307);
            this.lblBookIssueDate.Name = "lblBookIssueDate";
            this.lblBookIssueDate.Size = new System.Drawing.Size(140, 16);
            this.lblBookIssueDate.TabIndex = 34;
            this.lblBookIssueDate.Text = "Book Issue Date         : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(222, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(220, 22);
            this.txtEmail.TabIndex = 32;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(222, 106);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(220, 22);
            this.txtContactNo.TabIndex = 31;
            // 
            // txtISBN
            // 
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(222, 179);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(220, 22);
            this.txtISBN.TabIndex = 30;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(222, 68);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(220, 22);
            this.txtMemberName.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(74, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 16);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email                              :";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(74, 109);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(134, 16);
            this.lblContactNo.TabIndex = 27;
            this.lblContactNo.Text = "Contact No                   :";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(74, 182);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(135, 16);
            this.lblISBN.TabIndex = 26;
            this.lblISBN.Text = "ISBN                               :";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(74, 72);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(134, 16);
            this.lblMemberName.TabIndex = 25;
            this.lblMemberName.Text = "Member Name           :";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Brown;
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(278, 393);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(124, 40);
            this.btnIssue.TabIndex = 17;
            this.btnIssue.Text = "ISSUE";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDetails.Location = new System.Drawing.Point(289, 22);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(113, 26);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "DETAILS";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlLeft.Controls.Add(this.txtMemberID);
            this.pnlLeft.Controls.Add(this.lblMemberID);
            this.pnlLeft.Controls.Add(this.btnSearch);
            this.pnlLeft.Controls.Add(this.imgStudent);
            this.pnlLeft.Location = new System.Drawing.Point(0, 73);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(401, 451);
            this.pnlLeft.TabIndex = 1;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMemberID.Location = new System.Drawing.Point(192, 239);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtMemberID.TabIndex = 5;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.ForeColor = System.Drawing.Color.White;
            this.lblMemberID.Location = new System.Drawing.Point(103, 242);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(65, 13);
            this.lblMemberID.TabIndex = 4;
            this.lblMemberID.Text = "Member ID :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Brown;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(134, 312);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imgStudent
            // 
            this.imgStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgStudent.BackgroundImage")));
            this.imgStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgStudent.Location = new System.Drawing.Point(134, 65);
            this.imgStudent.Name = "imgStudent";
            this.imgStudent.Size = new System.Drawing.Size(124, 114);
            this.imgStudent.TabIndex = 0;
            this.imgStudent.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.btnCancel);
            this.pnlTop.Controls.Add(this.lblBookIssue);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1070, 524);
            this.pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1036, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBookIssue
            // 
            this.lblBookIssue.AutoSize = true;
            this.lblBookIssue.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBookIssue.Location = new System.Drawing.Point(475, 20);
            this.lblBookIssue.Name = "lblBookIssue";
            this.lblBookIssue.Size = new System.Drawing.Size(180, 31);
            this.lblBookIssue.TabIndex = 0;
            this.lblBookIssue.Text = "ISSUE BOOK";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Brown;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(565, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvIssuedBooks
            // 
            this.dgvIssuedBooks.AllowUserToAddRows = false;
            this.dgvIssuedBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvIssuedBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN});
            this.dgvIssuedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvIssuedBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvIssuedBooks.Location = new System.Drawing.Point(506, 217);
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.ReadOnly = true;
            this.dgvIssuedBooks.Size = new System.Drawing.Size(144, 95);
            this.dgvIssuedBooks.TabIndex = 45;
            this.dgvIssuedBooks.Visible = false;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "       ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 46;
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ISSUE_Load);
            this.panel1.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
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
        private System.Windows.Forms.PictureBox imgStudent;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker tdpBookReturn;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker tdpBookIssue;
        private System.Windows.Forms.Label lblBookIssueDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Button btnCheckCopyNo;
        private System.Windows.Forms.DataGridView dgvBookDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvIssuedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.Label label1;
    }
}