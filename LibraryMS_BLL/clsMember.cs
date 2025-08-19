using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    public class clsMember
    {
        // Member_id Registration_date
        // Person_id
        public enum enMode { AddMember = 0, UpdadeMember = 1 };
        public int Member_id, Registration_date, Person_id;
        public enMode Mode = enMode.AddMember;

        public clsMember()
        {
            this.Member_id = -1;
            this.Registration_date = -1;
            this.Person_id = -1;
            Mode = enMode.AddMember;
        }
        private clsMember(int member_id, int registration_date, int person_id)
        {
            this.Member_id = member_id;
            this.Registration_date = registration_date;
            this.Person_id = person_id;
            this.Mode = enMode.UpdadeMember;
        }
        
        private bool _AddMember()
        {
            this.Member_id
                = LibraryMS_DAL.clsMember.AddMember(Person_id, Registration_date);

            return Member_id > -1;

        }

        private bool _UpdadeMember()
        {
            return LibraryMS_DAL.clsMember.UpdateMember(Member_id,Person_id,Registration_date);
        }

        public bool _Save()
        {
            switch (Mode)
            {
                case enMode.AddMember:
                    if (_AddMember())
                        return true;
                    else
                        return false;
                case enMode.UpdadeMember:
                    return _UpdadeMember();

            }
            return false;
        }

        public static DataTable GetAllMember()
        {
            return LibraryMS_DAL.clsMember.GetAllMember();
        }
        public bool _DeleteMember()
        {
            return LibraryMS_DAL.clsMember.DeleteMember(Member_id);
        }
    
        public static clsMember GetMemberById(int id)
        {
            int PersonId = -1;
            int Registration_date = -1;

            bool isGet = false;
            isGet = LibraryMS_DAL.clsMember
                .GetMemberByid(id, ref PersonId,ref Registration_date);

            if (isGet)
                return new clsMember(id, Registration_date, PersonId);
            return null;
        }

        static public bool isExist(int Member_id)
        {
            return LibraryMS_DAL.clsMember.isExist(Member_id);
        }
    }
}
