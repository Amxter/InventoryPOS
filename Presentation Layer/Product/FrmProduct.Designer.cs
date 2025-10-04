namespace Project_Plint_of_Sale_System
{
    partial class FrmProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.panelDashboardProduct = new System.Windows.Forms.Panel();
            this.butUpdateProduct = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.butCategory = new System.Windows.Forms.Button();
            this.butCompany = new System.Windows.Forms.Button();
            this.butAddProduct = new System.Windows.Forms.Button();
            this.butListProduct = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelDashboardProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashboardProduct
            // 
            this.panelDashboardProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDashboardProduct.Controls.Add(this.butUpdateProduct);
            this.panelDashboardProduct.Controls.Add(this.butCategory);
            this.panelDashboardProduct.Controls.Add(this.butCompany);
            this.panelDashboardProduct.Controls.Add(this.butAddProduct);
            this.panelDashboardProduct.Controls.Add(this.butListProduct);
            this.panelDashboardProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashboardProduct.Location = new System.Drawing.Point(0, 0);
            this.panelDashboardProduct.Name = "panelDashboardProduct";
            this.panelDashboardProduct.Size = new System.Drawing.Size(248, 649);
            this.panelDashboardProduct.TabIndex = 0;
            // 
            // butUpdateProduct
            // 
            this.butUpdateProduct.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butUpdateProduct.ImageIndex = 5;
            this.butUpdateProduct.ImageList = this.imageList1;
            this.butUpdateProduct.Location = new System.Drawing.Point(45, 564);
            this.butUpdateProduct.Name = "butUpdateProduct";
            this.butUpdateProduct.Size = new System.Drawing.Size(78, 73);
            this.butUpdateProduct.TabIndex = 2;
            this.butUpdateProduct.UseVisualStyleBackColor = true;
            this.butUpdateProduct.Click += new System.EventHandler(this.butUpdateProduct_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "products.png");
            this.imageList1.Images.SetKeyName(1, "add-to-cart.png");
            this.imageList1.Images.SetKeyName(2, "update.png");
            this.imageList1.Images.SetKeyName(3, "factory.png");
            this.imageList1.Images.SetKeyName(4, "folder-management.png");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // butCategory
            // 
            this.butCategory.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCategory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.butCategory.ImageIndex = 4;
            this.butCategory.ImageList = this.imageList1;
            this.butCategory.Location = new System.Drawing.Point(12, 403);
            this.butCategory.Name = "butCategory";
            this.butCategory.Size = new System.Drawing.Size(225, 68);
            this.butCategory.TabIndex = 4;
            this.butCategory.Text = "       Category";
            this.butCategory.UseVisualStyleBackColor = true;
            this.butCategory.Click += new System.EventHandler(this.butCategory_Click);
            // 
            // butCompany
            // 
            this.butCompany.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCompany.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.butCompany.ImageIndex = 3;
            this.butCompany.ImageList = this.imageList1;
            this.butCompany.Location = new System.Drawing.Point(12, 310);
            this.butCompany.Name = "butCompany";
            this.butCompany.Size = new System.Drawing.Size(225, 68);
            this.butCompany.TabIndex = 3;
            this.butCompany.Text = "       Company";
            this.butCompany.UseVisualStyleBackColor = true;
            this.butCompany.Click += new System.EventHandler(this.butCompany_Click);
            // 
            // butAddProduct
            // 
            this.butAddProduct.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddProduct.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.butAddProduct.ImageIndex = 1;
            this.butAddProduct.ImageList = this.imageList1;
            this.butAddProduct.Location = new System.Drawing.Point(12, 224);
            this.butAddProduct.Name = "butAddProduct";
            this.butAddProduct.Size = new System.Drawing.Size(225, 68);
            this.butAddProduct.TabIndex = 1;
            this.butAddProduct.Text = "       Add Product";
            this.butAddProduct.UseVisualStyleBackColor = true;
            this.butAddProduct.Click += new System.EventHandler(this.butAddProduct_Click);
            // 
            // butListProduct
            // 
            this.butListProduct.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butListProduct.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.butListProduct.ImageIndex = 0;
            this.butListProduct.ImageList = this.imageList1;
            this.butListProduct.Location = new System.Drawing.Point(12, 131);
            this.butListProduct.Name = "butListProduct";
            this.butListProduct.Size = new System.Drawing.Size(225, 68);
            this.butListProduct.TabIndex = 0;
            this.butListProduct.Text = "        Products";
            this.butListProduct.UseVisualStyleBackColor = true;
            this.butListProduct.Click += new System.EventHandler(this.butListProduct_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.White;
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDisplay.Location = new System.Drawing.Point(247, 0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1021, 649);
            this.panelDisplay.TabIndex = 1;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1268, 649);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelDashboardProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panelDashboardProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboardProduct;
        private System.Windows.Forms.Button butListProduct;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Button butAddProduct;
        private System.Windows.Forms.Button butCategory;
        private System.Windows.Forms.Button butCompany;
        public System.Windows.Forms.Button butUpdateProduct;
    }
}