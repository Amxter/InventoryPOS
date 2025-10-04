using POSLogic;
using POSLogic.LogicProduct;
using POSLogic.LogicUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POSLogic.LogicUser.UserService;
using static System.Collections.Specialized.BitVector32;

namespace Project_Plint_of_Sale_System
{
    public partial class FrmMain : Form
    {
        CurrentUser currentUser ;
    
        IProductService _Product;
        public FrmMain()
        {
            InitializeComponent();
            currentUser = new CurrentUser();
            _Product = ServiceFactory.CreateProductService();
        }

         
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            if (currentUser.GetRoleName() == "Admin")
                panelMain.Controls.Add(new UCAdminDashboard());
            else if (currentUser.GetRoleName() == "Cashier")
                panelMain.Controls.Add(new UCCashierDashboard());

        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
    }
}
