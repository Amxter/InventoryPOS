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
    public partial class SearchInvoice : Form
    {
        public SearchInvoice()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UCSearchInvoice ucAddUser = new UCSearchInvoice();
            ucAddUser.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucAddUser);
            ucAddUser.BringToFront();
        }

        private void SearchInvoice_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
