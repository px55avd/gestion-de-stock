namespace PoC_gestion_stocks_ETML
{
    partial class View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegisternewUser = new System.Windows.Forms.Button();
            this.btnUpdateuser = new System.Windows.Forms.Button();
            this.lstviewData = new System.Windows.Forms.ListView();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxFirstname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnTestconnexionDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisternewUser
            // 
            this.btnRegisternewUser.Location = new System.Drawing.Point(180, 371);
            this.btnRegisternewUser.Name = "btnRegisternewUser";
            this.btnRegisternewUser.Size = new System.Drawing.Size(103, 41);
            this.btnRegisternewUser.TabIndex = 0;
            this.btnRegisternewUser.Text = "Register";
            this.btnRegisternewUser.UseVisualStyleBackColor = true;
            this.btnRegisternewUser.Click += new System.EventHandler(this.btnRegisternewUser_Click);
            // 
            // btnUpdateuser
            // 
            this.btnUpdateuser.Location = new System.Drawing.Point(685, 12);
            this.btnUpdateuser.Name = "btnUpdateuser";
            this.btnUpdateuser.Size = new System.Drawing.Size(103, 41);
            this.btnUpdateuser.TabIndex = 1;
            this.btnUpdateuser.Text = "Update/Delete";
            this.btnUpdateuser.UseVisualStyleBackColor = true;
            this.btnUpdateuser.Click += new System.EventHandler(this.btnUpdateuser_Click);
            // 
            // lstviewData
            // 
            this.lstviewData.Location = new System.Drawing.Point(301, 75);
            this.lstviewData.Name = "lstviewData";
            this.lstviewData.Size = new System.Drawing.Size(487, 337);
            this.lstviewData.TabIndex = 2;
            this.lstviewData.UseCompatibleStateImageBehavior = false;
            this.lstviewData.View = System.Windows.Forms.View.Details;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(34, 93);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(249, 23);
            this.txtboxName.TabIndex = 3;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(34, 295);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(249, 23);
            this.txtboxAddress.TabIndex = 5;
            // 
            // txtboxFirstname
            // 
            this.txtboxFirstname.Location = new System.Drawing.Point(34, 194);
            this.txtboxFirstname.Name = "txtboxFirstname";
            this.txtboxFirstname.Size = new System.Drawing.Size(249, 23);
            this.txtboxFirstname.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(34, 176);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(59, 15);
            this.lblFirstname.TabIndex = 7;
            this.lblFirstname.Text = "Firstname";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 277);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // btnTestconnexionDatabase
            // 
            this.btnTestconnexionDatabase.Location = new System.Drawing.Point(34, 12);
            this.btnTestconnexionDatabase.Name = "btnTestconnexionDatabase";
            this.btnTestconnexionDatabase.Size = new System.Drawing.Size(103, 41);
            this.btnTestconnexionDatabase.TabIndex = 9;
            this.btnTestconnexionDatabase.Text = "Test connection database";
            this.btnTestconnexionDatabase.UseVisualStyleBackColor = true;
            this.btnTestconnexionDatabase.Click += new System.EventHandler(this.btnTestconnexionDatabase_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstviewData);
            this.Controls.Add(this.btnTestconnexionDatabase);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxFirstname);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.btnUpdateuser);
            this.Controls.Add(this.btnRegisternewUser);
            this.Name = "View";
            this.Text = "Gestion du stockages";
            this.Activated += new System.EventHandler(this.View_Activated);
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegisternewUser;
        private Button btnUpdateuser;
        private ListView lstviewData;
        private TextBox txtboxName;
        private TextBox txtboxAddress;
        private TextBox txtboxFirstname;
        private Label lblName;
        private Label lblFirstname;
        private Label lblAddress;
        private Button btnTestconnexionDatabase;
    }
}