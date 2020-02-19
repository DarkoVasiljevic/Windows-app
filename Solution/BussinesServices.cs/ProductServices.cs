using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model; 

namespace BussinesServices
{
    public class ProductServices
    {
        private ProductsRepository repository = new ProductsRepository();

        private bool checkById(int id)
        {
            List<Products> products = repository.GetAll();

            bool ind = false;
            foreach (var item in products)
            {
                if (item.ProductId == id)
                {
                    ind = true;
                    break;
                }
            }

            return ind;
        }

        private bool[] checkAddProduct(string productName, int? suplierId, int? categoryId)
        {
            bool[] check = new bool[] { false, false, false };

            List<Products> products = repository.GetAll();

            foreach (var item in products)
            {
                if (item.ProductName == productName)
                {
                    check[0] = true;
                }
                else if (item.SuplierId == suplierId)
                {
                    check[1] = true;
                }
                else if (item.CategoryId == categoryId)
                {
                    check[2] = true;
                }
            }

            return check;
        }

        public int AddProduct( string productName, int? suplierId, int? categoryId,
                               string quantityPerUnit, decimal? unitPrice, short? unitsInStock,
                               short? unitsOnOrder, short? reorderLevel, bool discounted )
        {

            Products product = new Products();

            bool[] check = checkAddProduct(productName, suplierId, categoryId);

            if (check[0])
            {
                throw new Exception("Product name alredy exist");
            }
            else if (!check[1])
            {
                throw new Exception("Supplier Id do not exist");
            }
            else if (!check[2])
            {
                throw new Exception("Category Id do not exist");
            }
            else
            {
                product = new Products(productName, suplierId, categoryId, quantityPerUnit,
                                  unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discounted );
            }

            return repository.AddSingle(product);
        }

        public int DeleteProduct(int id)
        {
            int result = 0;

            bool check = checkById(id);

            if (check)
            {
                result = repository.DeleteSingle(id);
            }
            else
            {
                throw new Exception("Product Id do not exists");
            }

            return result;
        }

        public List<Products> GetAllProduct()
        {
            List<Products> product = repository.GetAll();

            if (product.Count == 0)
            {
                throw new Exception("No avalaible products");
            }

            return repository.GetAll();
        }

        public Products GetByIdProduct(int id)
        {
            Products product = new Products();

            bool check = checkById(id);

            if (check)
            {
                product = repository.GetById(id);
            }
            else
            {
                throw new Exception("Product Id not exist");
            }

            return product;
        }

        private bool[] checkUpdateProduct(string productName, int? suplierId, int? categoryId, 
                                          string quantityPerUnit, decimal? unitPrice, short? unitsInStock, 
                                          short? unitsOnOrder, short? reorderLevel, bool discounted)
        {
            bool[] check = new bool[4] { false, false, false, false };

            List<Products> products = repository.GetAll();

            foreach (var item in products)
            {
                if (item.ProductName == productName)
                {
                    check[0] = true;
                }
                else if (item.SuplierId == suplierId)
                {
                    check[1] = true;
                }
                else if (item.CategoryId == categoryId)
                {
                    check[2] = true;
                }
                else if (Convert.ToInt16(item.QuantityPerUnit) < 0 || Convert.ToInt16(item.UnitPrice) < 0
                            || Convert.ToInt16(item.UnitsInStock) < 0 || Convert.ToInt16(item.UnitsOnOrder) < 0
                            || Convert.ToInt16(item.ReorderLevel) < 0 || Convert.ToInt16(item.Discounted) < 0)
                {
                    check[3] = true;
                }
            }

            return check;
        }

        public int UpdateProduct( int productId, string productName, int? suplierId, int? categoryId,
                                  string quantityPerUnit, decimal? unitPrice, short? unitsInStock,
                                  short? unitsOnOrder, short? reorderLevel, bool discounted )
        {
            Products product = new Products();

            bool checkId = checkById(productId);
            bool[] check = checkUpdateProduct(productName, suplierId, categoryId, quantityPerUnit, unitPrice,
                                              unitsInStock, unitsOnOrder, reorderLevel, discounted);

            if (!checkId)
            {
                throw new Exception("Product Id do not exists");
            }
            else if (check[0])
            {
                throw new Exception("Product name already exists");
            }
            else if (!check[1])
            {
                throw new Exception("Supplier Id do not exists");
            }
            else if (!check[2])
            {
                throw new Exception("Category Id do not exists");
            }
            else if (check[3])
            {
                throw new Exception(@"QuantityPerUnit, UnitPrice, UnitsInStock, 
                                    UnitsOnOrder, ReorderLevel and Discounted
                                    must be greater than zero");
            }
            else
            {
                product = new Products(productId, productName, suplierId, categoryId, quantityPerUnit, 
                                       unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discounted);
            }

            return repository.UpdateSingle(product);
        }
    }
}
