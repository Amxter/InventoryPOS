using POSLogic.LogicUser;
using System;
using System.Windows.Forms;

namespace Project_Plint_of_Sale_System
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.mktbPassword = new System.Windows.Forms.MaskedTextBox();
            this.labUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.White;
            this.gbLogin.Controls.Add(this.labPassword);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.button1);
            this.gbLogin.Controls.Add(this.checkBox1);
            this.gbLogin.Controls.Add(this.mktbPassword);
            this.gbLogin.Controls.Add(this.labUserName);
            this.gbLogin.Controls.Add(this.tbUserName);
            this.gbLogin.Controls.Add(this.labLogin);
            this.gbLogin.Location = new System.Drawing.Point(142, 98);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(362, 403);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "login-square-arrow-button-outline.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(84, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "   Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(81, 266);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labPassword.ImageKey = "locked.png";
            this.labPassword.ImageList = this.imageList1;
            this.labPassword.Location = new System.Drawing.Point(78, 198);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(42, 36);
            this.labPassword.TabIndex = 4;
            this.labPassword.Text = "   ";
            // 
            // mktbPassword
            // 
            this.mktbPassword.Location = new System.Drawing.Point(81, 235);
            this.mktbPassword.Name = "mktbPassword";
            this.mktbPassword.PasswordChar = '●';
            this.mktbPassword.Size = new System.Drawing.Size(206, 24);
            this.mktbPassword.TabIndex = 1;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labUserName.ImageKey = "id-card.png";
            this.labUserName.ImageList = this.imageList1;
            this.labUserName.Location = new System.Drawing.Point(77, 126);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(163, 24);
            this.labUserName.TabIndex = 2;
            this.labUserName.Text = "       User Name :";
            this.labUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(81, 153);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(206, 24);
            this.tbUserName.TabIndex = 0;
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogin.Location = new System.Drawing.Point(137, 30);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(85, 36);
            this.labLogin.TabIndex = 4;
            this.labLogin.Text = "Login";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login-square-arrow-button-outline.png");
            this.imageList1.Images.SetKeyName(1, "locked.png");
            this.imageList1.Images.SetKeyName(2, "id-card.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageKey = "(none)";
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(77, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "       Password :";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 594);
            this.Controls.Add(this.gbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "Inventory POS";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.MaskedTextBox mktbPassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList1;
        private Label label1;
    }
}


