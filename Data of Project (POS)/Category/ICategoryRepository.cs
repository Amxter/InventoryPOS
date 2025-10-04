using System.Data;

namespace DataOfProjectPOS
{

    namespace ProductDataModel
    {
        public interface ICategoryRepository {
            DataTable ListCategory();
            int AddCategory(CategoryInfo categoryInfo);
            bool UpdateCategory(CategoryInfo categoryInfo);
            bool DeleteCategoryByID(int categoryID);
            CategoryInfo GetCategoryByCategoryID(int categoryID);

            DataTable ListCategoryByName(string categoryName);

        }
    }
 
}
