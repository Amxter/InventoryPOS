using System.Drawing;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    partial class UCAddAndUpdateUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labFirstName = new System.Windows.Forms.Label();
            this.labLastName = new System.Windows.Forms.Label();
            this.labRole = new System.Windows.Forms.Label();
            this.labStatuse = new System.Windows.Forms.Label();
            this.labBirthDay = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.cbStatuse = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.botAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstName.ForeColor = System.Drawing.Color.Black;
            this.labFirstName.Location = new System.Drawing.Point(12, 139);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(130, 26);
            this.labFirstName.TabIndex = 2;
            this.labFirstName.Text = "First Name : ";
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLastName.ForeColor = System.Drawing.Color.Black;
            this.labLastName.Location = new System.Drawing.Point(12, 170);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(132, 26);
            this.labLastName.TabIndex = 3;
            this.labLastName.Text = "Last Name  : ";
            // 
            // labRole
            // 
            this.labRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labRole.AutoSize = true;
            this.labRole.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRole.ForeColor = System.Drawing.Color.Black;
            this.labRole.Location = new System.Drawing.Point(362, 175);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(124, 26);
            this.labRole.TabIndex = 4;
            this.labRole.Text = "Role          : ";
            // 
            // labStatuse
            // 
            this.labStatuse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatuse.AutoSize = true;
            this.labStatuse.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStatuse.ForeColor = System.Drawing.Color.Black;
            this.labStatuse.Location = new System.Drawing.Point(361, 144);
            this.labStatuse.Name = "labStatuse";
            this.labStatuse.Size = new System.Drawing.Size(122, 26);
            this.labStatuse.TabIndex = 5;
            this.labStatuse.Text = "Statuse     : ";
            // 
            // labBirthDay
            // 
            this.labBirthDay.AutoSize = true;
            this.labBirthDay.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBirthDay.ForeColor = System.Drawing.Color.Black;
            this.labBirthDay.Location = new System.Drawing.Point(10, 203);
            this.labBirthDay.Name = "labBirthDay";
            this.labBirthDay.Size = new System.Drawing.Size(126, 26);
            this.labBirthDay.TabIndex = 6;
            this.labBirthDay.Text = "Birth Day   : ";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.ForeColor = System.Drawing.Color.Black;
            this.labEmail.Location = new System.Drawing.Point(10, 229);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(130, 26);
            this.labEmail.TabIndex = 7;
            this.labEmail.Text = "Email         : ";
            // 
            // labUserName
            // 
            this.labUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.Color.Black;
            this.labUserName.Location = new System.Drawing.Point(357, 236);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(129, 26);
            this.labUserName.TabIndex = 8;
            this.labUserName.Text = "User Name : ";
            // 
            // labPassword
            // 
            this.labPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.ForeColor = System.Drawing.Color.Black;
            this.labPassword.Location = new System.Drawing.Point(358, 205);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(125, 26);
            this.labPassword.TabIndex = 9;
            this.labPassword.Text = "Password   : ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(131, 143);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(221, 24);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtlastName
            // 
            this.txtlastName.Location = new System.Drawing.Point(131, 174);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(221, 24);
            this.txtlastName.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 24);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(475, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 24);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(475, 238);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 24);
            this.txtUserName.TabIndex = 14;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Location = new System.Drawing.Point(129, 205);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(221, 24);
            this.dtBirthDay.TabIndex = 15;
            // 
            // cbStatuse
            // 
            this.cbStatuse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatuse.FormattingEnabled = true;
            this.cbStatuse.Location = new System.Drawing.Point(475, 148);
            this.cbStatuse.Name = "cbStatuse";
            this.cbStatuse.Size = new System.Drawing.Size(182, 24);
            this.cbStatuse.TabIndex = 16;
           
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(475, 179);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(182, 24);
            this.cbRole.TabIndex = 17;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // botAddUser
            // 
            this.botAddUser.BackColor = System.Drawing.Color.Blue;
            this.botAddUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botAddUser.Location = new System.Drawing.Point(319, 265);
            this.botAddUser.Name = "botAddUser";
            this.botAddUser.Size = new System.Drawing.Size(120, 39);
            this.botAddUser.TabIndex = 18;
            this.botAddUser.Text = "Add User";
            this.botAddUser.UseVisualStyleBackColor = false;
            this.botAddUser.Click += new System.EventHandler(this.botAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Plint_of_Sale_System.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(19, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitale
            // 
            this.labelTitale.AutoSize = true;
            this.labelTitale.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitale.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelTitale.Location = new System.Drawing.Point(251, 27);
            this.labelTitale.Name = "labelTitale";
            this.labelTitale.Size = new System.Drawing.Size(637, 34);
            this.labelTitale.TabIndex = 20;
            this.labelTitale.Text = "Fill in all the fields below, then click \'Add User\' .";
            // 
            // UCAddAndUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelTitale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botAddUser);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.cbStatuse);
            this.Controls.Add(this.dtBirthDay);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labBirthDay);
            this.Controls.Add(this.labStatuse);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.labLastName);
            this.Controls.Add(this.labFirstName);
            this.Name = "UCAddAndUpdateUser";
            this.Size = new System.Drawing.Size(1054, 509);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Label labRole;
        private System.Windows.Forms.Label labStatuse;
        private System.Windows.Forms.Label labBirthDay;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DateTimePicker dtBirthDay;
        private System.Windows.Forms.ComboBox cbStatuse;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button botAddUser;
        private System.Windows.Forms.Label labelTitale;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

    //partial class UCAddAndUpdateUser
    //{
    //    private void InitializeLayout()
    //    {
    //        this.Dock = DockStyle.Fill;

    //        // --- Main panel to hold all inputs ---
    //        Panel mainPanel = new Panel
    //        {
    //            Dock = DockStyle.Fill,
    //            AutoScroll = true
    //        };
    //        this.Controls.Add(mainPanel);

    //        // --- Title ---
    //        labelTitale.Text = "Fill in all the fields below, then click 'Add User'.";
    //        labelTitale.Font = new Font("Bookman Old Style", 16, FontStyle.Italic);
    //        labelTitale.AutoSize = true;
    //        labelTitale.Location = new Point((mainPanel.Width - labelTitale.Width) / 2, 10);
    //        labelTitale.Anchor = AnchorStyles.Top;
    //        mainPanel.Controls.Add(labelTitale);

    //        int leftX = 20;
    //        int leftTextX = 150;
    //        int rightX = 550;
    //        int rightTextX = 700;
    //        int startY = 60;
    //        int rowHeight = 40;

    //        // Left side labels & textboxes
    //        void AddLeftRow(Label lab, TextBox tb, int row)
    //        {
    //            lab.Location = new Point(leftX, startY + row * rowHeight);
    //            lab.AutoSize = true;
    //            lab.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    //            tb.Location = new Point(leftTextX, startY + row * rowHeight);
    //            tb.Size = new Size(200, 24);
    //            tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //            mainPanel.Controls.Add(lab);
    //            mainPanel.Controls.Add(tb);
    //        }

    //        AddLeftRow(labFirstName, txtFirstName, 0);
    //        AddLeftRow(labLastName, txtlastName, 1);
    //        AddLeftRow(labEmail, txtEmail, 2);
    //        AddLeftRow(labBirthDay, new TextBox { Text = "" }, 3); // dtBirthDay

    //        // Right side labels & controls
    //        void AddRightRow(Label lab, Control ctrl, int row)
    //        {
    //            lab.Location = new Point(rightX, startY + row * rowHeight);
    //            lab.AutoSize = true;
    //            lab.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    //            ctrl.Location = new Point(rightTextX, startY + row * rowHeight);
    //            ctrl.Size = new Size(200, 24);
    //            ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    //            mainPanel.Controls.Add(lab);
    //            mainPanel.Controls.Add(ctrl);
    //        }

    //        AddRightRow(labStatuse, cbStatuse, 0);
    //        AddRightRow(labRole, cbRole, 1);
    //        AddRightRow(labPassword, txtPassword, 2);
    //        AddRightRow(labUserName, txtUserName, 3);

    //        // --- Add User Button ---
    //        botAddUser.Size = new Size(150, 40);
    //        botAddUser.Location = new Point((mainPanel.Width - botAddUser.Width) / 2, startY + 5 * rowHeight);
    //        botAddUser.Anchor = AnchorStyles.Top;
    //        mainPanel.Controls.Add(botAddUser);

    //        // --- PictureBox ---
    //        pictureBox1.Size = new Size(120, 120);
    //        pictureBox1.Location = new Point(20, startY + 6 * rowHeight);
    //        pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    //        mainPanel.Controls.Add(pictureBox1);
    //    }


    //    #region Fields
    //    private System.ComponentModel.IContainer components = null;
    //    private System.Windows.Forms.Label labFirstName, labLastName, labRole, labStatuse, labBirthDay, labEmail, labUserName, labPassword;
    //    private System.Windows.Forms.TextBox txtFirstName, txtlastName, txtEmail, txtPassword, txtUserName;
    //    private System.Windows.Forms.DateTimePicker dtBirthDay;
    //    private System.Windows.Forms.ComboBox cbStatuse, cbRole;
    //    private System.Windows.Forms.ErrorProvider errorProvider1;
    //    private System.Windows.Forms.Button botAddUser;
    //    private System.Windows.Forms.Label labelTitale;
    //    private System.Windows.Forms.PictureBox pictureBox1;
    //    #endregion
    //}

}
