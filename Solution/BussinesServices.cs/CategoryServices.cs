using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BussinesServices
{
    public class CategoryServices
    {
        private CategoriesRepository repository = new CategoriesRepository();

        private bool checkById(int id)
        {
            List<Categories> categories = repository.GetAll();

            bool ind = false;
            foreach (var item in categories)
            {
                if (item.CategoryId == id)
                {
                    ind = true;
                    break;
                }
            }

            return ind;
        }

        private bool checkByName(string name)
        {
            bool check = false;

            List<Categories> categories = repository.GetAll();

            foreach (var item in categories)
            {
                if (item.CategoryName.Equals(name.Trim()))
                {
                    check = true;
                    break;
                }
            }

            return check;
        }

        public int AddCategory(string categoryName, string description)//, byte[] image)
        {

            Categories category = new Categories();

            bool checkName = checkByName(categoryName);

            if (checkName)
            {
                throw new Exception("Category name already exist");
            }
            else
            {
                category = new Categories(categoryName, description);//, image);
            }

            return repository.AddSingle(category);
        }

        public int DeleteCategory(int id)
        {
            int result = 0;

            bool check = checkById(id);

            if (check)
            {
                result = repository.DeleteSingle(id);
            }
            else
            {
                throw new Exception("Category Id do not exists");
            }

            return result;
        }

        public List<Categories> GetAllCategory()
        {
            List<Categories> category = repository.GetAll();

            if (category.Count == 0)
            {
                throw new Exception("No avalaible categories");
            }

            return repository.GetAll();
        }

        public Categories GetByIdCategory(int id)
        {
            Categories category = new Categories();

            bool check = checkById(id);

            if (check)
            {
                category = repository.GetById(id);
            }
            else
            {
                throw new Exception("Category Id not exist");
            }

            return category;
        }

        public Categories GetByNameCategory(string name)
        {
            Categories category = new Categories();

            //bool check = checkByName(name);

            if (true)
            {
                category = repository.GetByName(name);
            }
            else
            {
                throw new Exception("Category name not exist");
            }

            return category;
        }

        //public byte[] GetPictyreByName(string name)
        //{
        //    byte[] image = null;

        //    try
        //    {
        //        image = repository.GetPicture(name);
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("Get picture failed");
        //    }
         
        //    return image;
        //}

        public int UpdateCategory(int categoryId, string categoryName, string description)//, byte[] image)
        {
            Categories category = new Categories();

            bool checkId = checkById(categoryId);
            bool checkName = checkByName(categoryName);

            if (!checkId)
            {
                throw new Exception("Category Id do not exists");
            }
            else if (checkName)
            {
                throw new Exception("Category name already exists");
            }
            else
            {
                category = new Categories(categoryId, categoryName, description);//, image);
            }

            return repository.UpdateSingle(category);
        }
    }
}
