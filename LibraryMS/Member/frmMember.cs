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
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
            dataGridView1.DataSource = clsMember.GetAllMember();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMember_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddMember FrmAddMember = new frmAddMember();
            FrmAddMember.ShowDialog();
        }
    }
}
