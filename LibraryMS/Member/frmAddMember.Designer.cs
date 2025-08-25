namespace LibraryMS.Member
{
    partial class frmAddMember
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.personInfoContorl1 = new LibraryMS.Controls.PersonInfoContorl();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LMember = new System.Windows.Forms.Label();
            this.LPersonID = new System.Windows.Forms.Label();
            this.LPerson = new System.Windows.Forms.Label();
            this.LMemberId = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.personInfoContorl1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 207);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // personInfoContorl1
            // 
            this.personInfoContorl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.personInfoContorl1.Location = new System.Drawing.Point(26, 62);
            this.personInfoContorl1.Margin = new System.Windows.Forms.Padding(4);
            this.personInfoContorl1.Name = "personInfoContorl1";
            this.personInfoContorl1.Size = new System.Drawing.Size(443, 336);
            this.personInfoContorl1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = global::LibraryMS.Properties.Resources.Search__1_;
            this.button1.Location = new System.Drawing.Point(498, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 70);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter ID";
            // 
            // TxSearch
            // 
            this.TxSearch.Location = new System.Drawing.Point(128, 20);
            this.TxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxSearch.Name = "TxSearch";
            this.TxSearch.Size = new System.Drawing.Size(341, 34);
            this.TxSearch.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LMember);
            this.tabPage2.Controls.Add(this.LPersonID);
            this.tabPage2.Controls.Add(this.LPerson);
            this.tabPage2.Controls.Add(this.LMemberId);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Member";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click_1);
            // 
            // LMember
            // 
            this.LMember.AutoSize = true;
            this.LMember.Location = new System.Drawing.Point(328, 95);
            this.LMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMember.Name = "LMember";
            this.LMember.Size = new System.Drawing.Size(37, 29);
            this.LMember.TabIndex = 11;
            this.LMember.Text = "??";
            // 
            // LPersonID
            // 
            this.LPersonID.AutoSize = true;
            this.LPersonID.Location = new System.Drawing.Point(328, 205);
            this.LPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPersonID.Name = "LPersonID";
            this.LPersonID.Size = new System.Drawing.Size(37, 29);
            this.LPersonID.TabIndex = 10;
            this.LPersonID.Text = "??";
            // 
            // LPerson
            // 
            this.LPerson.AutoSize = true;
            this.LPerson.Location = new System.Drawing.Point(174, 205);
            this.LPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPerson.Name = "LPerson";
            this.LPerson.Size = new System.Drawing.Size(122, 29);
            this.LPerson.TabIndex = 9;
            this.LPerson.Text = "Person Id:";
            // 
            // LMemberId
            // 
            this.LMemberId.AutoSize = true;
            this.LMemberId.Location = new System.Drawing.Point(174, 95);
            this.LMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMemberId.Name = "LMemberId";
            this.LMemberId.Size = new System.Drawing.Size(135, 29);
            this.LMemberId.TabIndex = 8;
            this.LMemberId.Text = "Member Id:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 312);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 64);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddMember";
            this.Text = "frmAddMember";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private Controls.PersonInfoContorl personInfoContorl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxSearch;
        private System.Windows.Forms.Label LPersonID;
        private System.Windows.Forms.Label LPerson;
        private System.Windows.Forms.Label LMemberId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LMember;
    }
}