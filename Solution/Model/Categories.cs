using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Categories
    {
        private int categoryId;
        private string categoryName;
        private string description;
        private byte[] image;

        public Categories()
        {
        }

        public Categories(int categoryId, string categoryName, string description)
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
            this.description = description;
        }

        public Categories(int categoryId, string categoryName, string description, byte[] image)
            : this(categoryId, categoryName, description)
        {
            this.image = image;
        }

        public Categories(string categoryName, string description)
        {
            this.categoryName = categoryName;
            this.description = description;
        }

        public int CategoryId
        {   get { return categoryId; }

            set { categoryId = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }

            set { categoryName = value; }
        }

        public string Description
        {
            get { return description; }

            set { description = value; }
        }

        public byte[] Image
        {
            get { return image; }

            set { image = value; }
        }

    }
}
