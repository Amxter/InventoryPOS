

using POSLogic;
using POSLogic.LogicProduct;
using System;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class UCSearchProduct : UserControl
    {
        enum enWaySearch { Company, Category, Name, Status }

        enWaySearch _WaySearch;
        DataGridView _dgvProducts;
        ICompanySarvice _companySarvice;
        ICategorySarvice _categorySarvice;
        IProductService _Product;
        IStatus _Status;

        public UCSearchProduct(DataGridView dgvProducts)
        {
            _dgvProducts = dgvProducts;
            InitializeComponent();
            _companySarvice = ServiceFactory.CreateCompanyService();
            _categorySarvice = ServiceFactory.CreateCategoryService();
            _Product = ServiceFactory.CreateProductService();
            _Status = ServiceFactory.CreateProductStatusService();
        }

        private void SearchBy(string WaySearch)
        {

            textBox1.Visible = false ;
            if (WaySearch == "Company")
            {
                _WaySearch = enWaySearch.Company;
                cbComponents.DataSource = _companySarvice.GetAllCompany();
                cbComponents.DisplayMember = "CompanyName";
                cbComponents.ValueMember = "CompanyID";
                cbComponents.Visible = true;

            }
            else if (WaySearch == "Category")
            {
                _WaySearch = enWaySearch.Category;
                cbComponents.DataSource = _categorySarvice.GetAllCategory();
                cbComponents.DisplayMember = "CategoryName";
                cbComponents.ValueMember = "CategoryID";
                cbComponents.Visible = true;
            }
            else if (WaySearch == "Product Name")
            {
                _WaySearch = enWaySearch.Name;
                textBox1.Visible = true;
                cbComponents.Visible = false;
            }
            else if (WaySearch == "Status")
            {
                _WaySearch = enWaySearch.Status;
                cbComponents.DataSource = _Status.GetStatus();
                cbComponents.DisplayMember = "StatusName";
                cbComponents.ValueMember = "ProductStatuseID";
                cbComponents.Visible = true;
            }

            butSearch.Visible = true ;

        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBy(cbSearch.Text);
        }

        private void SearchByCompany(int CompanyID)
        {
            _dgvProducts.DataSource = _Product.GetAllProductByCompanyID(CompanyID);
        }
        private void SearchByStatus(int StatusID)
        {
            _dgvProducts.DataSource = _Product.GetAllProductByStatusID(StatusID);
        }
        private void SearchByCategory(int CategoryID)
        {
            _dgvProducts.DataSource = _Product.GetAllProductByCategoryID(CategoryID);
        }
        private void SearchByProductName(string ProductName)
        {
            _dgvProducts.DataSource = _Product.GetAllProductByProductName(ProductName);
        }

        private void Search()
        {

            switch (_WaySearch)
            {
                case enWaySearch.Company:
                    SearchByCompany(Convert.ToInt32(cbComponents.SelectedValue));
                    break;
                case enWaySearch.Status:
                    SearchByStatus(Convert.ToInt32(cbComponents.SelectedValue));
                    break;
                case enWaySearch.Category:
                    SearchByCategory(Convert.ToInt32(cbComponents.SelectedValue));
                    break;
                case enWaySearch.Name:
                    SearchByProductName(textBox1.Text);
                    break;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchByProductName(textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _dgvProducts.DataSource = _Product.GetAllProduct();
        }
    }
}
