 



using POSLogic.LogicUser;
using Project_Plint_of_Sale_System.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    public partial class UCUsersManagement : UserControl
    {



        private readonly IUserService _userService;
       
        private void GetUsers()
        {
            dataGridViewUsers.DataSource = _userService.GetAllUsers();


        }

        public UCUsersManagement()
        {
            InitializeComponent();
          
            _userService = POSLogic.ServiceFactory.CreateUserService(); 
            tabCManagementUsers.TabIndex = 0 ;

            GetUsers();
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridViewUsers.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }

        private void tabCManagementUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCManagementUsers.SelectedIndex == 0)
            {
                GetUsers();
            }
            else if (tabCManagementUsers.SelectedIndex == 1)
            {
               UCAddAndUpdateUser ucAddUser = new UCAddAndUpdateUser(-1);
               ucAddUser.Dock = DockStyle.Fill;
               panelAddUser.Controls.Add(ucAddUser);
               ucAddUser.BringToFront();
            }
            else if (tabCManagementUsers.SelectedIndex == 2)
            {


                UCAddAndUpdateUser ucUpdateUser = new UCAddAndUpdateUser(0);
                ucUpdateUser.Dock = DockStyle.Fill;
                panelUpdate.Controls.Add(ucUpdateUser);
               
                ucUpdateUser.BringToFront();
            }
        }

        private void ShowInfoUser(DataRow dataRow)
        {
            panel1.Visible = true;
            labelName.Text = "Full Name: " + dataRow["FirstName"].ToString() + " " + dataRow["LastName"].ToString();
            labelRole.Text = "Role : " + dataRow["RoleName"].ToString();
            labelStatus.Text = "Status : " + dataRow["StatusName"].ToString();
            labelEmail.Text = "Email : " + dataRow["Email"].ToString();
            labelAge.Text = "Age : " + dataRow["Age"].ToString();

            if (dataRow["RoleName"].ToString() == "Admin")
            {
                pictureBox2.Image = Resources.Admin;
            }
            else if (dataRow["RoleName"].ToString() == "Cashier")
            {
                pictureBox2.Image = Resources.Chashier;
            }
 
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow != null)
            {
                DataRowView rowView = dataGridViewUsers.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    ShowInfoUser(rowView.Row);
                }
            }
        }

        private void DeleteUserOfSelected()
        {
            DataRowView rowView = dataGridViewUsers.CurrentRow.DataBoundItem as DataRowView;

            int userId = Convert.ToInt32(rowView["UserID"]);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the user with ID {userId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {

                _userService.DeleteUser(userId);
                GetUsers();
                MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void UpdateUserOfSelected()
        {
            tabCManagementUsers.SelectTab(2);


            DataRowView rowView = dataGridViewUsers.CurrentRow.DataBoundItem as DataRowView;
            UCAddAndUpdateUser ucUpdateUser = new UCAddAndUpdateUser(Convert.ToInt32(rowView["UserID"]));
            ucUpdateUser.Dock = DockStyle.Fill;
            panelUpdate.Controls.Add(ucUpdateUser);


            ucUpdateUser.BringToFront();

        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateUserOfSelected();

        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUserOfSelected();


        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            UpdateUserOfSelected();


        }
        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteUserOfSelected();
        }

        private void tabPageListUsers_Click(object sender, EventArgs e)
        {

        }
    }
}

