using System.Data;

namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public interface IProductRepository 
        {
            DataTable ListProduct();
            DataTable ListProductByCompanyID(int companyID);
            DataTable ListProductByStatusID(int statusID);
            DataTable ListProductByCategoryID(int categoryID);
            DataTable ListProductByName(string productName);
            int AddProduct(ProductInfo productInfo);
            bool UpdateProduct(ProductInfo productInfo);
            bool DeleteProductByID(int productID);
            ProductInfo GetProductByProductID(int productID);
            DataTable ListProductByQuantityIs(int Quantity);
        }
    }
 
}
