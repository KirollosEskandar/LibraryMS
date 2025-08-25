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

namespace LibraryMS.Author
{
    public partial class frmAddAuthor : Form
    {
        public frmAddAuthor()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddAuthor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxSearch.Text))
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

        private void personInfoContorl1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(LPersonID.Text == "??")
            {
                MessageBox.Show("Please Chose Person..");
                return; 
            }
            int id =  0;
            id = Convert.ToInt32(LPersonID.Text);
            
            if(clsAuthor.isExist(id))
            {
                MessageBox.Show("This Person is Add Before, Phease Chose Another Person..");
                return;
            }
            clsAuthor.Person_id = id;
            if(clsAuthor.AddAuthor())
            {
                MessageBox.Show("Add Done..");
                LAuthor.Text = Convert.ToString(clsAuthor.author_id);
            }
        }
    }
}
