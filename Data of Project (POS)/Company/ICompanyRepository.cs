using System.Data;

namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public interface ICompanyRepository
        {

            DataTable ListCompany();
            int AddCompany(CompanyInfo companyInfo);
            bool UpdateCompany(CompanyInfo companyInfo);
            bool DeleteCompanyByID(int companyID);
            CompanyInfo GetCompanyByID(int companyID);
            DataTable ListCompanyByName(string companyName);
        }
    }
 
}
