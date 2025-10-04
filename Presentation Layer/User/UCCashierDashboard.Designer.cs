namespace Project_Plint_of_Sale_System
{
    partial class UCCashierDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCashierDashboard));
            this.labOclock = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labRole = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmOClock = new System.Windows.Forms.Timer(this.components);
            this.butInvoice = new System.Windows.Forms.Button();
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.butPurchaseInvoices = new System.Windows.Forms.Button();
            this.butDashboard = new System.Windows.Forms.Button();
            this.butUpdateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labOclock
            // 
            this.labOclock.AutoSize = true;
            this.labOclock.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOclock.Location = new System.Drawing.Point(180, 118);
            this.labOclock.Name = "labOclock";
            this.labOclock.Size = new System.Drawing.Size(106, 28);
            this.labOclock.TabIndex = 7;
            this.labOclock.Text = "00:00:00";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(181, 70);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(69, 21);
            this.labName.TabIndex = 6;
            this.labName.Text = "Name : ";
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRole.Location = new System.Drawing.Point(181, 32);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(59, 21);
            this.labRole.TabIndex = 5;
            this.labRole.Text = "Role : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Project_Plint_of_Sale_System.Properties.Resources.Chashier;
            this.pictureBox1.Location = new System.Drawing.Point(19, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tmOClock
            // 
            this.tmOClock.Interval = 1000;
            this.tmOClock.Tick += new System.EventHandler(this.tmOClock_Tick);
            // 
            // butInvoice
            // 
            this.butInvoice.BackColor = System.Drawing.Color.Transparent;
            this.butInvoice.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butInvoice.ImageIndex = 4;
            this.butInvoice.ImageList = this.imageListButton;
            this.butInvoice.Location = new System.Drawing.Point(19, 358);
            this.butInvoice.Name = "butInvoice";
            this.butInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butInvoice.Size = new System.Drawing.Size(258, 67);
            this.butInvoice.TabIndex = 13;
            this.butInvoice.Text = "  Invoice";
            this.butInvoice.UseVisualStyleBackColor = false;
            this.butInvoice.Click += new System.EventHandler(this.butInvoice_Click);
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
            // butPurchaseInvoices
            // 
            this.butPurchaseInvoices.BackColor = System.Drawing.Color.Transparent;
            this.butPurchaseInvoices.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPurchaseInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPurchaseInvoices.ImageIndex = 5;
            this.butPurchaseInvoices.ImageList = this.imageListButton;
            this.butPurchaseInvoices.Location = new System.Drawing.Point(19, 465);
            this.butPurchaseInvoices.Name = "butPurchaseInvoices";
            this.butPurchaseInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butPurchaseInvoices.Size = new System.Drawing.Size(258, 76);
            this.butPurchaseInvoices.TabIndex = 12;
            this.butPurchaseInvoices.Text = "       Purchase           Invoices ";
            this.butPurchaseInvoices.UseVisualStyleBackColor = false;
            this.butPurchaseInvoices.Click += new System.EventHandler(this.butPurchaseInvoices_Click);
            // 
            // butDashboard
            // 
            this.butDashboard.BackColor = System.Drawing.Color.Transparent;
            this.butDashboard.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDashboard.ImageIndex = 3;
            this.butDashboard.ImageList = this.imageListButton;
            this.butDashboard.Location = new System.Drawing.Point(19, 251);
            this.butDashboard.Name = "butDashboard";
            this.butDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butDashboard.Size = new System.Drawing.Size(258, 67);
            this.butDashboard.TabIndex = 11;
            this.butDashboard.Text = "  Dashboard";
            this.butDashboard.UseVisualStyleBackColor = false;
            this.butDashboard.Click += new System.EventHandler(this.butDashboard_Click);
            // 
            // butUpdateProduct
            // 
            this.butUpdateProduct.BackColor = System.Drawing.Color.Transparent;
            this.butUpdateProduct.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butUpdateProduct.ImageIndex = 6;
            this.butUpdateProduct.ImageList = this.imageListButton;
            this.butUpdateProduct.Location = new System.Drawing.Point(19, 604);
            this.butUpdateProduct.Name = "butUpdateProduct";
            this.butUpdateProduct.Size = new System.Drawing.Size(76, 65);
            this.butUpdateProduct.TabIndex = 14;
            this.butUpdateProduct.UseVisualStyleBackColor = false;
            this.butUpdateProduct.Click += new System.EventHandler(this.butUpdateProduct_Click);
            // 
            // UCCashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.butUpdateProduct);
            this.Controls.Add(this.butInvoice);
            this.Controls.Add(this.butPurchaseInvoices);
            this.Controls.Add(this.butDashboard);
            this.Controls.Add(this.labOclock);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCCashierDashboard";
            this.Size = new System.Drawing.Size(307, 739);
            this.Load += new System.EventHandler(this.UCCashierDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOclock;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labRole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmOClock;
        private System.Windows.Forms.Button butInvoice;
        private System.Windows.Forms.Button butPurchaseInvoices;
        private System.Windows.Forms.Button butDashboard;
        private System.Windows.Forms.ImageList imageListButton;
        public System.Windows.Forms.Button butUpdateProduct;
    }
}
