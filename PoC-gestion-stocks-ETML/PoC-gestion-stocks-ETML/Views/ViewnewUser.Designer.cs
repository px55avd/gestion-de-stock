namespace PoC_gestion_stocks_ETML.Views
{
    partial class ViewnewUser
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxFirstname = new System.Windows.Forms.TextBox();
            this.txtboxLogin = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnvalidnewArticle = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(263, 271);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 15);
            this.lblID.TabIndex = 98;
            this.lblID.Text = "Mot de passe";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(263, 289);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(274, 23);
            this.txtboxPassword.TabIndex = 94;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(263, 197);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(37, 15);
            this.lblAddress.TabIndex = 96;
            this.lblAddress.Text = "Login";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(263, 57);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(49, 15);
            this.lblFirstname.TabIndex = 95;
            this.lblFirstname.Text = "Prénom";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(263, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 15);
            this.lblName.TabIndex = 94;
            this.lblName.Text = "Nom";
            // 
            // txtboxFirstname
            // 
            this.txtboxFirstname.Location = new System.Drawing.Point(263, 75);
            this.txtboxFirstname.Name = "txtboxFirstname";
            this.txtboxFirstname.Size = new System.Drawing.Size(274, 23);
            this.txtboxFirstname.TabIndex = 91;
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Location = new System.Drawing.Point(263, 215);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(274, 23);
            this.txtboxLogin.TabIndex = 93;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(263, 146);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(274, 23);
            this.txtboxName.TabIndex = 92;
            // 
            // btnvalidnewArticle
            // 
            this.btnvalidnewArticle.Location = new System.Drawing.Point(400, 359);
            this.btnvalidnewArticle.Name = "btnvalidnewArticle";
            this.btnvalidnewArticle.Size = new System.Drawing.Size(137, 41);
            this.btnvalidnewArticle.TabIndex = 95;
            this.btnvalidnewArticle.Text = "Valider";
            this.btnvalidnewArticle.UseVisualStyleBackColor = true;
            this.btnvalidnewArticle.Click += new System.EventHandler(this.btnvalidnewArticle_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 44);
            this.btnBack.TabIndex = 96;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewnewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnvalidnewArticle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxFirstname);
            this.Controls.Add(this.txtboxLogin);
            this.Controls.Add(this.txtboxName);
            this.Name = "ViewnewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewnewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblID;
        private TextBox txtboxPassword;
        private Label lblAddress;
        private Label lblFirstname;
        private Label lblName;
        private TextBox txtboxFirstname;
        private TextBox txtboxLogin;
        private TextBox txtboxName;
        private Button btnvalidnewArticle;
        private Button btnBack;
    }
}