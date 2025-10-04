using POSLogic;
using POSLogic.LogicUser;
using Project_Plint_of_Sale_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Plint_of_Sale_System
{
    public partial class UCAddAndUpdateUser : UserControl
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IUserStatus _statusService;

        public enum Mode { Add, Update };
        Mode _Mode;
        int _UserID;

        public UCAddAndUpdateUser(int UserID)
        {
            _UserID = UserID;
            if (UserID == -1)
                _Mode = Mode.Add;
            else
                _Mode = Mode.Update;
            InitializeComponent();

            _userService = ServiceFactory.CreateUserService();
            _statusService = ServiceFactory.CreateUserStatusService();
            _roleService = ServiceFactory.CreateRoleService();
            InitializeMode(_Mode);
            this.Dock = DockStyle.Fill;



        }


        private void LodeRole()
        {


            DataTable roles = _roleService.GetAllRoles();

            cbRole.DataSource = roles;
            cbRole.DisplayMember = "RoleName";
            cbRole.ValueMember = "RoleID";

            cbRole.SelectedIndex = -1;

        }

        private void LodeStatus()
        {


            DataTable Status = _statusService.GetStatus();

            cbStatuse.DataSource = Status;
            cbStatuse.DisplayMember = "StatusName";
            cbStatuse.ValueMember = "UserStatuseID";

            cbStatuse.SelectedIndex = -1;

        }

        private void EnabledButton(bool isEnabled)
        {


            txtEmail.Enabled = isEnabled;
            txtFirstName.Enabled = isEnabled;
            txtlastName.Enabled = isEnabled;
            txtPassword.Enabled = isEnabled;
            txtUserName.Enabled = isEnabled;
            cbRole.Enabled = isEnabled;
            cbStatuse.Enabled = isEnabled;
            botAddUser.Enabled = isEnabled;
            dtBirthDay.Enabled = isEnabled;
        }
        private void InitializeMode(Mode Mode)
        {


            LodeRole();
            LodeStatus();
            if (_Mode == Mode.Add)
            {
                labelTitale.Text = $" Fill in all the fields below, then click 'Add User'.";
                botAddUser.Text = "Add User";




            }
            else if (_Mode == Mode.Update)
            {
                labelTitale.Text = $" Fill in all the fields below, then click 'Update User'.";
                botAddUser.Text = "Update User";

                if (!_userService.IsUserExist(_UserID))
                {

                    EnabledButton(false);
                }
                else
                {
                    UserModel newUser;
                    newUser = _userService.GetUserByUserID(_UserID);


                    txtEmail.Text = newUser.Email;
                    txtFirstName.Text = newUser.FirstName;
                    txtlastName.Text = newUser.LastName;

                    txtUserName.Text = newUser.UserName ;
                    dtBirthDay.Value = newUser.BirthDate;


                    cbRole.SelectedValue = Convert.ToInt32(newUser.RoleID);
                    cbStatuse.SelectedValue = Convert.ToInt32(newUser.StatusID);

                    EnabledButton(true);


                }



            }


        }

        private bool ErrorProviderOfTextBox(TextBox button, string Message)
        {


            if (string.IsNullOrWhiteSpace(button.Text))
            {

                errorProvider1.SetError(button, Message);
                return false;
            }
            else
            {

                errorProvider1.SetError(button, "");
                return true;
            }
        }

        private bool ErrorProviderOfTextBox(ComboBox comboBox, string Message)
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

        private bool AllFieldIsCorrect()
        {
            bool check = false;

            check = ErrorProviderOfTextBox(txtFirstName, "First Name is required!") &
            ErrorProviderOfTextBox(txtlastName, "Last Name is required!") &
            ErrorProviderOfTextBox(txtEmail, "Email is required!") &
            //ErrorProviderOfTextBox(txtPassword, "Password is required!") &
            ErrorProviderOfTextBox(txtUserName, "User Name is required!") &
            ErrorProviderOfTextBox(cbRole, "Role is required!") &
            ErrorProviderOfTextBox(cbStatuse, "Status is required!");

            if (!check)
                return check;

            if (Mode.Add == _Mode)
            {

                if (_userService.UserNameIsExist(txtUserName.Text))
                {
                    MessageBox.Show($" This username '{txtUserName.Text}' already exists. Please choose another one. ", "Error");
                    check = false;
                    return check;
                }
            }

            return check;

        }

        private void AddUser()
        {

            UserModel newUser = new UserModel
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                RoleID = Convert.ToInt32(cbRole.SelectedValue),
                StatusID = Convert.ToInt32(cbStatuse.SelectedValue),
                FirstName = txtFirstName.Text,
                UserID = _UserID,
                LastName = txtlastName.Text,
                BirthDate = dtBirthDay.Value
            };


            int UserID = _userService.AddUser(newUser);
            if (UserID != -1)
            {
                _Mode = Mode.Update;
                UCAddAndUpdateUser ucUpdateUser = new UCAddAndUpdateUser(-1);
                ucUpdateUser.Dock = DockStyle.Fill;

                EnabledButton(false);
                MessageBox.Show("Add User is Successfully . ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Add User is not Successfully . ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UpdateUser()
        {
            UserModel newUser = new UserModel
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                RoleID = Convert.ToInt32(cbRole.SelectedValue),
                StatusID = Convert.ToInt32(cbStatuse.SelectedValue),
                FirstName = txtFirstName.Text,
                UserID = _UserID,
                LastName = txtlastName.Text,
                BirthDate = dtBirthDay.Value
            };


            if (_userService.UpdateUser(newUser))
            {
                MessageBox.Show("Update User is Successfully . ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Update User is not Successfully . ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private void botAddUser_Click(object sender, EventArgs e)
        {



            if (AllFieldIsCorrect())
            {


                if (Mode.Add == _Mode)
                {
                    AddUser();

                }
                else if (Mode.Update == _Mode)
                {
                    UpdateUser();
                }
            }

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedIndex == 0)
                pictureBox1.Image = Resources.Admin;
            else if (cbRole.SelectedIndex == 1)
                pictureBox1.Image = Resources.Chashier;



        }

    }
}
