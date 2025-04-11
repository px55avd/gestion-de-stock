namespace PoC_gestion_stocks_ETML.Views
{
    partial class ViewMouvement
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblNumberpages = new System.Windows.Forms.Label();
            this.btnMibus = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnNewMouvement = new System.Windows.Forms.Button();
            this.pnlMouvementbutton = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnMouvement = new System.Windows.Forms.Button();
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblMouvement = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(517, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(220, 73);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(144, 23);
            this.txtboxSearch.TabIndex = 46;
            this.txtboxSearch.Text = "Zone de recherche...";
            // 
            // lblNumberpages
            // 
            this.lblNumberpages.AutoSize = true;
            this.lblNumberpages.Location = new System.Drawing.Point(714, 401);
            this.lblNumberpages.Name = "lblNumberpages";
            this.lblNumberpages.Size = new System.Drawing.Size(13, 15);
            this.lblNumberpages.TabIndex = 45;
            this.lblNumberpages.Text = "0";
            // 
            // btnMibus
            // 
            this.btnMibus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMibus.Location = new System.Drawing.Point(689, 397);
            this.btnMibus.Name = "btnMibus";
            this.btnMibus.Size = new System.Drawing.Size(20, 23);
            this.btnMibus.TabIndex = 44;
            this.btnMibus.Text = "-";
            this.btnMibus.UseVisualStyleBackColor = true;
            this.btnMibus.Click += new System.EventHandler(this.btnMibus_Click);
            // 
            // btnUp
            // 
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUp.Location = new System.Drawing.Point(734, 397);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(20, 23);
            this.btnUp.TabIndex = 43;
            this.btnUp.Text = "+";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnNewMouvement
            // 
            this.btnNewMouvement.Location = new System.Drawing.Point(600, 73);
            this.btnNewMouvement.Name = "btnNewMouvement";
            this.btnNewMouvement.Size = new System.Drawing.Size(127, 23);
            this.btnNewMouvement.TabIndex = 42;
            this.btnNewMouvement.Text = "Ajout Mouvement";
            this.btnNewMouvement.UseVisualStyleBackColor = true;
            this.btnNewMouvement.Click += new System.EventHandler(this.btnNewMouvement_Click);
            // 
            // pnlMouvementbutton
            // 
            this.pnlMouvementbutton.Location = new System.Drawing.Point(220, 106);
            this.pnlMouvementbutton.Name = "pnlMouvementbutton";
            this.pnlMouvementbutton.Size = new System.Drawing.Size(507, 285);
            this.pnlMouvementbutton.TabIndex = 41;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(688, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 27);
            this.btnLogOut.TabIndex = 40;
            this.btnLogOut.Text = "Déconnexion";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.Location = new System.Drawing.Point(26, 368);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(107, 52);
            this.btnAccount.TabIndex = 39;
            this.btnAccount.Text = "Compte";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnMouvement
            // 
            this.btnMouvement.Enabled = false;
            this.btnMouvement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMouvement.Location = new System.Drawing.Point(26, 266);
            this.btnMouvement.Name = "btnMouvement";
            this.btnMouvement.Size = new System.Drawing.Size(107, 52);
            this.btnMouvement.TabIndex = 38;
            this.btnMouvement.Text = "Mouvement";
            this.btnMouvement.UseVisualStyleBackColor = true;
            // 
            // btnArticle
            // 
            this.btnArticle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArticle.Location = new System.Drawing.Point(26, 165);
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(107, 52);
            this.btnArticle.TabIndex = 37;
            this.btnArticle.Text = "Article";
            this.btnArticle.UseVisualStyleBackColor = true;
            this.btnArticle.Click += new System.EventHandler(this.btnArticle_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.Location = new System.Drawing.Point(26, 73);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(107, 52);
            this.btnDashboard.TabIndex = 36;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblMouvement
            // 
            this.lblMouvement.AutoSize = true;
            this.lblMouvement.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMouvement.Location = new System.Drawing.Point(416, 7);
            this.lblMouvement.Name = "lblMouvement";
            this.lblMouvement.Size = new System.Drawing.Size(118, 28);
            this.lblMouvement.TabIndex = 35;
            this.lblMouvement.Text = "Mouvement";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.Location = new System.Drawing.Point(45, 7);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(62, 28);
            this.lblMenu.TabIndex = 34;
            this.lblMenu.Text = "Menu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(157, -8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 467);
            this.label2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 5);
            this.label1.TabIndex = 32;
            // 
            // cmboxCategory
            // 
            this.cmboxCategory.FormattingEnabled = true;
            this.cmboxCategory.Location = new System.Drawing.Point(370, 73);
            this.cmboxCategory.Name = "cmboxCategory";
            this.cmboxCategory.Size = new System.Drawing.Size(141, 23);
            this.cmboxCategory.TabIndex = 48;
            this.cmboxCategory.Text = "Catégorie";
            // 
            // ViewMouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.cmboxCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblNumberpages);
            this.Controls.Add(this.btnMibus);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnNewMouvement);
            this.Controls.Add(this.pnlMouvementbutton);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnMouvement);
            this.Controls.Add(this.btnArticle);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblMouvement);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewMouvement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMouvement";
            this.Activated += new System.EventHandler(this.ViewMouvement_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private TextBox txtboxSearch;
        private Label lblNumberpages;
        private Button btnMibus;
        private Button btnUp;
        private Button btnNewMouvement;
        private Panel pnlMouvementbutton;
        private Button btnLogOut;
        private Button btnAccount;
        private Button btnMouvement;
        private Button btnArticle;
        private Button btnDashboard;
        private Label lblMouvement;
        private Label lblMenu;
        private Label label2;
        private Label label1;
        private ComboBox cmboxCategory;
    }
}