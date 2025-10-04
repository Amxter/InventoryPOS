using DataOfProjectPOS.ProductDataModel;
using DataOfProjectPOS.PurchaseInvoiceDataModel;
using POSLogic.LogicProduct;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLogic
{

    namespace LogicPurchaseInvoice
    {

        public interface IPurchaseInvoiceService
        {
            DataTable ListInvoice();
            DataTable ListSupplier();
            DataTable ListDetailsInvoiceByPurchaseInvoiceID(int PurchaseInvoiceID);
            int AddInvoice(int SupplierID, int UserID, double TotalAmount, DateTime DateOfPurchase, DataTable DetailsInvoice);
            bool DeleteInvoice(int InvoiceID);
            bool UpdateInvoice(int InvoiceID, int SupplierID, int UserID, double TotalAmount, DateTime DateOfPurchase, DataTable DetailsInvoice);
        }
        public class PurchaseInvoiceService : IPurchaseInvoiceService 
        {

            IPurchaseInvoiceRepository _IpurchaseInvoiceRepository ;
            IProductRepository _productRepository  ;
            public PurchaseInvoiceService( PurchaseInvoiceRepository invoiceRepository , ProductRepository productRepository )
            {
                _IpurchaseInvoiceRepository = invoiceRepository;
                _productRepository = productRepository;
            }

            private DataOfProjectPOS.PurchaseInvoiceDataModel.InvoiceInfo ConvertParametartoClass(int InvoiceID,
              int SupplierID, int UserID,
             double TotalAmount, DateTime DateOfPurchase)
            {
                DataOfProjectPOS.PurchaseInvoiceDataModel.InvoiceInfo InvoiceInfo = new DataOfProjectPOS.PurchaseInvoiceDataModel.InvoiceInfo();
                InvoiceInfo.InvoiceID = InvoiceID;
                InvoiceInfo.SupplierID = SupplierID;
         
                InvoiceInfo.UserID = UserID;
                InvoiceInfo.TotalAmount = TotalAmount;
                InvoiceInfo.DateOfPurchase = DateOfPurchase;


                return InvoiceInfo;

            }
            public DataTable ListInvoice()
            {

                return _IpurchaseInvoiceRepository.ListInvoice();
            }
            public DataTable ListDetailsInvoiceByPurchaseInvoiceID(int PurchaseInvoiceID )
            {

                return _IpurchaseInvoiceRepository.ListDetailsInvoiceByPurchaseInvoiceID(PurchaseInvoiceID);

            }
            private void UpdateQuantity(int ProductID, int Quantity, double PriceAtPurchase )
            {

                ProductInfo productInfo = new ProductInfo();
                productInfo = _productRepository.GetProductByProductID(ProductID);
                productInfo.CostPrice = ((productInfo.CostPrice * productInfo.Quantity) + PriceAtPurchase) / (productInfo.Quantity + Quantity);
                productInfo.Quantity += Quantity;
                _productRepository.UpdateProduct(productInfo);


            }
            private void AddDetailsInvoice(int PurchaseInvoiceID, int productID, int quantity, double PriceAtPurchase)
            {

                if (_IpurchaseInvoiceRepository.AddDetailsInvoice(PurchaseInvoiceID, productID, quantity, PriceAtPurchase))
                {

                    UpdateQuantity(productID, quantity, PriceAtPurchase);

                }

            }
            private void  AddDetails (int InvoiceID, DataTable DetailsInvoice)
            {
                foreach (DataRow row in DetailsInvoice.Rows )
                {

                    AddDetailsInvoice(InvoiceID , Convert.ToInt32(row["ProductID"])  , Convert.ToInt32(row["Quantity"]), Convert.ToDouble(row["PriceAtPurchase"]) );
                  
                }


            }
            public int AddInvoice( int SupplierID, int UserID, double TotalAmount, DateTime DateOfPurchase , DataTable DetailsInvoice )
            {

                int ID = _IpurchaseInvoiceRepository.AddInvoice(ConvertParametartoClass( -1 , SupplierID,   UserID,TotalAmount,   DateOfPurchase));

                if (ID != -1)
                {
                    AddDetails(ID , DetailsInvoice);
                }

                return ID;
            }

            public bool DeleteInvoice(int InvoiceID)
            {
                DataTable DetailsInvoice = _IpurchaseInvoiceRepository.ListDetailsInvoiceByPurchaseInvoiceID(InvoiceID);
                bool isDelete = _IpurchaseInvoiceRepository.DeleteInvoiceByID(InvoiceID);

                if (isDelete)
                {
                    foreach(DataRow row in DetailsInvoice.Rows )
                    {
                        UpdateQuantity(Convert.ToInt32(row["ProductID"]), -1 * Convert.ToInt32(row["Quantity"]), -1 * Convert.ToDouble(row["PriceAtPurchase"]));
 
                    }
                  
                }

                return isDelete;
            }

            public bool UpdateInvoice(int InvoiceID, int SupplierID, int UserID, double TotalAmount, DateTime DateOfPurchase, DataTable DetailsInvoice)
            {
                
                bool isUpdate = _IpurchaseInvoiceRepository.UpdateInvoice(ConvertParametartoClass(InvoiceID, SupplierID, UserID, TotalAmount, DateOfPurchase));

                if (isUpdate)
                {
                  

                  
                    foreach (DataRow row in DetailsInvoice.Rows)
                    {
                        UpdateQuantity(Convert.ToInt32(row["ProductID"]), -1 * Convert.ToInt32(row["Quantity"]), -1 * Convert.ToDouble(row["PriceAtPurchase"]));

                    }
                    _IpurchaseInvoiceRepository.DeleteInvoiceDetailByID(InvoiceID);

                    AddDetails(InvoiceID, DetailsInvoice);


                }

                return isUpdate;
            }
            public DataTable ListSupplier()
            {

                return _IpurchaseInvoiceRepository.ListSupplier();
            }
            
        }
    }
}
