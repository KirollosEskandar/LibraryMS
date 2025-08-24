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

namespace LibraryMS.People
{
    public partial class frmListPeople : Form
    {

        public frmListPeople()
        {
            InitializeComponent();
            dataGridView1.DataSource = clsPerson.GetAllPerson();

        }
        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = clsPerson.GetAllPerson();

        }

        private void frmListPeople_Load()
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[4].Width = 260;


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            bool Deleted = clsPerson.DeletePerson(id);

            if (Deleted)
            {
                MessageBox.Show("The user has been deleted successfullyThe user has been deleted successfully");
                // Update dataGridView1
                dataGridView1.DataSource = clsPerson.GetAllPerson();

            }
            else
            {
                MessageBox.Show("You have an error, it may be technical. Contact the programmer.");
            }


        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson FrmAddEditPerson = new frmAddEditPerson();
            FrmAddEditPerson.refresh += RefreshDataGrid;
            FrmAddEditPerson.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmAddEditPerson frmEditPerson = new frmAddEditPerson(id);
            frmEditPerson.ShowDialog();
        }
    }
}
