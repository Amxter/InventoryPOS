using POSLogic.LogicUser;
using Project_Plint_of_Sale_System.Properties;
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

namespace Project_Plint_of_Sale_System
{
    public partial class UCAdminDashboard : UserControl
    {
        CurrentUser currentUser;
 
          
        private void _initializationInfo()
        {

            pictureBox1.Image = Resources.Admin;
            labOclock.Text = DateTime.Now.ToLongTimeString();
            labName.Text += currentUser.GetFirstName() ;
            labRole.Text += currentUser.GetRoleName();
           tmOClock.Start();

        }
        public UCAdminDashboard()
        {
            InitializeComponent();
            currentUser = new CurrentUser();
            _initializationInfo();
        }

        private void tmOClock_Tick(object sender, EventArgs e)
        {


            labOclock.Text  = DateTime.Now.ToLongTimeString()   ;
        }

        private void UCAdminDashboard_Load(object sender, EventArgs e)
        {
            butDashboard.PerformClick();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((FrmMain)this.ParentForm).panelShow.Controls.Clear();
            ((FrmMain)this.ParentForm).panelShow.Controls.Add(new UCUsersManagement());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void butProducts_Click(object sender, EventArgs e)
        {
            FrmProduct product = new FrmProduct();
            product.ShowDialog();

        }

        private void butInvoice_Click(object sender, EventArgs e)
        {
            ((FrmMain)this.ParentForm).panelShow.Controls.Clear();
            ((FrmMain)this.ParentForm).panelShow.Controls.Add(new UCInvoiceManagement());


        }

        private void butPurchaseInvoices_Click(object sender, EventArgs e)
        {
            
            ((FrmMain)this.ParentForm).panelShow.Controls.Clear();
            ((FrmMain)this.ParentForm).panelShow.Controls.Add(new UCPurchaseInvoices());
        }

        private void butDashboard_Click(object sender, EventArgs e)
        {
            
           ((FrmMain)this.ParentForm).panelShow.Controls.Clear();
            ((FrmMain)this.ParentForm).panelShow.Controls.Add(new UCDashboardAdmin());
        }

        private void butUpdateProduct_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                FrmLogin frmLogin = new FrmLogin();
 
                parentForm.Hide();

                DialogResult result = frmLogin.ShowDialog();

  
                    parentForm.Close();
        
            }

        }
    }
}
