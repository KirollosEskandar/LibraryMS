namespace LibraryMS.Author
{
    partial class frmAddAuthor
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LAuthor = new System.Windows.Forms.Label();
            this.LPersonID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.personInfoContorl1 = new LibraryMS.Controls.PersonInfoContorl();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 766);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.personInfoContorl1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxSearch);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1161, 717);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 257);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter ID";
            // 
            // TxSearch
            // 
            this.TxSearch.Location = new System.Drawing.Point(180, 20);
            this.TxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxSearch.Name = "TxSearch";
            this.TxSearch.Size = new System.Drawing.Size(341, 30);
            this.TxSearch.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LAuthor);
            this.tabPage2.Controls.Add(this.LPersonID);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1161, 717);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Author";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LAuthor
            // 
            this.LAuthor.AutoSize = true;
            this.LAuthor.Location = new System.Drawing.Point(309, 144);
            this.LAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAuthor.Name = "LAuthor";
            this.LAuthor.Size = new System.Drawing.Size(49, 36);
            this.LAuthor.TabIndex = 6;
            this.LAuthor.Text = "??";
            // 
            // LPersonID
            // 
            this.LPersonID.AutoSize = true;
            this.LPersonID.Location = new System.Drawing.Point(309, 254);
            this.LPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPersonID.Name = "LPersonID";
            this.LPersonID.Size = new System.Drawing.Size(49, 36);
            this.LPersonID.TabIndex = 5;
            this.LPersonID.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Person Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author Id:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 361);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // personInfoContorl1
            // 
            this.personInfoContorl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.personInfoContorl1.Location = new System.Drawing.Point(14, 86);
            this.personInfoContorl1.Margin = new System.Windows.Forms.Padding(4);
            this.personInfoContorl1.Name = "personInfoContorl1";
            this.personInfoContorl1.Size = new System.Drawing.Size(569, 416);
            this.personInfoContorl1.TabIndex = 0;
            this.personInfoContorl1.Load += new System.EventHandler(this.personInfoContorl1_Load);
            // 
            // button1
            // 
            this.button1.Image = global::LibraryMS.Properties.Resources.Search__1_;
            this.button1.Location = new System.Drawing.Point(550, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 70);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 628);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAuthor";
            this.Load += new System.EventHandler(this.frmAddAuthor_Load);
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
        private Controls.PersonInfoContorl personInfoContorl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LAuthor;
        private System.Windows.Forms.Label LPersonID;
    }
}