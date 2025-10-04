namespace Project_Plint_of_Sale_System
{
    partial class UCSearchInvoice
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
            this.button1 = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.cbComponents = new System.Windows.Forms.ComboBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCauntInvoice = new System.Windows.Forms.Label();
            this.labelDateLastInvoice = new System.Windows.Forms.Label();
            this.labelDateFirstInvoice = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.dateTimePickerLastInvoise = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFirstInvoise = new System.Windows.Forms.DateTimePicker();
            this.labelDataStart = new System.Windows.Forms.Label();
            this.labelDataEnd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(572, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "All Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackgroundImage = global::Project_Plint_of_Sale_System.Properties.Resources.search;
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butSearch.Location = new System.Drawing.Point(779, 196);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(78, 54);
            this.butSearch.TabIndex = 17;
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // cbComponents
            // 
            this.cbComponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComponents.FormattingEnabled = true;
            this.cbComponents.Location = new System.Drawing.Point(750, 61);
            this.cbComponents.Name = "cbComponents";
            this.cbComponents.Size = new System.Drawing.Size(230, 24);
            this.cbComponents.TabIndex = 15;
            this.cbComponents.Visible = false;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Status",
            "Invoice Number",
            "Date Invoice",
            "Cashier Name"});
            this.cbSearch.Location = new System.Drawing.Point(465, 61);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(230, 24);
            this.cbSearch.TabIndex = 14;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged_1);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(461, 35);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(105, 23);
            this.labSearch.TabIndex = 13;
            this.labSearch.Text = "Search by :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 387);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCauntInvoice);
            this.groupBox1.Controls.Add(this.labelDateLastInvoice);
            this.groupBox1.Controls.Add(this.labelDateFirstInvoice);
            this.groupBox1.Controls.Add(this.labelTotalAmount);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 259);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // labelCauntInvoice
            // 
            this.labelCauntInvoice.AutoSize = true;
            this.labelCauntInvoice.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCauntInvoice.Location = new System.Drawing.Point(25, 180);
            this.labelCauntInvoice.Name = "labelCauntInvoice";
            this.labelCauntInvoice.Size = new System.Drawing.Size(167, 28);
            this.labelCauntInvoice.TabIndex = 3;
            this.labelCauntInvoice.Text = "Caunt Invoice :";
            // 
            // labelDateLastInvoice
            // 
            this.labelDateLastInvoice.AutoSize = true;
            this.labelDateLastInvoice.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateLastInvoice.Location = new System.Drawing.Point(25, 133);
            this.labelDateLastInvoice.Name = "labelDateLastInvoice";
            this.labelDateLastInvoice.Size = new System.Drawing.Size(203, 28);
            this.labelDateLastInvoice.TabIndex = 2;
            this.labelDateLastInvoice.Text = "Date Last Invoice :";
            // 
            // labelDateFirstInvoice
            // 
            this.labelDateFirstInvoice.AutoSize = true;
            this.labelDateFirstInvoice.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFirstInvoice.Location = new System.Drawing.Point(23, 86);
            this.labelDateFirstInvoice.Name = "labelDateFirstInvoice";
            this.labelDateFirstInvoice.Size = new System.Drawing.Size(205, 28);
            this.labelDateFirstInvoice.TabIndex = 1;
            this.labelDateFirstInvoice.Text = "Date First Invoice :";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(25, 39);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(163, 28);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "Total Amount :";
            // 
            // dateTimePickerLastInvoise
            // 
            this.dateTimePickerLastInvoise.Location = new System.Drawing.Point(740, 135);
            this.dateTimePickerLastInvoise.Name = "dateTimePickerLastInvoise";
            this.dateTimePickerLastInvoise.Size = new System.Drawing.Size(229, 24);
            this.dateTimePickerLastInvoise.TabIndex = 20;
            // 
            // dateTimePickerFirstInvoise
            // 
            this.dateTimePickerFirstInvoise.Location = new System.Drawing.Point(465, 135);
            this.dateTimePickerFirstInvoise.Name = "dateTimePickerFirstInvoise";
            this.dateTimePickerFirstInvoise.Size = new System.Drawing.Size(230, 24);
            this.dateTimePickerFirstInvoise.TabIndex = 21;
            // 
            // labelDataStart
            // 
            this.labelDataStart.AutoSize = true;
            this.labelDataStart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataStart.Location = new System.Drawing.Point(461, 111);
            this.labelDataStart.Name = "labelDataStart";
            this.labelDataStart.Size = new System.Drawing.Size(98, 21);
            this.labelDataStart.TabIndex = 22;
            this.labelDataStart.Text = "Data Start :";
            // 
            // labelDataEnd
            // 
            this.labelDataEnd.AutoSize = true;
            this.labelDataEnd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataEnd.Location = new System.Drawing.Point(736, 111);
            this.labelDataEnd.Name = "labelDataEnd";
            this.labelDataEnd.Size = new System.Drawing.Size(90, 21);
            this.labelDataEnd.TabIndex = 23;
            this.labelDataEnd.Text = "Data End :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(750, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 24);
            this.textBox1.TabIndex = 24;
            this.textBox1.Visible = false;
            // 
            // UCSearchInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDataEnd);
            this.Controls.Add(this.labelDataStart);
            this.Controls.Add(this.dateTimePickerFirstInvoise);
            this.Controls.Add(this.dateTimePickerLastInvoise);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.cbComponents);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCSearchInvoice";
            this.Size = new System.Drawing.Size(1060, 739);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.ComboBox cbComponents;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCauntInvoice;
        private System.Windows.Forms.Label labelDateLastInvoice;
        private System.Windows.Forms.Label labelDateFirstInvoice;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastInvoise;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstInvoise;
        private System.Windows.Forms.Label labelDataStart;
        private System.Windows.Forms.Label labelDataEnd;
        private System.Windows.Forms.TextBox textBox1;
    }
}
