namespace Project_Plint_of_Sale_System
{
    partial class UCSearchProduct
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
            this.labSearch = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.cbComponents = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(5, 8);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(105, 23);
            this.labSearch.TabIndex = 0;
            this.labSearch.Text = "Search by :";
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Status",
            "Company",
            "Category",
            "Product Name"});
            this.cbSearch.Location = new System.Drawing.Point(9, 34);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(230, 24);
            this.cbSearch.TabIndex = 1;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // cbComponents
            // 
            this.cbComponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComponents.FormattingEnabled = true;
            this.cbComponents.Location = new System.Drawing.Point(254, 34);
            this.cbComponents.Name = "cbComponents";
            this.cbComponents.Size = new System.Drawing.Size(230, 24);
            this.cbComponents.TabIndex = 2;
            this.cbComponents.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butSearch
            // 
            this.butSearch.BackgroundImage = global::Project_Plint_of_Sale_System.Properties.Resources.search;
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butSearch.Location = new System.Drawing.Point(321, 73);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(53, 45);
            this.butSearch.TabIndex = 4;
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Visible = false;
            this.butSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(147, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "All Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UCSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbComponents);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.labSearch);
            this.Name = "UCSearchProduct";
            this.Size = new System.Drawing.Size(514, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ComboBox cbComponents;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button button1;
    }
}
