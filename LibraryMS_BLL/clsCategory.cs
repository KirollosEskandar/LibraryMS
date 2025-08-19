using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS_BLL
{
    internal class clsCategory
    {
        public int Category_id { get; set; }
        public string Category_name { get; set; }
        public enum eMode { AddCategory = 0, UpdadeCategory = 1 }
        public eMode Mode = eMode.AddCategory;

        public clsCategory()
        {
            Category_id = -1;
            Category_name = string.Empty;
            Mode = eMode.AddCategory;
        }
        private clsCategory(int category_id, string category_name)
        {
            Category_id = category_id;
            Category_name = category_name;
            Mode = eMode.UpdadeCategory;
        }

        private bool _AddCategory()
        {
            int Category_id = LibraryMS_DAL.clsCategory.AddCategory(Category_name);

            return Category_id > -1;
        }

        private bool _UpdateCategory()
        {
            return LibraryMS_DAL.clsCategory
                .UpdateCategory(Category_id, Category_name);
        }

        public clsCategory GetCategoryById(int id)
        {
            string Name = string.Empty;

            bool isGet = LibraryMS_DAL.clsCategory.GetNameCategoryById(id, ref Name);

            if (isGet)
                return new clsCategory(id, Name);
            return null;

        }
        static public bool isExist(int id)
        {
            return LibraryMS_DAL.clsMember.isExist(id);

        }

        public bool _Save()
        {
            switch (Mode)
            {
                case eMode.AddCategory:
                    if (_AddCategory())
                        return true;
                    else
                        return false;
                case eMode.UpdadeCategory:
                    return _UpdateCategory();
            }
            return false;
        }

        public static DataTable GetAllCategory()
        {
            return LibraryMS_DAL.clsCategory.GetAllCategory();

        }

        public  bool DeleteCategory()
        {
            return LibraryMS_DAL.clsCategory.DeleteCategory(Category_id);
        }
    }
}
