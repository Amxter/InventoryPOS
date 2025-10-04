namespace Project_Plint_of_Sale_System
{
    partial class UCAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAdminDashboard));
            this.labRole = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labOclock = new System.Windows.Forms.Label();
            this.tmOClock = new System.Windows.Forms.Timer(this.components);
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.butUsers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butProducts = new System.Windows.Forms.Button();
            this.butDashboard = new System.Windows.Forms.Button();
            this.butPurchaseInvoices = new System.Windows.Forms.Button();
            this.butInvoice = new System.Windows.Forms.Button();
            this.butUpdateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRole.Location = new System.Drawing.Point(177, 29);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(59, 21);
            this.labRole.TabIndex = 1;
            this.labRole.Text = "Role : ";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(177, 66);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(69, 21);
            this.labName.TabIndex = 2;
            this.labName.Text = "Name : ";
            // 
            // labOclock
            // 
            this.labOclock.AutoSize = true;
            this.labOclock.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOclock.Location = new System.Drawing.Point(177, 112);
            this.labOclock.Name = "labOclock";
            this.labOclock.Size = new System.Drawing.Size(106, 28);
            this.labOclock.TabIndex = 3;
            this.labOclock.Text = "00:00:00";
            // 
            // tmOClock
            // 
            this.tmOClock.Interval = 1000;
            this.tmOClock.Tick += new System.EventHandler(this.tmOClock_Tick);
            // 
            // imageListButton
            // 
            this.imageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton.ImageStream")));
            this.imageListButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton.Images.SetKeyName(0, "user-profile.png");
            this.imageListButton.Images.SetKeyName(1, "Product.png");
            this.imageListButton.Images.SetKeyName(2, "team.png");
            this.imageListButton.Images.SetKeyName(3, "dashboard.png");
            this.imageListButton.Images.SetKeyName(4, "invoice.png");
            this.imageListButton.Images.SetKeyName(5, "procurement.png");
            this.imageListButton.Images.SetKeyName(6, "logout.png");
            // 
            // butUsers
            // 
            this.butUsers.BackColor = System.Drawing.Color.Transparent;
            this.butUsers.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUsers.ImageIndex = 2;
            this.butUsers.ImageList = this.imageListButton;
            this.butUsers.Location = new System.Drawing.Point(15, 308);
            this.butUsers.Name = "butUsers";
            this.butUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butUsers.Size = new System.Drawing.Size(258, 67);
            this.butUsers.TabIndex = 4;
            this.butUsers.Text = "Users";
            this.butUsers.UseVisualStyleBackColor = false;
            this.butUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Plint_of_Sale_System.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // butProducts
            // 
            this.butProducts.BackColor = System.Drawing.Color.Transparent;
            this.butProducts.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butProducts.ImageIndex = 1;
            this.butProducts.ImageList = this.imageListButton;
            this.butProducts.Location = new System.Drawing.Point(15, 398);
            this.butProducts.Name = "butProducts";
            this.butProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butProducts.Size = new System.Drawing.Size(258, 67);
            this.butProducts.TabIndex = 5;
            this.butProducts.Text = "  Products";
            this.butProducts.UseVisualStyleBackColor = false;
            this.butProducts.Click += new System.EventHandler(this.butProducts_Click);
            // 
            // butDashboard
            // 
            this.butDashboard.BackColor = System.Drawing.Color.Transparent;
            this.butDashboard.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDashboard.ImageIndex = 3;
            this.butDashboard.ImageList = this.imageListButton;
            this.butDashboard.Location = new System.Drawing.Point(15, 218);
            this.butDashboard.Name = "butDashboard";
            this.butDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butDashboard.Size = new System.Drawing.Size(258, 67);
            this.butDashboard.TabIndex = 6;
            this.butDashboard.Text = "  Dashboard";
            this.butDashboard.UseVisualStyleBackColor = false;
            this.butDashboard.Click += new System.EventHandler(this.butDashboard_Click);
            // 
            // butPurchaseInvoices
            // 
            this.butPurchaseInvoices.BackColor = System.Drawing.Color.Transparent;
            this.butPurchaseInvoices.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPurchaseInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPurchaseInvoices.ImageIndex = 5;
            this.butPurchaseInvoices.ImageList = this.imageListButton;
            this.butPurchaseInvoices.Location = new System.Drawing.Point(15, 578);
            this.butPurchaseInvoices.Name = "butPurchaseInvoices";
            this.butPurchaseInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butPurchaseInvoices.Size = new System.Drawing.Size(258, 76);
            this.butPurchaseInvoices.TabIndex = 7;
            this.butPurchaseInvoices.Text = "       Purchase           Invoices ";
            this.butPurchaseInvoices.UseVisualStyleBackColor = false;
            this.butPurchaseInvoices.Click += new System.EventHandler(this.butPurchaseInvoices_Click);
            // 
            // butInvoice
            // 
            this.butInvoice.BackColor = System.Drawing.Color.Transparent;
            this.butInvoice.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butInvoice.ImageIndex = 4;
            this.butInvoice.ImageList = this.imageListButton;
            this.butInvoice.Location = new System.Drawing.Point(15, 488);
            this.butInvoice.Name = "butInvoice";
            this.butInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butInvoice.Size = new System.Drawing.Size(258, 67);
            this.butInvoice.TabIndex = 8;
            this.butInvoice.Text = "  Invoice";
            this.butInvoice.UseVisualStyleBackColor = false;
            this.butInvoice.Click += new System.EventHandler(this.butInvoice_Click);
            // 
            // butUpdateProduct
            // 
            this.butUpdateProduct.BackColor = System.Drawing.Color.Transparent;
            this.butUpdateProduct.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butUpdateProduct.ImageIndex = 6;
            this.butUpdateProduct.ImageList = this.imageListButton;
            this.butUpdateProduct.Location = new System.Drawing.Point(15, 672);
            this.butUpdateProduct.Name = "butUpdateProduct";
            this.butUpdateProduct.Size = new System.Drawing.Size(72, 64);
            this.butUpdateProduct.TabIndex = 9;
            this.butUpdateProduct.UseVisualStyleBackColor = false;
            this.butUpdateProduct.Click += new System.EventHandler(this.butUpdateProduct_Click);
            // 
            // UCAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.butUpdateProduct);
            this.Controls.Add(this.labOclock);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butInvoice);
            this.Controls.Add(this.butPurchaseInvoices);
            this.Controls.Add(this.butDashboard);
            this.Controls.Add(this.butProducts);
            this.Controls.Add(this.butUsers);
            this.Name = "UCAdminDashboard";
            this.Size = new System.Drawing.Size(307, 739);
            this.Load += new System.EventHandler(this.UCAdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labRole;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labOclock;
        private System.Windows.Forms.Timer tmOClock;
        private System.Windows.Forms.Button butUsers;
        private System.Windows.Forms.ImageList imageListButton;
        private System.Windows.Forms.Button butProducts;
        private System.Windows.Forms.Button butDashboard;
        private System.Windows.Forms.Button butPurchaseInvoices;
        private System.Windows.Forms.Button butInvoice;
        public System.Windows.Forms.Button butUpdateProduct;
    }
}
