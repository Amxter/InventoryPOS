using DataOfProjectPOS.ProductDataModel;
using System.Data;

namespace POSLogic
{

    namespace LogicProduct
    {
        public class CompanySarvice : ICompanySarvice
        {
            DataOfProjectPOS.ProductDataModel.ICompanyRepository IcompanyRepository;

            public CompanySarvice(CompanyRepository companyRepository)
            {
                IcompanyRepository = companyRepository;

            }
            private DataOfProjectPOS.ProductDataModel.CompanyInfo ConvertParametartoClass(int companyID,
                            string companyName, string phone, string address, string description)

            {
                DataOfProjectPOS.ProductDataModel.CompanyInfo companyInfo = new DataOfProjectPOS.ProductDataModel.CompanyInfo();
                companyInfo.CompanyID = companyID;
                companyInfo.CompanyName = companyName;
                companyInfo.Phone = phone;
                companyInfo.Address = address;
                companyInfo.Description = description;


                return companyInfo;

            }
            public int AddCompany(string companyName, string phone, string address, string description)

            {
                return IcompanyRepository.AddCompany(ConvertParametartoClass(-1, companyName, phone, address, description));

            }

            public bool UpdateCompany(int companyID, string companyName, string phone, string address, string description)
            {


                return IcompanyRepository.UpdateCompany(ConvertParametartoClass(companyID, companyName, phone, address, description));

            }

            public bool DeleteCompany(int iD)
            {

                return IcompanyRepository.DeleteCompanyByID(iD);
            }

            public void GetProductByProductID(int companyID, string companyName, string phone, string address, string description)
            {

                DataOfProjectPOS.ProductDataModel.CompanyInfo companyInfo = IcompanyRepository.GetCompanyByID(companyID);
                companyID = companyInfo.CompanyID;
                companyName = companyInfo.CompanyName;
                phone = companyInfo.Phone;
                address = companyInfo.Address;
                description = companyInfo.Description;

            }
            public DataTable GetAllCompany()
            {

                return IcompanyRepository.ListCompany();

            }

            CompanyInfo ICompanySarvice.ConvertParametartoClass(int companyID, string companyName, string phone, string address, string description)
            {
                return ConvertParametartoClass(companyID, companyName, phone, address, description);
            }
            public   DataTable GetAllCompanyByProductName(string companyName)
            {

                return IcompanyRepository.ListCompanyByName(companyName);

            }
             

        }

    }

}
