using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    public class clsPerson
    {
        // Person_id FirstName
        // LastName Phone Email
        public enum enMode { AddPerson = 0, UpdatePerson = 1};
        public enMode Mode = enMode.AddPerson;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public clsPerson()
        {
            Id = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;

            Mode = enMode.AddPerson;
        }

        public clsPerson(int Id,
            string FirstName, string LastName,
            string Phone, string Email)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            Mode = enMode.UpdatePerson;
        }
    
        private bool AddUser()
        {
            this.Id = 
                LibraryMS_DAL.clsPerson.AddPerson
                (FirstName, LastName, Phone, Email);
            return Id > -1;       
        }
        private bool UpdateUser()
        {
            bool IsUpdate =
                LibraryMS_DAL.clsPerson.UpdatePerson
                (Id,FirstName, LastName, Phone, Email);
            return IsUpdate;
        }
    
        public clsPerson Find()
        {
            int id = this.Id;
            string FirstName = "", Email = "", LastName = "", Phone = "";

            bool isFound = LibraryMS_DAL.clsPerson.GetPersonById(id, ref FirstName, ref LastName, ref Phone, ref Email);

            if(isFound)
                return new clsPerson(id,FirstName, LastName,Phone,Email);
            return null;
        
        }
        
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddPerson:
                    if(AddUser())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdatePerson:
                    return UpdateUser();
            }
            return false;
        }
    
        public static DataTable GetAllPerson()
        {
            return LibraryMS_DAL.clsPerson.GetAllPersons();
        }

        static public bool isExist
    (int Person_id)
        {
            return LibraryMS_DAL.clsPerson.isExist(Person_id); ;
        }
        static public bool isExist (string FirstName, string LastName)
        {
            return LibraryMS_DAL.clsPerson.isExist(FirstName,LastName);
        }

        static public bool DeletePerson
    (int Person_id)
        {
            return LibraryMS_DAL.clsPerson.DeletePerson(Person_id);
        }
    }
}
