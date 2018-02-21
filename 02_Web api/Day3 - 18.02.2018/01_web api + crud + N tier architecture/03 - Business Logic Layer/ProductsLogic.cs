using System.Collections.Generic;
using System.Linq;

namespace JohnBryce
{
    public class ProductsLogic : BaseLogic
    {
        public List<ProductModel> GetAllProducts()
        {
            return DB.Products.Select(p =>
                new ProductModel
                {
                    productID = p.ProductID,
                    productName = p.ProductName,
                    unitPrice = p.UnitPrice,
                    unitsInStock = p.UnitsInStock,
                    unitsOnOrder = p.UnitsOnOrder
                }).ToList();
        }

        public ProductModel GetOneProduct(int productID)
        {
            var query = from p in DB.Products
                        where p.ProductID == productID
                        select new ProductModel
                        {
                            productID = p.ProductID,
                            productName = p.ProductName,
                            unitPrice = p.UnitPrice,
                            unitsInStock = p.UnitsInStock,
                            unitsOnOrder = p.UnitsOnOrder
                        };

            return query.SingleOrDefault();
        }

        public ProductModel AddProduct(ProductModel productModel)
        {
            Product product = new Product {
                ProductName = productModel.productName,
                UnitPrice = productModel.unitPrice,
                UnitsInStock = productModel.unitsInStock,
                UnitsOnOrder = productModel.unitsOnOrder
            };

            DB.Products.Add(product);
            DB.SaveChanges();
            productModel.productID = product.ProductID;
            return productModel;
        }
    }
}
