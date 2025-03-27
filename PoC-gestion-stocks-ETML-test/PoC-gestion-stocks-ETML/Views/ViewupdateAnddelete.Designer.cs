namespace PoC_gestion_stocks_ETML.Views
{
    partial class ViewupdateAnddelete
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lstviewData = new System.Windows.Forms.ListView();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxFirstname = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.btnUpdateuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 39);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstviewData
            // 
            this.lstviewData.Location = new System.Drawing.Point(285, 101);
            this.lstviewData.Name = "lstviewData";
            this.lstviewData.Size = new System.Drawing.Size(487, 337);
            this.lstviewData.TabIndex = 10;
            this.lstviewData.UseCompatibleStateImageBehavior = false;
            this.lstviewData.View = System.Windows.Forms.View.Details;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(18, 336);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(18, 258);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(59, 15);
            this.lblFirstname.TabIndex = 15;
            this.lblFirstname.Text = "Firstname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 179);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // txtboxFirstname
            // 
            this.txtboxFirstname.Location = new System.Drawing.Point(18, 276);
            this.txtboxFirstname.Name = "txtboxFirstname";
            this.txtboxFirstname.Size = new System.Drawing.Size(249, 23);
            this.txtboxFirstname.TabIndex = 12;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(18, 354);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(249, 23);
            this.txtboxAddress.TabIndex = 13;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(18, 197);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(249, 23);
            this.txtboxName.TabIndex = 11;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(164, 397);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(103, 41);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 101);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(18, 119);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(249, 23);
            this.txtboxID.TabIndex = 17;
            // 
            // btnUpdateuser
            // 
            this.btnUpdateuser.Location = new System.Drawing.Point(18, 397);
            this.btnUpdateuser.Name = "btnUpdateuser";
            this.btnUpdateuser.Size = new System.Drawing.Size(103, 41);
            this.btnUpdateuser.TabIndex = 19;
            this.btnUpdateuser.Text = "Update";
            this.btnUpdateuser.UseVisualStyleBackColor = true;
            this.btnUpdateuser.Click += new System.EventHandler(this.btnUpdateuser_Click);
            // 
            // ViewupdateAnddelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateuser);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.lstviewData);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxFirstname);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnBack);
            this.Name = "ViewupdateAnddelete";
            this.Text = "Update and Delete";
            this.Load += new System.EventHandler(this.ViewupdateAnddelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private ListView lstviewData;
        private Label lblAddress;
        private Label lblFirstname;
        private Label lblName;
        private TextBox txtboxFirstname;
        private TextBox txtboxAddress;
        private TextBox txtboxName;
        private Button btnDeleteUser;
        private Label lblID;
        private TextBox txtboxID;
        private Button btnUpdateuser;
    }
}