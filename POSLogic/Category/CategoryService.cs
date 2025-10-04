using DataOfProjectPOS.ProductDataModel;
using System;
using System.Data;

namespace POSLogic
{

    namespace LogicProduct
    {
 
        public class CategoryService : ICategorySarvice 
        {
            ICategoryRepository IcategoryRepository;

            public CategoryService  (CategoryRepository categoryRepository)
            {
                IcategoryRepository = categoryRepository ;
            }
            private DataOfProjectPOS.ProductDataModel.CategoryInfo ConvertParameterClass(int categoryID,
                      string categoryName , string description)

            {
                DataOfProjectPOS.ProductDataModel.CategoryInfo categoryInfo = new DataOfProjectPOS.ProductDataModel.CategoryInfo();
                categoryInfo.CategoryID = categoryID;
                categoryInfo.CategoryName = categoryName;
                categoryInfo.Description = description;


                return categoryInfo;

            }
            public  int AddCategory(string categoryName, string description)

            {

                
                return IcategoryRepository.AddCategory(ConvertParameterClass(-1 , categoryName, description));

            }
                    
            public  bool UpdateCategory(int categoryID, string categoryName, string Description)
            {


                return IcategoryRepository.UpdateCategory(ConvertParameterClass(categoryID, categoryName, Description));

            }
                    
            public  bool DeleteCategory(int iD)
            {

                return IcategoryRepository.DeleteCategoryByID(iD);
            }
                    
            public  void GetCategoryByCategoryID(int categoryID, string categoryName, string description)
            {

                DataOfProjectPOS.ProductDataModel.CategoryInfo  categoryInfo = IcategoryRepository.GetCategoryByCategoryID(categoryID);
                categoryID = categoryInfo.CategoryID;
                categoryName = categoryInfo.CategoryName;
                description = categoryInfo.Description;

            }
            public  DataTable GetAllCategory()
            {

                return IcategoryRepository.ListCategory();
                
            }

            CategoryInfo ICategorySarvice.ConvertParameterClass(int categoryID, string categoryName, string description)
            {
                return ConvertParameterClass(categoryID, categoryName, description);
            }

            public DataTable GetAllCategoryByName( string categoryName )
            {

                 
                return IcategoryRepository.ListCategoryByName(  categoryName);
            }
        }

    }

}
