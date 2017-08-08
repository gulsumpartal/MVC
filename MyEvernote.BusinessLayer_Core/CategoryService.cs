using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using MyEvernote.Common;
using MyEvernote.DataAccessLayer_Infastructure.EntityFramework;

namespace MyEvernote.BusinessLayer_Core
{
    public class CategoryService
    {
        private readonly Reporsitory<Category> categoryReporsitory = new Reporsitory<Category>();

        public List<Category> GetCategories()
        {
            return categoryReporsitory.List();
        }

        public Category GetCategoryById(int? id)
        {
            return categoryReporsitory.Find(p => p.Id == id);
        }
    }
}
