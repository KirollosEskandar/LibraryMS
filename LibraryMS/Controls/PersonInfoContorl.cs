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

namespace LibraryMS.Controls
{
    public partial class PersonInfoContorl : UserControl
    {
        private clsPerson _Person;
        public PersonInfoContorl()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(int Person_Id)
        {
            if (Person_Id < 1)
                return;
            else if (!clsPerson.isExist(Person_Id))
                return;
            _Person = clsPerson.Find(Person_Id);
            LID.Text  = _Person.Id.ToString();
            LFirstName.Text  = _Person.FirstName.ToString();
            LLastName.Text  = _Person.LastName.ToString();
            LPhone.Text  = _Person.Phone.ToString();
            LEmail.Text  = _Person.Email.ToString();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PersonInfoContorl_Load(object sender, EventArgs e)
        {

        }

        private void LPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
