using ExpenseTracker.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Business_Logic
{
    internal class CategoriesBL
    {
        private int CategoriesId { get; set; }
        private string CategoriesName { get; set; }

        public DataTable getCategoriesService()
        {
            CategoriesDAL categoriesDAL = new CategoriesDAL();
            DataTable dataTable = new DataTable();
            dataTable = categoriesDAL.getAllCategories();
            return dataTable;
        }

        public bool addCategoryService(string categoryName)
        {
            CategoriesDAL categories = new CategoriesDAL();
            return categories.addNewCategory(categoryName);
        }

        public bool removeCategoryService(string categoryName)
        {
            CategoriesDAL categories = new CategoriesDAL();
            return categories.removeCategory(categoryName);
        }
    }
}
