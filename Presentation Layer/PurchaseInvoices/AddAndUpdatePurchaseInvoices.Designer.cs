namespace Project_Plint_of_Sale_System.PurchaseInvoices
{
    partial class AddAndUpdatePurchaseInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndUpdatePurchaseInvoices));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelShowDetails = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.botAddorUpdateUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSypplierName = new System.Windows.Forms.Label();
            this.cbSupplierName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(196, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 135);
            this.panel1.TabIndex = 60;
            // 
            // linkLabelShowDetails
            // 
            this.linkLabelShowDetails.AutoSize = true;
            this.linkLabelShowDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelShowDetails.Location = new System.Drawing.Point(924, 441);
            this.linkLabelShowDetails.Name = "linkLabelShowDetails";
            this.linkLabelShowDetails.Size = new System.Drawing.Size(126, 24);
            this.linkLabelShowDetails.TabIndex = 57;
            this.linkLabelShowDetails.TabStop = true;
            this.linkLabelShowDetails.Text = "Show Details";
            this.linkLabelShowDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowDetails_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(928, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 50);
            this.button1.TabIndex = 56;
            this.button1.Text = "Canncel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botAddorUpdateUser
            // 
            this.botAddorUpdateUser.BackColor = System.Drawing.Color.Blue;
            this.botAddorUpdateUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botAddorUpdateUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botAddorUpdateUser.Location = new System.Drawing.Point(928, 468);
            this.botAddorUpdateUser.Name = "botAddorUpdateUser";
            this.botAddorUpdateUser.Size = new System.Drawing.Size(288, 50);
            this.botAddorUpdateUser.TabIndex = 55;
            this.botAddorUpdateUser.Text = "Add Invoice";
            this.botAddorUpdateUser.UseVisualStyleBackColor = false;
            this.botAddorUpdateUser.Click += new System.EventHandler(this.botAddorUpdateUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(942, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 49);
            this.label2.TabIndex = 54;
            this.label2.Text = "$0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(923, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 28);
            this.label1.TabIndex = 53;
            this.label1.Text = "Total Price the invoice :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(916, 484);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSypplierName
            // 
            this.labelSypplierName.AutoSize = true;
            this.labelSypplierName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSypplierName.Location = new System.Drawing.Point(923, 299);
            this.labelSypplierName.Name = "labelSypplierName";
            this.labelSypplierName.Size = new System.Drawing.Size(180, 25);
            this.labelSypplierName.TabIndex = 62;
            this.labelSypplierName.Text = "Supplier Name : ";
            // 
            // cbSupplierName
            // 
            this.cbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierName.FormattingEnabled = true;
            this.cbSupplierName.Location = new System.Drawing.Point(923, 327);
            this.cbSupplierName.Name = "cbSupplierName";
            this.cbSupplierName.Size = new System.Drawing.Size(301, 24);
            this.cbSupplierName.TabIndex = 61;
            // 
            // AddAndUpdatePurchaseInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 645);
            this.Controls.Add(this.labelSypplierName);
            this.Controls.Add(this.cbSupplierName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelShowDetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botAddorUpdateUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAndUpdatePurchaseInvoices";
            this.Text = "Purchase Invoices";
            this.Load += new System.EventHandler(this.AddAndUpdatePurchaseInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelShowDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botAddorUpdateUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSypplierName;
        private System.Windows.Forms.ComboBox cbSupplierName;
    }
}