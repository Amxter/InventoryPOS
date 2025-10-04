using System.Data;

namespace POSLogic
{

    namespace LogicProduct
    {
        public interface ICompanySarvice
        {
            DataOfProjectPOS.ProductDataModel.CompanyInfo ConvertParametartoClass(int companyID,
                            string companyName, string phone, string address, string description);
            int AddCompany(string companyName, string phone, string address, string description);
            bool UpdateCompany(int companyID, string companyName, string phone, string address, string description);
            bool DeleteCompany(int iD);
            void GetProductByProductID(int companyID, string companyName, string phone, string address, string description);
            DataTable GetAllCompany();

            DataTable GetAllCompanyByProductName(string companyName);
        }

    }

}
