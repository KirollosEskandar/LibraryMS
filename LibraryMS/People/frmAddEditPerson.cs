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
    public partial class frmAddEditPerson : Form
    {
        clsPerson Person;
        public delegate void Refresh();
        public event Refresh refresh;
        public frmAddEditPerson()
        {
            InitializeComponent();
            Person = new clsPerson();
            ReSetDateByMode();
        }
        public frmAddEditPerson(int Person_Id)
        {
            InitializeComponent();
            Person = clsPerson.Find(Person_Id);
            ReSetDateByMode();
        }
        private void ReSetDateByMode()
        {
            if (Person.Mode == clsPerson.enMode.AddPerson)
            {
                LTitle.Text = "Add Person";
                LID.Text = "NoNe";
                TxEmail.Text = string.Empty;
                TxLastName.Text = string.Empty;
                TxFirstName.Text = string.Empty;
                TxPhone.Text = string.Empty;

            }
            else
            {
                LTitle.Text = "Update Person";

                LID.Text = Convert.ToString(Person.Id);
                TxEmail.Text = Person.Email;
                TxLastName.Text = Person.LastName;
                TxFirstName.Text = Person.FirstName;
                TxPhone.Text = Person.Phone;

            }
        }
        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            string FName = Convert.ToString(TxFirstName.Text);
            string LName = Convert.ToString(TxLastName.Text);
            string Email = Convert.ToString(TxEmail.Text);
            string Phone = Convert.ToString(TxPhone.Text);
            
            if(string.IsNullOrEmpty(Phone)
                || string.IsNullOrEmpty(FName)
                || string.IsNullOrEmpty(LName)
                || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("The field could not be left blank.");
                return;
            }


            Person.FirstName = FName;
            Person.LastName = LName;
            Person.Email = Email;
            Person.Phone = Phone;
            if(Person.Save())
            {
                LID.Text = Convert.ToString(Person.Id);

                if (Person.Mode == clsPerson.enMode.AddPerson)
                    MessageBox.Show("This active person has been added.");
                else
                    MessageBox.Show("This active person has been Updated.");

                refresh?.Invoke();
                Person.Mode = clsPerson.enMode.UpdatePerson;
                ReSetDateByMode();
            }
            else
            {
                MessageBox.Show("Maybe a technical error or network connection, contact the programmer");
            }
        }
    }
}
