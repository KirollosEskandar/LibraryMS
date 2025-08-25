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
    public partial class frmAuthor : Form
    {
        public frmAuthor()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsAuthor.GetAllAuthor();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddAuthor FrmAddAuthor = new frmAddAuthor();
            FrmAddAuthor.ShowDialog();
        }
    }
}
