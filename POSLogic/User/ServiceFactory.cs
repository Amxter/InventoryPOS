using POSLogic.LogicInvoice;
using POSLogic.LogicProduct;
using POSLogic.LogicPurchaseInvoice;
using POSLogic.LogicUser;

namespace POSLogic
{
    public static class ServiceFactory
    {

        public static IUserService CreateUserService()
        {

            var userRepo = new DataOfProjectPOS.UserDataModels.UserRepository();


            return new UserService(userRepo);
        }
        public static IRoleService CreateRoleService()
        {

            var userRepo = new DataOfProjectPOS.UserDataModels.RoleRepository();


            return new RoleService(userRepo);
        }
        public static IUserStatus CreateUserStatusService()
        {

            var userRepo = new DataOfProjectPOS.UserDataModels.UserStatusRepository();


            return new UserStatus(userRepo);
        }
        public static ICategorySarvice CreateCategoryService()
        {
            var userRepo = new DataOfProjectPOS.ProductDataModel.CategoryRepository();
            return new CategoryService(userRepo);
        }
        public static ICompanySarvice CreateCompanyService()
        {
            var userRepo = new DataOfProjectPOS.ProductDataModel.CompanyRepository();
            return new CompanySarvice(userRepo);
        }
        public static IProductService CreateProductService()
        {
            var userRepo = new DataOfProjectPOS.ProductDataModel.ProductRepository();
            return new ProductService(userRepo);
        }
        public static IStatus CreateProductStatusService()
        {

            var userRepo = new DataOfProjectPOS.ProductDataModel.StatusRepository();


            return new Status(userRepo);
        }
        public static IInvoiceSarvice CreateInvoiceService()
        {

            var userRepo = new DataOfProjectPOS.InvoiceDataModel.InvoiceRepository();


            return new InvoiceSarvice(userRepo);
        }
        public static IInvoiceStatus CreateInvoiceStatus()
        {

            var userRepo = new DataOfProjectPOS.InvoiceDataModel.StatusInvoice();


            return new InvoiceStatus(userRepo);
        }
        public static IPurchaseInvoiceService CreatePurchaseInvoiceService()
        {

            var userRepo = new DataOfProjectPOS.PurchaseInvoiceDataModel.PurchaseInvoiceRepository();
            return new PurchaseInvoiceService(userRepo, new DataOfProjectPOS.ProductDataModel.ProductRepository());
        }

    }
}
