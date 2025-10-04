using System.Data;

namespace POSLogic
{

    namespace LogicProduct
    {
        public interface ICategorySarvice
        {
            DataOfProjectPOS.ProductDataModel.CategoryInfo ConvertParameterClass(int categoryID,
                       string categoryName, string description);
            int AddCategory(string categoryName, string description);
            bool UpdateCategory(int categoryID, string categoryName, string Description);
            bool DeleteCategory(int iD);
            void GetCategoryByCategoryID(int categoryID, string categoryName, string description);
            DataTable GetAllCategory();
            DataTable GetAllCategoryByName(string categoryName);

        }

    }

}
