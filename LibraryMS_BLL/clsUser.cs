using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    public class clsUser
    {
        public enum eMode { AddUser = 0, UpdateUser = 1 };
        public eMode Mode = eMode.AddUser;
        // UserName Password Person_id

        public string UserName { get; set; }
        public string Password { get; set; }
        public int Person_id { get; set; }

        public clsUser()
        {
            UserName = string.Empty;
            Password = string.Empty;
            Person_id = -1;
            Mode = eMode.AddUser;
        }

        private clsUser(string UserName, string Password, int Person_id)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Person_id = Person_id;
            Mode = eMode.UpdateUser;
        }

        private bool _AddUser()
        {
            if (UserName == string.Empty ||
                Password.Length <= 7 || Person_id < 1)
                return false;
            bool isAdd = LibraryMS_DAL.clsUsers.AddUser(UserName, Password, Person_id);
            return isAdd;
        }

        private bool _ChangePasswordUser(string NewPassword)
        {
            if (UserName == string.Empty || NewPassword == string.Empty ||
                NewPassword.Length <= 7 || Person_id < 1)
                return false;
            bool isChange = LibraryMS_DAL.clsUsers.ChangePassword(UserName, Password, NewPassword);
            if (isChange)
            {
                Password = NewPassword;
                return true;
            }
            return false;
        }

        public static clsUser _GetUserByUserName(string userName)
        {
            string password = "";
            int person_id = 0;

            bool isFound = LibraryMS_DAL.clsUsers.GetUserByUserName(ref userName, ref password, ref person_id);

            if (isFound)
                return new clsUser(userName, password, person_id);
            return null;
        }

        public bool _Save(string NewPassword = "")
        {
            switch (Mode)
            {
                case eMode.AddUser:
                    if (_AddUser())
                    {
                        Mode = eMode.UpdateUser;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case eMode.UpdateUser:
                    return _ChangePasswordUser(NewPassword);

            }

            return false;
        }


        public static bool isExist(string UserName)
        {
            if (UserName == string.Empty)
                return false;

            return LibraryMS_DAL.clsUsers.isExist(UserName);
        }

        public static bool Login
     (string UserName, string Password)
        {
            if(UserName == string.Empty || Password == string.Empty)
                return false;

            return LibraryMS_DAL.clsUsers.Login(UserName,Password);
        }
        
        public static DataTable GetAllUsers()
        {
            return LibraryMS_DAL.clsUsers.GetAllUsers();
        }
    }
}
