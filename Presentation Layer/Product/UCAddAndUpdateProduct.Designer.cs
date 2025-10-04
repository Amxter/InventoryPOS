namespace Project_Plint_of_Sale_System
{
    partial class UCAddAndUpdateProduct
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
            this.labTitale = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botAddorUpdateUser = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.labBarcode = new System.Windows.Forms.Label();
            this.labCompany = new System.Windows.Forms.Label();
            this.labRole = new System.Windows.Forms.Label();
            this.labProductName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitale
            // 
            this.labTitale.AutoSize = true;
            this.labTitale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labTitale.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitale.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labTitale.Location = new System.Drawing.Point(263, 93);
            this.labTitale.Name = "labTitale";
            this.labTitale.Size = new System.Drawing.Size(677, 34);
            this.labTitale.TabIndex = 39;
            this.labTitale.Text = "Fill in all the fields below, then click \'Add Product\' .";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Plint_of_Sale_System.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(46, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // botAddorUpdateUser
            // 
            this.botAddorUpdateUser.BackColor = System.Drawing.Color.Blue;
            this.botAddorUpdateUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botAddorUpdateUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botAddorUpdateUser.Location = new System.Drawing.Point(357, 502);
            this.botAddorUpdateUser.Name = "botAddorUpdateUser";
            this.botAddorUpdateUser.Size = new System.Drawing.Size(133, 50);
            this.botAddorUpdateUser.TabIndex = 37;
            this.botAddorUpdateUser.Text = "Add User";
            this.botAddorUpdateUser.UseVisualStyleBackColor = false;
            this.botAddorUpdateUser.Click += new System.EventHandler(this.botAddorUpdateUser_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(669, 360);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(219, 24);
            this.cbCategory.TabIndex = 36;
            // 
            // cbCompany
            // 
            this.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(669, 310);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(221, 24);
            this.cbCompany.TabIndex = 35;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(671, 460);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(221, 24);
            this.txtBarcode.TabIndex = 32;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(205, 314);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(221, 24);
            this.txtProductName.TabIndex = 29;
            // 
            // labBarcode
            // 
            this.labBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labBarcode.AutoSize = true;
            this.labBarcode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labBarcode.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarcode.ForeColor = System.Drawing.Color.Black;
            this.labBarcode.Location = new System.Drawing.Point(541, 456);
            this.labBarcode.Name = "labBarcode";
            this.labBarcode.Size = new System.Drawing.Size(122, 26);
            this.labBarcode.TabIndex = 28;
            this.labBarcode.Text = "Barcode    : ";
            // 
            // labCompany
            // 
            this.labCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCompany.AutoSize = true;
            this.labCompany.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labCompany.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCompany.ForeColor = System.Drawing.Color.Black;
            this.labCompany.Location = new System.Drawing.Point(540, 306);
            this.labCompany.Name = "labCompany";
            this.labCompany.Size = new System.Drawing.Size(126, 26);
            this.labCompany.TabIndex = 24;
            this.labCompany.Text = "Company   : ";
            // 
            // labRole
            // 
            this.labRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labRole.AutoSize = true;
            this.labRole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labRole.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRole.ForeColor = System.Drawing.Color.Black;
            this.labRole.Location = new System.Drawing.Point(539, 356);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(124, 26);
            this.labRole.TabIndex = 23;
            this.labRole.Text = "Category   : ";
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labProductName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProductName.ForeColor = System.Drawing.Color.Black;
            this.labProductName.Location = new System.Drawing.Point(41, 310);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(158, 26);
            this.labProductName.TabIndex = 21;
            this.labProductName.Text = "Product Name : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(11, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 24);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add picture";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(671, 410);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(219, 24);
            this.cbStatus.TabIndex = 42;
            // 
            // labStatus
            // 
            this.labStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatus.AutoSize = true;
            this.labStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labStatus.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStatus.ForeColor = System.Drawing.Color.Black;
            this.labStatus.Location = new System.Drawing.Point(540, 406);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(123, 26);
            this.labStatus.TabIndex = 41;
            this.labStatus.Text = "Status       : ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(174, 345);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(221, 84);
            this.txtDescription.TabIndex = 44;
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescription.ForeColor = System.Drawing.Color.Black;
            this.labDescription.Location = new System.Drawing.Point(11, 341);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(157, 26);
            this.labDescription.TabIndex = 43;
            this.labDescription.Text = "Description     : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(546, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 50);
            this.button1.TabIndex = 45;
            this.button1.Text = "Canncel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSellingPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.labDescription);
            this.groupBox1.Controls.Add(this.labTitale);
            this.groupBox1.Location = new System.Drawing.Point(31, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 526);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 47;
            this.label2.Text = "Selling Price    : ";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(174, 305);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(221, 24);
            this.txtSellingPrice.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "ProductID : ";
            this.label1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCAddAndUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botAddorUpdateUser);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labBarcode);
            this.Controls.Add(this.labCompany);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.labProductName);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCAddAndUpdateProduct";
            this.Size = new System.Drawing.Size(1021, 649);
            this.Load += new System.EventHandler(this.UCAddAndUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botAddorUpdateUser;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label labBarcode;
        private System.Windows.Forms.Label labCompany;
        private System.Windows.Forms.Label labRole;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSellingPrice;
    }
}
