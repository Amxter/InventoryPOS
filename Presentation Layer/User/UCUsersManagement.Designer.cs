namespace Project_Plint_of_Sale_System
{
    partial class UCUsersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUsersManagement));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListTable = new System.Windows.Forms.ImageList(this.components);
            this.tabPageUpdateUsers = new System.Windows.Forms.TabPage();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.tabCManagementUsers = new System.Windows.Forms.TabControl();
            this.tabPageListUsers = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAge = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPageUpdateUsers.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabCManagementUsers.SuspendLayout();
            this.tabPageListUsers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.updateToolStripMenuItem.Text = "Update User";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // imageListTable
            // 
            this.imageListTable.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTable.ImageStream")));
            this.imageListTable.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTable.Images.SetKeyName(0, "user.png");
            this.imageListTable.Images.SetKeyName(1, "user (1).png");
            this.imageListTable.Images.SetKeyName(2, "about.png");
            this.imageListTable.Images.SetKeyName(3, "refresh-button.png");
            // 
            // tabPageUpdateUsers
            // 
            this.tabPageUpdateUsers.Controls.Add(this.panelUpdate);
            this.tabPageUpdateUsers.ImageIndex = 3;
            this.tabPageUpdateUsers.Location = new System.Drawing.Point(4, 32);
            this.tabPageUpdateUsers.Name = "tabPageUpdateUsers";
            this.tabPageUpdateUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateUsers.Size = new System.Drawing.Size(1051, 703);
            this.tabPageUpdateUsers.TabIndex = 2;
            this.tabPageUpdateUsers.Text = "Update Users     ";
            this.tabPageUpdateUsers.UseVisualStyleBackColor = true;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUpdate.Location = new System.Drawing.Point(3, 218);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(1045, 482);
            this.panelUpdate.TabIndex = 1;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.panelAddUser);
            this.tabPageAddUser.ImageIndex = 1;
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 32);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1051, 703);
            this.tabPageAddUser.TabIndex = 1;
            this.tabPageAddUser.Text = "Add User     ";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            // 
            // panelAddUser
            // 
            this.panelAddUser.AutoScroll = true;
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAddUser.Location = new System.Drawing.Point(3, 218);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(1045, 482);
            this.panelAddUser.TabIndex = 0;
            // 
            // tabCManagementUsers
            // 
            this.tabCManagementUsers.Controls.Add(this.tabPageListUsers);
            this.tabCManagementUsers.Controls.Add(this.tabPageAddUser);
            this.tabCManagementUsers.Controls.Add(this.tabPageUpdateUsers);
            this.tabCManagementUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCManagementUsers.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCManagementUsers.ImageList = this.imageListTable;
            this.tabCManagementUsers.Location = new System.Drawing.Point(0, 0);
            this.tabCManagementUsers.Name = "tabCManagementUsers";
            this.tabCManagementUsers.SelectedIndex = 0;
            this.tabCManagementUsers.Size = new System.Drawing.Size(1059, 739);
            this.tabCManagementUsers.TabIndex = 2;
            this.tabCManagementUsers.SelectedIndexChanged += new System.EventHandler(this.tabCManagementUsers_SelectedIndexChanged);
            // 
            // tabPageListUsers
            // 
            this.tabPageListUsers.Controls.Add(this.panel1);
            this.tabPageListUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageListUsers.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageListUsers.ForeColor = System.Drawing.Color.Black;
            this.tabPageListUsers.ImageIndex = 2;
            this.tabPageListUsers.Location = new System.Drawing.Point(4, 32);
            this.tabPageListUsers.Name = "tabPageListUsers";
            this.tabPageListUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListUsers.Size = new System.Drawing.Size(1051, 703);
            this.tabPageListUsers.TabIndex = 0;
            this.tabPageListUsers.Text = "List Users     ";
            this.tabPageListUsers.UseVisualStyleBackColor = true;
            this.tabPageListUsers.Click += new System.EventHandler(this.tabPageListUsers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAge);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butUpdate);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelRole);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(500, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 296);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelAge.Location = new System.Drawing.Point(221, 172);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(69, 24);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age :  ";
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Red;
            this.butDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.butDelete.Location = new System.Drawing.Point(308, 226);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(123, 43);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.Color.Blue;
            this.butUpdate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.butUpdate.Location = new System.Drawing.Point(109, 226);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(123, 43);
            this.butUpdate.TabIndex = 5;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelEmail.Location = new System.Drawing.Point(221, 132);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(84, 24);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email :  ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelStatus.Location = new System.Drawing.Point(221, 92);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(85, 24);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status : ";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelRole.Location = new System.Drawing.Point(221, 52);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(68, 24);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Role : ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelName.Location = new System.Drawing.Point(221, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(21, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUsers.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 321);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 26;
            this.dataGridViewUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1045, 379);
            this.dataGridViewUsers.TabIndex = 1;
            this.dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);
            // 
            // UCUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabCManagementUsers);
            this.Name = "UCUsersManagement";
            this.Size = new System.Drawing.Size(1059, 739);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPageUpdateUsers.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabCManagementUsers.ResumeLayout(false);
            this.tabPageListUsers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageUpdateUsers;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.Panel panelAddUser;
        public System.Windows.Forms.TabControl tabCManagementUsers;
        private System.Windows.Forms.TabPage tabPageListUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAge;
    }
}
