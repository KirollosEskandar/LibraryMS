namespace LibraryMS.Controls
{
    partial class PersonInfoContorl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LID = new System.Windows.Forms.Label();
            this.LFirstName = new System.Windows.Forms.Label();
            this.LLastName = new System.Windows.Forms.Label();
            this.LPhone = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(38, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(38, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(38, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LID.Location = new System.Drawing.Point(95, 28);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(105, 39);
            this.LID.TabIndex = 6;
            this.LID.Text = "NoNe";
            // 
            // LFirstName
            // 
            this.LFirstName.AutoSize = true;
            this.LFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFirstName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LFirstName.Location = new System.Drawing.Point(185, 98);
            this.LFirstName.Name = "LFirstName";
            this.LFirstName.Size = new System.Drawing.Size(35, 39);
            this.LFirstName.TabIndex = 7;
            this.LFirstName.Text = "..";
            // 
            // LLastName
            // 
            this.LLastName.AutoSize = true;
            this.LLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLastName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LLastName.Location = new System.Drawing.Point(183, 160);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(35, 39);
            this.LLastName.TabIndex = 8;
            this.LLastName.Text = "..";
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPhone.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LPhone.Location = new System.Drawing.Point(133, 220);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(35, 39);
            this.LPhone.TabIndex = 9;
            this.LPhone.Text = "..";
            this.LPhone.Click += new System.EventHandler(this.LPhone_Click);
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LEmail.Location = new System.Drawing.Point(120, 281);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(35, 39);
            this.LEmail.TabIndex = 10;
            this.LEmail.Text = "..";
            // 
            // PersonInfoContorl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LPhone);
            this.Controls.Add(this.LLastName);
            this.Controls.Add(this.LFirstName);
            this.Controls.Add(this.LID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "PersonInfoContorl";
            this.Size = new System.Drawing.Size(517, 454);
            this.Load += new System.EventHandler(this.PersonInfoContorl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.Label LFirstName;
        private System.Windows.Forms.Label LLastName;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.Label LEmail;
    }
}
