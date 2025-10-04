using POSLogic;
using POSLogic.LogicProduct;
using Project_Plint_of_Sale_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class USListProducts : UserControl
    {
        IProductService _Product;
       
 
        private void GetAllProduct()
        {
            dgvProducts.DataSource = _Product.GetAllProduct() ;
        }
        public USListProducts()
        {
       
            InitializeComponent();
            _Product = ServiceFactory.CreateProductService();
            
            GetAllProduct();
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvProducts.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }

        private void USListProducts_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(new UCSearchProduct(dgvProducts));
        }

        private void labStatus_Click(object sender, EventArgs e)
        {

        }
        private void InitializeGropeBox (DataRow dataRow)
        {

            labName.Text = "Name : " + dataRow["ProductName"].ToString();
            labCompany.Text = "Company : " + dataRow["CompanyName"].ToString();
            labBarCode.Text = "BarCode : " + dataRow["BarCode"].ToString();
            labCostPrice.Text = "CostPrice : " + dataRow["CostPrice"].ToString();
            labQuantity.Text = "Quantity : " + dataRow["Quantity"].ToString();
            labStatus.Text = "Status : " + dataRow["StatusName"].ToString();
 


            if (dataRow["ImagePath"].ToString() != "" )  
            {
                string imagePath = dataRow["ImagePath"].ToString(); 

                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;  
                }
                else
                {
                    MessageBox.Show("Image path is not exist or Image path is Wroeg ");
                    pictureBox1.Image = Resources.products   ;  
                }
            }
            else
            {
                pictureBox1.Image = Resources.products;  
            }

        }
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                DataRowView rowView = dgvProducts.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    InitializeGropeBox(rowView.Row);
                }
            }
             
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView rowView = dgvProducts.CurrentRow.DataBoundItem as DataRowView;

            int ProductID = Convert.ToInt32(rowView["ProductID"]);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the product with ID {ProductID}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {

                _Product.DeleteProduct(ProductID);
                GetAllProduct();
                MessageBox.Show("product deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            var parent = this.Parent;
            parent.Controls.Remove(this);

            DataRowView rowView = dgvProducts.CurrentRow.DataBoundItem as DataRowView;
            var ucUpdateProduct = new UCAddAndUpdateProduct(Convert.ToInt32(rowView["ProductID"]));
            ucUpdateProduct.Dock = DockStyle.Fill;

            
            parent.Controls.Add(ucUpdateProduct);
            ucUpdateProduct.BringToFront();

        }
    }
}
