using POSLogic;
using POSLogic.LogicInvoice;
using POSLogic.LogicProduct;
using POSLogic.LogicUser;
using Project_Plint_of_Sale_System.Invoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class AddInvoice : Form
    {
        IProductService _Product;
        IInvoiceStatus _invoiceStatus;
        IInvoiceSarvice _invoiceSarvice;
        DataTable _InvoiceTable;
        int _invoiceID = 0;
        string _numberInvoice = "";

        enum Mode { Add , Update  }
        Mode _mode;
        private void GetAllProduct()
        {
            dataGridView1.DataSource = _Product.GetAllProduct();
        }
        private void Initialize ()
        {
            InitializeComponent();
            _Product = ServiceFactory.CreateProductService();
            _invoiceStatus = ServiceFactory.CreateInvoiceStatus();
            _invoiceSarvice = ServiceFactory.CreateInvoiceService();
            GetAllProduct();
            comboBox1.DataSource = _invoiceStatus.ListStatus();
            comboBox1.DisplayMember = "StatusName";
            comboBox1.ValueMember = "InvoiceStatusID"; 
        }
        public AddInvoice()
        {
            Initialize();
            _mode = Mode.Add;

        }
        public AddInvoice(int invoiceID , string StatusName , string NumberInvoice )
        {
            ;
            Initialize();
            _invoiceID = invoiceID;
            _numberInvoice = NumberInvoice;
            _InvoiceTable = _invoiceSarvice.GetDetailsInfoInvoiceByInvoiceID(invoiceID);
            _InvoiceTable.Columns["Price"].ColumnName = "SellingPrice";
            botAddorUpdateUser.Text = "Update Invoice";
            label2.Text = "$" + TotalPrice().ToString();
            comboBox1.SelectedText = StatusName ;
            _mode = Mode.Update ;

        }
        private double TotalPrice( )
        {
            double Price = 0;
            foreach (DataRow dataRow in _InvoiceTable.Rows)
            { 
                Price += Convert.ToDouble(dataRow["SellingPrice"]) * Convert.ToInt32(dataRow["Quantity"]) ;
            }

            return Price; 
           
        }
        private double UpdateInvoice(DataTable dataTable)
        {

            double totalAmount = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalAmount += Convert.ToDouble(row["TotalAmount"]);
            }

            return totalAmount;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView rowView = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

                foreach (DataRow dataRow in _InvoiceTable.Rows)
                {
                    if (rowView.Row["ProductID"].ToString() == dataRow["ProductID"].ToString())
                    {
                        if ((Convert.ToInt32(dataRow["Quantity"]) + 1) <= Convert.ToInt32(rowView["Quantity"]))
                        {
                            dataRow["Quantity"] = (Convert.ToInt32(dataRow["Quantity"]) + 1).ToString();
                            label2.Text = "$" + TotalPrice().ToString();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("This product is out of stock");
                        }
                    }
                }
                if (rowView != null)
                {
                    if ( 1 <= Convert.ToInt32(rowView["Quantity"]))
                    {
                        //if (_mode == Mode.Add)
                        //{
                            _InvoiceTable.Rows.Add(rowView.Row["ProductID"],
                            rowView.Row["ProductName"],
                            rowView.Row["SellingPrice"], 1);
                        //}
                        //else if(_mode == Mode.Update)
                        //{
                        //    _InvoiceTable.Rows.Add(rowView.Row["ProductID"],
                        //    rowView.Row["ProductName"],
                        //    rowView.Row["Price"], 1);

                        //}
                    }
                    else
                    {
                        MessageBox.Show("This product is out of stock");
                    }


                }
            }
            label2.Text = "$" + TotalPrice().ToString();

        }
        private void botAddorUpdateUser_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.Add)
            {
            CurrentUser currentUser = new CurrentUser();
            if (TotalPrice() != 0 )
            {
              if (  _invoiceSarvice.AddInvoice("", Convert.ToInt32( comboBox1.SelectedValue), currentUser.GetUserID() , TotalPrice(), DateTime.Now , _InvoiceTable ) != -1  )
                {
                    MessageBox.Show("Add is successfully ");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show( "Please Choose Product ","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            else if (_mode == Mode.Update) 
            {
                CurrentUser currentUser = new CurrentUser();
                if (TotalPrice() != 0)
                {
                    if (_invoiceSarvice.UpdateInvoice( _invoiceID , _numberInvoice , Convert.ToInt32(comboBox1.SelectedValue), currentUser.GetUserID(), TotalPrice(), DateTime.Now , _InvoiceTable ))
                    {
                        MessageBox.Show("Update is successfully ");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Choose Product ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void AddInvoice_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
              if (_mode == Mode.Add) {
                _InvoiceTable = new DataTable();
            _InvoiceTable.Columns.Add("ProductID");
            _InvoiceTable.Columns.Add("ProductName");
            _InvoiceTable.Columns.Add("SellingPrice");
            _InvoiceTable.Columns.Add("Quantity");
            }


            panel1.Controls.Add(new UCSearchProduct(dataGridView1));
           
                

        }
        private void linkLabelShowDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = _InvoiceTable;
            DetailsInvoice detailsInvoice = new DetailsInvoice(_InvoiceTable);
            detailsInvoice.ShowDialog();
            GetAllProduct();
            label2.Text = "$" + TotalPrice().ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null; 
            _InvoiceTable.Clear();
            label2.Text = "$" + TotalPrice().ToString();
        }
    }
}
