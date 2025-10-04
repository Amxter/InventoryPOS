namespace Project_Plint_of_Sale_System
{
    partial class UCCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCompanyID = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.butUpdate = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.butCanncel = new System.Windows.Forms.Button();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.botAddOrUpdate = new System.Windows.Forms.Button();
            this.txtDiscrption = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labDescription = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
            this.labTital = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.AllowUserToAddRows = false;
            this.dataGridViewCompany.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompany.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCompany.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCompany.Location = new System.Drawing.Point(0, 275);
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompany.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCompany.RowHeadersWidth = 51;
            this.dataGridViewCompany.RowTemplate.Height = 26;
            this.dataGridViewCompany.Size = new System.Drawing.Size(1021, 374);
            this.dataGridViewCompany.TabIndex = 0;
            this.dataGridViewCompany.SelectionChanged += new System.EventHandler(this.dataGridViewCompany_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCompanyID);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.butUpdate);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(571, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelCompanyID
            // 
            this.labelCompanyID.AutoSize = true;
            this.labelCompanyID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyID.Location = new System.Drawing.Point(35, 20);
            this.labelCompanyID.Name = "labelCompanyID";
            this.labelCompanyID.Size = new System.Drawing.Size(149, 25);
            this.labelCompanyID.TabIndex = 1;
            this.labelCompanyID.Text = "CompanyID :";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(35, 114);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(90, 25);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Phone :";
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Red;
            this.butDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.butDelete.Location = new System.Drawing.Point(247, 215);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(123, 43);
            this.butDelete.TabIndex = 8;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(35, 161);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(107, 25);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address :";
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.Color.Blue;
            this.butUpdate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.butUpdate.Location = new System.Drawing.Point(92, 215);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(123, 43);
            this.butUpdate.TabIndex = 7;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(35, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "All Companies";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 24);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(20, 155);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(159, 23);
            this.labSearch.TabIndex = 6;
            this.labSearch.Text = "Search by Name :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.butCanncel);
            this.panel1.Controls.Add(this.maskedTextBoxPhone);
            this.panel1.Controls.Add(this.labPhone);
            this.panel1.Controls.Add(this.botAddOrUpdate);
            this.panel1.Controls.Add(this.txtDiscrption);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.labDescription);
            this.panel1.Controls.Add(this.labAddress);
            this.panel1.Controls.Add(this.labFirstName);
            this.panel1.Controls.Add(this.labTital);
            this.panel1.Location = new System.Drawing.Point(115, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 455);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClose.Location = new System.Drawing.Point(753, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(51, 40);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // butCanncel
            // 
            this.butCanncel.BackColor = System.Drawing.Color.Red;
            this.butCanncel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCanncel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butCanncel.Location = new System.Drawing.Point(450, 338);
            this.butCanncel.Name = "butCanncel";
            this.butCanncel.Size = new System.Drawing.Size(149, 58);
            this.butCanncel.TabIndex = 30;
            this.butCanncel.Text = "Canncel";
            this.butCanncel.UseVisualStyleBackColor = false;
            this.butCanncel.Click += new System.EventHandler(this.butCanncel_Click);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(537, 127);
            this.maskedTextBoxPhone.Mask = "+000 0 000 0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(230, 24);
            this.maskedTextBoxPhone.TabIndex = 29;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhone.ForeColor = System.Drawing.Color.Black;
            this.labPhone.Location = new System.Drawing.Point(402, 128);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(132, 28);
            this.labPhone.TabIndex = 28;
            this.labPhone.Text = "Phone      : ";
            // 
            // botAddOrUpdate
            // 
            this.botAddOrUpdate.BackColor = System.Drawing.Color.Blue;
            this.botAddOrUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botAddOrUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botAddOrUpdate.Location = new System.Drawing.Point(249, 338);
            this.botAddOrUpdate.Name = "botAddOrUpdate";
            this.botAddOrUpdate.Size = new System.Drawing.Size(149, 58);
            this.botAddOrUpdate.TabIndex = 27;
            this.botAddOrUpdate.Text = "Add";
            this.botAddOrUpdate.UseVisualStyleBackColor = false;
            this.botAddOrUpdate.Click += new System.EventHandler(this.botAddOrUpdate_Click);
            // 
            // txtDiscrption
            // 
            this.txtDiscrption.Location = new System.Drawing.Point(537, 176);
            this.txtDiscrption.Multiline = true;
            this.txtDiscrption.Name = "txtDiscrption";
            this.txtDiscrption.Size = new System.Drawing.Size(230, 133);
            this.txtDiscrption.TabIndex = 25;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(150, 176);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 133);
            this.txtAddress.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 24);
            this.txtName.TabIndex = 23;
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescription.ForeColor = System.Drawing.Color.Black;
            this.labDescription.Location = new System.Drawing.Point(402, 172);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(139, 26);
            this.labDescription.TabIndex = 22;
            this.labDescription.Text = "Description :  ";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddress.ForeColor = System.Drawing.Color.Black;
            this.labAddress.Location = new System.Drawing.Point(28, 172);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(106, 26);
            this.labAddress.TabIndex = 20;
            this.labAddress.Text = "Address  : ";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstName.ForeColor = System.Drawing.Color.Black;
            this.labFirstName.Location = new System.Drawing.Point(28, 123);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(107, 28);
            this.labFirstName.TabIndex = 19;
            this.labFirstName.Text = "Name   : ";
            // 
            // labTital
            // 
            this.labTital.AutoSize = true;
            this.labTital.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTital.Location = new System.Drawing.Point(299, 32);
            this.labTital.Name = "labTital";
            this.labTital.Size = new System.Drawing.Size(237, 52);
            this.labTital.TabIndex = 0;
            this.labTital.Text = "Add Company";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(231, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 45);
            this.button2.TabIndex = 31;
            this.button2.Text = "Add Company";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UCCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCompany);
            this.Name = "UCCompany";
            this.Size = new System.Drawing.Size(1021, 649);
            this.Load += new System.EventHandler(this.UCCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCompanyID;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labTital;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Button botAddOrUpdate;
        private System.Windows.Forms.TextBox txtDiscrption;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.Button butCanncel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonClose;
    }
}
