namespace PoC_gestion_stocks_ETML.Views
{
    partial class Viewdashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnMouvement = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTotalstock = new System.Windows.Forms.Label();
            this.lblLastmouvement = new System.Windows.Forms.Label();
            this.lblNumbercriticArticle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 5);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(156, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 467);
            this.label2.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.Location = new System.Drawing.Point(44, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(62, 28);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.Location = new System.Drawing.Point(415, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(153, 28);
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "Tableau de bord";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Enabled = false;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.Location = new System.Drawing.Point(25, 75);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(107, 52);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnArticle
            // 
            this.btnArticle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArticle.Location = new System.Drawing.Point(25, 167);
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(107, 52);
            this.btnArticle.TabIndex = 5;
            this.btnArticle.Text = "Article";
            this.btnArticle.UseVisualStyleBackColor = true;
            this.btnArticle.Click += new System.EventHandler(this.btnArticle_Click);
            // 
            // btnMouvement
            // 
            this.btnMouvement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMouvement.Location = new System.Drawing.Point(25, 268);
            this.btnMouvement.Name = "btnMouvement";
            this.btnMouvement.Size = new System.Drawing.Size(107, 52);
            this.btnMouvement.TabIndex = 6;
            this.btnMouvement.Text = "Mouvement";
            this.btnMouvement.UseVisualStyleBackColor = true;
            this.btnMouvement.Click += new System.EventHandler(this.btnMouvement_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.Location = new System.Drawing.Point(25, 370);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(107, 52);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Compte";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(687, 14);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 27);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Déconnexion";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTotalstock
            // 
            this.lblTotalstock.AutoSize = true;
            this.lblTotalstock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalstock.Location = new System.Drawing.Point(230, 75);
            this.lblTotalstock.Name = "lblTotalstock";
            this.lblTotalstock.Size = new System.Drawing.Size(86, 19);
            this.lblTotalstock.TabIndex = 9;
            this.lblTotalstock.Text = "Total Stock : ";
            // 
            // lblLastmouvement
            // 
            this.lblLastmouvement.AutoSize = true;
            this.lblLastmouvement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastmouvement.Location = new System.Drawing.Point(230, 133);
            this.lblLastmouvement.Name = "lblLastmouvement";
            this.lblLastmouvement.Size = new System.Drawing.Size(152, 19);
            this.lblLastmouvement.TabIndex = 10;
            this.lblLastmouvement.Text = "Derniers Mouvements :";
            // 
            // lblNumbercriticArticle
            // 
            this.lblNumbercriticArticle.AutoSize = true;
            this.lblNumbercriticArticle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumbercriticArticle.Location = new System.Drawing.Point(230, 370);
            this.lblNumbercriticArticle.Name = "lblNumbercriticArticle";
            this.lblNumbercriticArticle.Size = new System.Drawing.Size(178, 19);
            this.lblNumbercriticArticle.TabIndex = 11;
            this.lblNumbercriticArticle.Text = "Nombre d\'articles critiques :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(239, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 212);
            this.panel1.TabIndex = 12;
            // 
            // Viewdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumbercriticArticle);
            this.Controls.Add(this.lblLastmouvement);
            this.Controls.Add(this.lblTotalstock);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnMouvement);
            this.Controls.Add(this.btnArticle);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Viewdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewdashborad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblMenu;
        private Label lblDashboard;
        private Button btnDashboard;
        private Button btnArticle;
        private Button btnMouvement;
        private Button btnAccount;
        private Button btnLogOut;
        private Label lblTotalstock;
        private Label lblLastmouvement;
        private Label lblNumbercriticArticle;
        private Panel panel1;
    }
}