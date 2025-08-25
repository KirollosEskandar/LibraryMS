using LibraryMS.Author;
using LibraryMS.Member;
using LibraryMS.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void borrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople _frmListPeople = new frmListPeople();
            _frmListPeople.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmListPeople _frmListPeople = new frmListPeople();
            _frmListPeople.ShowDialog();

        }

        private void authorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAuthor FrmAuthor = new frmAuthor();
            FrmAuthor.ShowDialog();
        }

        private void memToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void athorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthor FrmAuthor = new frmAuthor();
            FrmAuthor.ShowDialog();

        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMember FrmMember = new frmMember();
            FrmMember.ShowDialog();
        }
    }
}
