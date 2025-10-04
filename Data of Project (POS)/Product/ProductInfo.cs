namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public class ProductInfo
        {

            public int ProductID { get; set; }
            public int CategoryID { get; set; }
            public string ImagePath { get; set; }
            public int StatusID { get; set; }
            public int CompanyID { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public string Barcode { get; set; }
            public int Quantity { get; set; }
            public double CostPrice { get; set; }
            public double SellingPrice { get; set; }

        }
    }
 
}
