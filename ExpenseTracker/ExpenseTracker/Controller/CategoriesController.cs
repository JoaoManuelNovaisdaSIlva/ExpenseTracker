using ExpenseTracker.Business_Logic;
using ExpenseTracker.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Controller
{
    internal class CategoriesController
    {
        private CategoriesBL CategoriesBL;

        public CategoriesController() { 
            this.CategoriesBL = new CategoriesBL();
        }

        public DataTable getCategories()
        {
            DataTable r = new DataTable();
            r = CategoriesBL.getCategoriesService();
            if(r != null && r.Rows.Count > 0) {
                return r ;
            }
            else
            {
                throw new MissingDataException("The data for the query: GetCategories is non existent!"); // Maybe if there are no categories users should add them
            }
        }
    }
}
