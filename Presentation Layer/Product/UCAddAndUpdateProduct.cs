using POSLogic;
using POSLogic.LogicProduct;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Project_Plint_of_Sale_System
{
    public partial class UCAddAndUpdateProduct : UserControl
    {
        public enum Mode { Add, Update };
        Mode _Mode;
        int _ProductID;
        string _ImagePath;
        double _CostPrice  ; 
        int _Quantity  ;
        double _sellingPrice;

        ICategorySarvice _category ;
        ICompanySarvice _companySarvice;
        IProductService _Product;
        IStatus _Status ;

        private bool LodeImage(string Path)
        {

            if (Path != "")
            {
                if (!string.IsNullOrWhiteSpace(Path) && File.Exists(Path))
                {

                    pictureBox1.Image = Image.FromFile(Path);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    linkLabel1.Text = "Remove Picture";
                    return true;
                }
                else
                {
                    MessageBox.Show("Image path is not exist or Image path is Wroeg ");
                    linkLabel1.Text = "Add Picture";
                    pictureBox1.Image = null;
                    return false;
                }

            }
            else
            {
                linkLabel1.Text = "Add Picture";
                pictureBox1.Image = null;
                return false;
            }

        }
        public UCAddAndUpdateProduct(int ProductID)
        {
            _ProductID = ProductID;

            if (ProductID != -1)
                _Mode = Mode.Update;
            else
                _Mode = Mode.Add;
            _category = ServiceFactory.CreateCategoryService();
            _companySarvice = ServiceFactory.CreateCompanyService();
            _Product = ServiceFactory.CreateProductService();
            _Status = ServiceFactory.CreateProductStatusService();

            InitializeComponent();
            InitializeMode(_Mode);


        }


        private void LodeCompany()
        {

            cbCompany.DataSource = _companySarvice.GetAllCompany();
            cbCompany.DisplayMember = "CompanyName";
            cbCompany.ValueMember = "CompanyID";
            cbCompany.SelectedIndex = -1;
        }

        private void LodeStatus()
        {

            cbStatus.DataSource = _Status.GetStatus();
            cbStatus.DisplayMember = "StatusName";
            cbStatus.ValueMember = "ProductStatuseID";
            cbStatus.SelectedIndex = -1;
        }
        private void LodeCategory()
        {

            cbCategory.DataSource = _category.GetAllCategory();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.SelectedIndex = -1;
        }
        private void AddMode()
        {
            labTitale.Text = "Fill in all the fields below, then click 'Add Product' .";
            LodeImage("");
            botAddorUpdateUser.Text = "Add User";
        }
        private void UpdateMode()
        {
            labTitale.Text = "Fill in all the fields below, then click 'Update Product' .";
            botAddorUpdateUser.Text = "Update User";

              int CompanyID = 0; int CategoryID = 0;
            string ImagePath = ""; int ProductStatuseID = 0; string ProductName = ""; string Description = "";
            double CostPrice = 0; double sellingPrice = 0; int Quantity = 0; string Barcode = "";

            _Product.GetProductByProductID(ref _ProductID, ref CompanyID, ref CategoryID,
             ref ImagePath, ref ProductStatuseID, ref ProductName, ref Description,
             ref CostPrice, ref sellingPrice , ref Quantity, ref Barcode);
            if (_ProductID != -1 )
            {

                label1.Text = "ProductID : " + _ProductID;
                label1.Visible = true;
                txtBarcode.Text = Barcode;
                txtDescription.Text = Description ;
                txtProductName.Text = ProductName;
                txtSellingPrice.Text = Convert.ToDouble(sellingPrice).ToString() ;
                cbCategory.SelectedValue = Convert.ToInt32(CategoryID);
                cbCompany.SelectedValue = Convert.ToInt32(CompanyID);
                cbStatus.SelectedValue = Convert.ToInt32(ProductStatuseID);
                LodeImage(ImagePath);

                _CostPrice = CostPrice;   _Quantity = Quantity ;
                _sellingPrice = sellingPrice;
            }



        }
        private void InitializeMode(Mode mode)
        {

            LodeCompany();
            LodeCategory();
            LodeStatus();
            if (mode == Mode.Add)
            {
                AddMode();
            }
            else if (mode == Mode.Update)
            {
                UpdateMode();

            }



        }

        private void UCAddAndUpdateProduct_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabel1.Text == "Add Picture")
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Picture";
                    ofd.Filter = "صور مدعومة|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    ofd.Multiselect = false;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {

                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }

                        LodeImage(ofd.FileName);
                        _ImagePath = ofd.FileName;

                    }
                }
            }
            else if (linkLabel1.Text == "Remove Picture")
            {
                LodeImage("");
            }

        }

        private bool ErrorProviderOfTextBox(System.Windows.Forms.TextBox txtBox, string Message)
        {


            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {

                errorProvider1.SetError(txtBox, Message);
                return false;
            }
            else
            {

                errorProvider1.SetError(txtBox, "");
                return true;
            }
        }

        private bool ErrorProviderOfTextBox(System.Windows.Forms.ComboBox comboBox, string Message)
        {


            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {

                errorProvider1.SetError(comboBox, Message);
                return false;
            }
            else
            {

                errorProvider1.SetError(comboBox, "");
                return true;
            }
        }
 
        private void EnabledButton(bool isEnabled)
        {


            txtBarcode.Enabled = isEnabled;
            txtDescription.Enabled = isEnabled;
            txtProductName.Enabled = isEnabled;
            cbStatus.Enabled = isEnabled;
            cbCompany.Enabled = isEnabled;
            cbCategory.Enabled = isEnabled;
            linkLabel1.Enabled = isEnabled;
            botAddorUpdateUser.Enabled = isEnabled;
            button1.Enabled = isEnabled;
            txtSellingPrice.Enabled = isEnabled;
        }
        private void AddProduct()
        {
            if (ErrorProviderOfTextBox(txtBarcode, "Barcode is required!") &
            ErrorProviderOfTextBox(txtProductName, "Product Name is required!") &
            ErrorProviderOfTextBox(cbCategory, "Category is required!") &
            ErrorProviderOfTextBox(cbCompany, "Company is required!") &
            ErrorProviderOfTextBox(cbStatus, "Status is required!"))
            {
                double sellingPrice;
                try
                {
                      sellingPrice = Convert.ToDouble(txtSellingPrice.Text);

                }
                catch {
                    MessageBox.Show("Please Enter number is selling Price ,");
                    txtSellingPrice.Text = "";
                    return; 

                }


                _ProductID = _Product.AddProduct(Convert.ToInt32(cbCompany.SelectedValue), Convert.ToInt32(cbCategory.SelectedValue),
                   _ImagePath, Convert.ToInt32(cbStatus.SelectedValue), txtProductName.Text, txtDescription.Text, 0 , sellingPrice , 0, txtBarcode.Text);

                if (_ProductID != -1)
                {
                    MessageBox.Show("Add Product is Successfully . ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    EnabledButton(false);
                    label1.Text = "ProductID : " + _ProductID ;
                    label1.Visible = true ;
                }
                else
                {
                    MessageBox.Show("Add Product is not Successfully . ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }


        }

        private void UpdateProduct()
        {
            if (ErrorProviderOfTextBox(txtBarcode, "Barcode is required!") &
            ErrorProviderOfTextBox(txtProductName, "Product Name is required!") &
            ErrorProviderOfTextBox(cbCategory, "Category is required!") &
            ErrorProviderOfTextBox(cbCompany, "Company is required!") &
            ErrorProviderOfTextBox(cbStatus, "Status is required!"))
            {

                double sellingPrice;
                try
                {
                      sellingPrice = Convert.ToDouble(txtSellingPrice.Text);

                }
                catch
                {
                    MessageBox.Show("Please Enter number is selling Price ,");
                    txtSellingPrice.Text = "";
                    return;

                }

                if (_Product.UpdateProduct(_ProductID, Convert.ToInt32(cbCompany.SelectedValue), Convert.ToInt32(cbCategory.SelectedValue),
                   _ImagePath, Convert.ToInt32(cbStatus.SelectedValue), txtProductName.Text, txtDescription.Text, _CostPrice  , sellingPrice , _Quantity, txtBarcode.Text))
                {
                    MessageBox.Show("Update Product is Successfully . ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 
                }
                else
                {
                    MessageBox.Show("Update Product is not Successfully . ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        private void botAddorUpdateUser_Click(object sender, EventArgs e)
        {
            if (_Mode == Mode.Add)
            {

                AddProduct();
            }
            else if (_Mode == Mode.Update)
            {
                UpdateProduct();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtDescription.Text = "";
            txtBarcode.Text = "";
            cbCategory.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            cbCompany.SelectedIndex = -1;
            txtSellingPrice.Text = "";
            LodeImage("");
        }
    }
}
