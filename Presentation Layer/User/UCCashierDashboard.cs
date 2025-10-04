using POSLogic.LogicUser;
using Project_Plint_of_Sale_System.Properties;
using Project_Plint_of_Sale_System.User;
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
    public partial class UCCashierDashboard : UserControl
    {
        CurrentUser currentUser;
       
        private void _initializationInfo()
        {

            pictureBox1.Image = Resources.Chashier;
            labOclock.Text = DateTime.Now.ToLongTimeString();
            labName.Text += currentUser.GetFirstName() ;
            labRole.Text += currentUser.GetRoleName();
            tmOClock.Start();

        }
        public UCCashierDashboard()
        {
            InitializeComponent();
            currentUser = new CurrentUser();
            _initializationInfo();
          
        }
 

        private void tmOClock_Tick(object sender, EventArgs e)
        {
            labOclock.Text = DateTime.Now.ToLongTimeString(); 
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

        private void butDashboard_Click(object sender, EventArgs e)
        {
            
                          ((FrmMain)this.ParentForm).panelShow.Controls.Clear();
            ((FrmMain)this.ParentForm).panelShow.Controls.Add(new UCDashboardCashier());
        }

        private void UCCashierDashboard_Load(object sender, EventArgs e)
        {
            butDashboard.PerformClick(); 
        }
    }
}
