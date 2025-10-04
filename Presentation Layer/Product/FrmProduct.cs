using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            butListProduct.PerformClick();                        
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
        }



        private void butAddProduct_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Add(new UCAddAndUpdateProduct(-1));


        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butListProduct_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Add(new USListProducts());
        }

        private void butUpdateProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butCompany_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Add(new UCCompany());

        }

        private void butCategory_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();

            panelDisplay.Controls.Add(new UCCategoryProduct());
        }
    }
}
