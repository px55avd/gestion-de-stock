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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNewuser = new System.Windows.Forms.Button();
            this.txtboxUsename = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnTestconnexionDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(427, 296);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNewuser
            // 
            this.btnNewuser.Location = new System.Drawing.Point(685, 12);
            this.btnNewuser.Name = "btnNewuser";
            this.btnNewuser.Size = new System.Drawing.Size(103, 41);
            this.btnNewuser.TabIndex = 1;
            this.btnNewuser.Text = "Nouvel utilisateur";
            this.btnNewuser.UseVisualStyleBackColor = true;
            this.btnNewuser.Click += new System.EventHandler(this.btnNewuser_Click);
            // 
            // txtboxUsename
            // 
            this.txtboxUsename.Location = new System.Drawing.Point(281, 128);
            this.txtboxUsename.Name = "txtboxUsename";
            this.txtboxUsename.Size = new System.Drawing.Size(249, 23);
            this.txtboxUsename.TabIndex = 3;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(281, 229);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(249, 23);
            this.txtboxPassword.TabIndex = 4;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(281, 110);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 15);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Nom d\'utilisateur";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(281, 211);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 15);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Mot de passe";
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
            this.Controls.Add(this.btnTestconnexionDatabase);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsename);
            this.Controls.Add(this.btnNewuser);
            this.Controls.Add(this.btnLogin);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion du stockages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private Button btnNewuser;
        private TextBox txtboxUsename;
        private TextBox txtboxPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnTestconnexionDatabase;
    }
}