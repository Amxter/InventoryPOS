using DataOfProjectPOS.ProductDataModel;
using System.Data;

namespace POSLogic
{

    namespace LogicProduct
    {
        public class ProductService  : IProductService

        {
            IProductRepository _repository;
            public ProductService(ProductRepository productRepository)
            {
                _repository = productRepository;


            }
            private DataOfProjectPOS.ProductDataModel.ProductInfo ConvertParametartoClass(int productID, int companyID, int categoryID,
                string imagePath, int productStatusID, string productName, string description,
               double costPrice, double sellingPrice , int quantity, string barcode)
            {
                DataOfProjectPOS.ProductDataModel.ProductInfo productInfo = new DataOfProjectPOS.ProductDataModel.ProductInfo();
                productInfo.ProductID = productID;
                productInfo.CompanyID = companyID;
                productInfo.CategoryID = categoryID;
                productInfo.ImagePath = imagePath;
                productInfo.StatusID = productStatusID;
                productInfo.ProductName = productName;
                productInfo.Description = description;
                productInfo.CostPrice = costPrice;
                productInfo.Quantity = quantity;
                productInfo.Barcode = barcode;
                productInfo.SellingPrice = sellingPrice;

                return productInfo;

            }
            public int AddProduct(int companyID, int categoryID,
                string imagePath, int productStatusID, string productName, string description,
               double costPrice, double sellingPrice, int quantity, string barcode)
            {


                return _repository.AddProduct(ConvertParametartoClass(-1, companyID, categoryID, imagePath, productStatusID, productName, description, costPrice,   sellingPrice, quantity, barcode));

            }

            public bool UpdateProduct(int ProductID, int companyID, int categoryID,
               string imagePath, int productStatusID, string productName, string description,
              double costPrice, double sellingPrice, int quantity, string barcode)
            {


                return _repository.UpdateProduct(ConvertParametartoClass(ProductID, companyID, categoryID, imagePath, productStatusID, productName, description, costPrice,   sellingPrice, quantity, barcode));

            }

            public bool DeleteProduct(int ID)
            {

                return _repository.DeleteProductByID(ID);
            }

            public void GetProductByProductID(ref int ProductID, ref int companyID, ref int categoryID,
             ref string imagePath, ref int productStatusID, ref string productName, ref string description,
             ref double costPrice, ref double sellingPrice, ref int quantity, ref string barcode)
            {


                DataOfProjectPOS.ProductDataModel.ProductInfo productInfo = _repository.GetProductByProductID(ProductID);
                if (productInfo != null)
                {
                    ProductID = productInfo.ProductID;
                    companyID = productInfo.CompanyID;
                    categoryID = productInfo.CategoryID;
                    imagePath = productInfo.ImagePath;
                    productStatusID = productInfo.StatusID;
                    productName = productInfo.ProductName;
                    description = productInfo.Description;
                    costPrice = productInfo.CostPrice;
                    quantity = productInfo.Quantity;
                    barcode = productInfo.Barcode;
                      sellingPrice = productInfo.SellingPrice;
                }



            }
            public DataTable GetAllProduct()
            {

                return _repository.ListProduct();

            }

            public DataTable GetAllProductByCompanyID(int companyID)  
            {
               
                return _repository.ListProductByCompanyID(companyID);

            }
            public DataTable GetAllProductByStatusID(int statusID)    
            {

                return _repository.ListProductByStatusID(statusID);

            }
            public DataTable GetAllProductByCategoryID(int categoryID)
            {

                return _repository.ListProductByCategoryID(categoryID);

            }
            public DataTable GetAllProductByProductName(string productName)
            {

                return _repository.ListProductByName(productName);

            }
            public DataTable GetAllProductByQuantityIs(int Quantity)
            {
                return _repository.ListProductByQuantityIs(Quantity);
            }
            ProductInfo IProductService.ConvertParametartoClass(int productID, int companyID, int categoryID, string imagePath, int productStatusID, string productName, string description, double costPrice, double sellingPrice, int quantity, string barcode)
            {
                return ConvertParametartoClass(productID, companyID, categoryID, imagePath, productStatusID, productName, description, costPrice,   sellingPrice, quantity, barcode);
            }
        }

    }

}
