namespace Ganther_FCG
{
    partial class winMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFileName = new TextBox();
            txtFileSize = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnExit = new Button();
            btnRemove = new Button();
            lstSectors = new ListBox();
            chkHidden = new CheckBox();
            chkReadOnly = new CheckBox();
            txtStatusLine = new TextBox();
            label3 = new Label();
            txtSectorSize = new TextBox();
            lblFileCount = new Label();
            lstFileSystem = new ListBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "File Name";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(11, 75);
            txtFileName.Margin = new Padding(2);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(106, 23);
            txtFileName.TabIndex = 1;
            txtFileName.TextChanged += txtFileName_TextChanged;
            // 
            // txtFileSize
            // 
            txtFileSize.Location = new Point(11, 119);
            txtFileSize.Margin = new Padding(2);
            txtFileSize.Name = "txtFileSize";
            txtFileSize.Size = new Size(106, 23);
            txtFileSize.TabIndex = 3;
            txtFileSize.TextChanged += txtFileSize_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "File Size";
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(297, 154);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 25);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(16, 245);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 27);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit Program";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(297, 193);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(113, 25);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstSectors
            // 
            lstSectors.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lstSectors.FormattingEnabled = true;
            lstSectors.ItemHeight = 14;
            lstSectors.Items.AddRange(new object[] { "", "", "", "", " ", "", "", "", "" });
            lstSectors.Location = new Point(471, 7);
            lstSectors.Margin = new Padding(2);
            lstSectors.Name = "lstSectors";
            lstSectors.SelectionMode = SelectionMode.None;
            lstSectors.Size = new Size(299, 312);
            lstSectors.TabIndex = 7;
            lstSectors.SelectedIndexChanged += lstSectors_SelectedIndexChanged;
            // 
            // chkHidden
            // 
            chkHidden.AutoSize = true;
            chkHidden.Location = new Point(11, 160);
            chkHidden.Margin = new Padding(2);
            chkHidden.Name = "chkHidden";
            chkHidden.Size = new Size(65, 19);
            chkHidden.TabIndex = 8;
            chkHidden.Text = "Hidden";
            chkHidden.UseVisualStyleBackColor = true;
            // 
            // chkReadOnly
            // 
            chkReadOnly.AutoSize = true;
            chkReadOnly.Location = new Point(11, 181);
            chkReadOnly.Margin = new Padding(2);
            chkReadOnly.Name = "chkReadOnly";
            chkReadOnly.Size = new Size(80, 19);
            chkReadOnly.TabIndex = 9;
            chkReadOnly.Text = "Read Only";
            chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // txtStatusLine
            // 
            txtStatusLine.Location = new Point(12, 307);
            txtStatusLine.Margin = new Padding(2);
            txtStatusLine.Name = "txtStatusLine";
            txtStatusLine.Size = new Size(418, 23);
            txtStatusLine.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 12);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = "Sector Size";
            // 
            // txtSectorSize
            // 
            txtSectorSize.Location = new Point(75, 11);
            txtSectorSize.Margin = new Padding(2);
            txtSectorSize.Name = "txtSectorSize";
            txtSectorSize.Size = new Size(54, 23);
            txtSectorSize.TabIndex = 12;
            txtSectorSize.Text = "500";
            // 
            // lblFileCount
            // 
            lblFileCount.AutoSize = true;
            lblFileCount.Location = new Point(221, 15);
            lblFileCount.Margin = new Padding(2, 0, 2, 0);
            lblFileCount.Name = "lblFileCount";
            lblFileCount.Size = new Size(13, 15);
            lblFileCount.TabIndex = 13;
            lblFileCount.Text = "0";
            // 
            // lstFileSystem
            // 
            lstFileSystem.FormattingEnabled = true;
            lstFileSystem.ItemHeight = 15;
            lstFileSystem.Location = new Point(242, 15);
            lstFileSystem.Name = "lstFileSystem";
            lstFileSystem.SelectionMode = SelectionMode.MultiSimple;
            lstFileSystem.Size = new Size(188, 124);
            lstFileSystem.TabIndex = 14;
            lstFileSystem.SelectedIndexChanged += lstFileSystem_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Items.AddRange(new object[] { " 1", " 2  ", " 3", " 4", " 5", " 6 ", " 7 ", " 8 ", " 9 ", "10", "11 ", "12 ", "13 ", "14 ", "15 ", "16 ", "17 ", "18 ", "19 ", "20 " });
            listBox1.Location = new Point(444, 7);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(26, 312);
            listBox1.TabIndex = 15;
            // 
            // winMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(781, 347);
            Controls.Add(listBox1);
            Controls.Add(lstFileSystem);
            Controls.Add(lblFileCount);
            Controls.Add(txtSectorSize);
            Controls.Add(label3);
            Controls.Add(txtStatusLine);
            Controls.Add(chkReadOnly);
            Controls.Add(chkHidden);
            Controls.Add(lstSectors);
            Controls.Add(btnRemove);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(txtFileSize);
            Controls.Add(label2);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "winMain";
            Text = "CmpSc 472 - File Allocation Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private TextBox txtFileSize;
        private Label label2;
        private Button btnAdd;
        private Button btnExit;
        private Button btnRemove;
        private ListBox lstSectors;
        private CheckBox chkHidden;
        private CheckBox chkReadOnly;
        private TextBox txtStatusLine;
        private Label label3;
        private TextBox txtSectorSize;
        private Label lblFileCount;
        private ListBox lstFileSystem;
        private ListBox listBox1;
    }
}