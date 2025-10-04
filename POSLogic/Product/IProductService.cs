using System.Data;

namespace POSLogic
{

    namespace LogicProduct
    {
        public interface IProductService
        {
            DataOfProjectPOS.ProductDataModel.ProductInfo ConvertParametartoClass(int productID, int companyID, int categoryID,
                string imagePath, int productStatusID, string productName, string description,
               double costPrice, double sellingPrice, int quantity, string barcode);
            int AddProduct(int companyID, int categoryID,
                string imagePath, int productStatusID, string productName, string description,
               double costPrice, double sellingPrice, int quantity, string barcode);
            bool UpdateProduct(int ProductID, int companyID, int categoryID,
              string imagePath, int productStatusID, string productName, string description,
             double costPrice, double sellingPrice, int quantity, string barcode);
            bool DeleteProduct(int ID);
            void GetProductByProductID(ref int ProductID, ref int companyID, ref int categoryID,
             ref string imagePath, ref int productStatusID, ref string productName, ref string description,
             ref double costPrice,ref double sellingPrice, ref int quantity, ref string barcode);
            DataTable GetAllProduct();
            DataTable GetAllProductByCompanyID(int companyID);
            DataTable GetAllProductByStatusID(int statusID);
             DataTable GetAllProductByCategoryID(int categoryID);
            DataTable GetAllProductByProductName(string productName);
            DataTable GetAllProductByQuantityIs(int Quantity);
        }

    }

}
