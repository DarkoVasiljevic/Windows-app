using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Products
    {
        private int productId;
        private string productName;
        private int? suplierId;
        private int? categoryId;
        private string quantityPerUnit;
        private decimal? unitPrice;
        private short? unitsInStock;
        private short? unitsOnOrder;
        private short? reorderLevel;
        private bool discounted;

        public Products()
        {

        }

        public Products(string productName, int? suplierId, int? categoryId, string quantityPerUnit,
                      decimal? unitPrice, short? unitsInStock, short? unitsOnOrder, short? reorderLevel, bool discounted)
        {
            this.productName = productName;
            this.suplierId = suplierId;
            this.categoryId = categoryId;
            this.quantityPerUnit = quantityPerUnit;
            this.unitPrice = unitPrice;
            this.unitsInStock = unitsInStock;
            this.unitsOnOrder = unitsOnOrder;
            this.reorderLevel = reorderLevel;
            this.discounted = discounted;
        }

        public Products(int productId, string productName, int? suplierId, int? categoryId, string quantityPerUnit,
                        decimal? unitPrice, short? unitsInStock, short? unitsOnOrder, short? reorderLevel, bool discounted)
            : this(productName, suplierId, categoryId, quantityPerUnit, unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discounted)
        {
            this.productId = productId;
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int? SuplierId
        {
            get { return suplierId; }
            set { suplierId = value; }
        }

        public int? CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public string QuantityPerUnit
        {
            get { return quantityPerUnit; }
            set { quantityPerUnit = value; }
        }

        public decimal? UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public short? UnitsInStock
        {
            get { return unitsInStock; }
            set { unitsInStock = value; }
        }

        public short? UnitsOnOrder
        {
            get { return unitsOnOrder; }
            set { unitsOnOrder = value; }
        }

        public short? ReorderLevel
        {
            get { return reorderLevel; }
            set { reorderLevel = value; }
        }

        public bool Discounted
        {
            get { return discounted; }
            set { discounted = value; }
        }
    }
}
