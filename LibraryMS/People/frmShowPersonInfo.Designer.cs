namespace LibraryMS.People
{
    partial class frmShowPersonInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.personInfoContorl1 = new LibraryMS.Controls.PersonInfoContorl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(129, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informtion:";
            // 
            // personInfoContorl1
            // 
            this.personInfoContorl1.Location = new System.Drawing.Point(39, 112);
            this.personInfoContorl1.Name = "personInfoContorl1";
            this.personInfoContorl1.Size = new System.Drawing.Size(521, 514);
            this.personInfoContorl1.TabIndex = 0;
            this.personInfoContorl1.Load += new System.EventHandler(this.personInfoContorl1_Load);
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personInfoContorl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmShowPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmShowPersonInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PersonInfoContorl personInfoContorl1;
        private System.Windows.Forms.Label label1;
    }
}