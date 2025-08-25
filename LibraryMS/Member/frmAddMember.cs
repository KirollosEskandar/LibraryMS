using LibraryMS_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS.Member
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personInfoContorl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void LAuthor_Click(object sender, EventArgs e)
        {

        }

        private void LPersonID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxSearch.Text))
            { return; }


            int id = Convert.ToInt32(TxSearch.Text);
            
            if (!clsPerson.isExist(id))
            {
                MessageBox.Show("Person Not Found..");
                return;
            }

            personInfoContorl1.LoadPersonInfo(id);

            LPersonID.Text = Convert.ToString(id);

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (LPersonID.Text == "??")
            {
                MessageBox.Show("Please Chose Person..");
                return;
            }
            int id = 0;
            id = Convert.ToInt32(LPersonID.Text);

            if (clsMember.isExist(id))
            {
                MessageBox.Show("This Person is Add Before, Phease Chose Another Person..");
                return;
            }
            clsMember member = new clsMember();
            member.Person_id = id;
            member.Registration_date = DateTime.Now.Year;
            if (member._Save())
            {
                MessageBox.Show("Add Done..");
                LMember.Text = Convert.ToString(member.Member_id);
            }

        }
    }
}
