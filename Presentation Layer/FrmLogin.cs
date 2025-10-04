using POSLogic;
using POSLogic.LogicUser;
using Project_Plint_of_Sale_System;
using System;
 
using System.Windows.Forms;
 


namespace Project_Plint_of_Sale_System
{
    public partial class FrmLogin : Form
    {
        private readonly IUserService _userService;


        public FrmLogin()
        {
            _userService = ServiceFactory.CreateUserService();
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mktbPassword.PasswordChar = '\0';
            }
            else
            {
                mktbPassword.PasswordChar = '●';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {

                errorProvider1.SetError(tbUserName, "User Name is required!");
                return;
            }
            else
            {

                errorProvider1.SetError(tbUserName, "");
            }

            if (string.IsNullOrWhiteSpace(mktbPassword.Text))
            {

                errorProvider1.SetError(mktbPassword, "Password is required!");
                return;
            }
            else
            {

                errorProvider1.SetError(mktbPassword, "");
            }

            if (_userService.LoginUser(tbUserName.Text, mktbPassword.Text))
            {
                CurrentUser currentUser = new CurrentUser();

                if (!currentUser.IsActive())
                {
                    MessageBox.Show("Can not login in system , you should connection admin . ", "Wrony", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Close();


            }
            else
            {
                MessageBox.Show("Password or User Name is mistake ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }

}

