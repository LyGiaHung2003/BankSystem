namespace BankSystem.Views
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            branchToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            bankingToolStripMenuItem = new ToolStripMenuItem();
            depositAmountToolStripMenuItem = new ToolStripMenuItem();
            withdrawAmountToolStripMenuItem = new ToolStripMenuItem();
            transactionAmountToolStripMenuItem = new ToolStripMenuItem();
            balanceAccountToolStripMenuItem = new ToolStripMenuItem();
            transactionLogToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userGuideToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, systemToolStripMenuItem, bankingToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(139, 26);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeToolStripMenuItem, branchToolStripMenuItem, customerToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(70, 24);
            systemToolStripMenuItem.Text = "System";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(158, 26);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // branchToolStripMenuItem
            // 
            branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            branchToolStripMenuItem.Size = new Size(158, 26);
            branchToolStripMenuItem.Text = "Branch";
            branchToolStripMenuItem.Click += branchToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(158, 26);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // bankingToolStripMenuItem
            // 
            bankingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depositAmountToolStripMenuItem, withdrawAmountToolStripMenuItem, transactionAmountToolStripMenuItem, balanceAccountToolStripMenuItem, transactionLogToolStripMenuItem });
            bankingToolStripMenuItem.Name = "bankingToolStripMenuItem";
            bankingToolStripMenuItem.Size = new Size(76, 24);
            bankingToolStripMenuItem.Text = "Banking";
            // 
            // depositAmountToolStripMenuItem
            // 
            depositAmountToolStripMenuItem.Name = "depositAmountToolStripMenuItem";
            depositAmountToolStripMenuItem.Size = new Size(224, 26);
            depositAmountToolStripMenuItem.Text = "Transaction Amount";
            depositAmountToolStripMenuItem.Click += depositAmountToolStripMenuItem_Click;
            // 
            // withdrawAmountToolStripMenuItem
            // 
            withdrawAmountToolStripMenuItem.Name = "withdrawAmountToolStripMenuItem";
            withdrawAmountToolStripMenuItem.Size = new Size(224, 26);
            withdrawAmountToolStripMenuItem.Text = "Withdraw Amount";
            withdrawAmountToolStripMenuItem.Click += withdrawAmountToolStripMenuItem_Click;
            // 
            // transactionAmountToolStripMenuItem
            // 
            transactionAmountToolStripMenuItem.Name = "transactionAmountToolStripMenuItem";
            transactionAmountToolStripMenuItem.Size = new Size(224, 26);
            transactionAmountToolStripMenuItem.Text = "Deposit Amount";
            transactionAmountToolStripMenuItem.Click += transactionAmountToolStripMenuItem_Click;
            // 
            // balanceAccountToolStripMenuItem
            // 
            balanceAccountToolStripMenuItem.Name = "balanceAccountToolStripMenuItem";
            balanceAccountToolStripMenuItem.Size = new Size(224, 26);
            balanceAccountToolStripMenuItem.Text = "Balance Account";
            balanceAccountToolStripMenuItem.Click += balanceAccountToolStripMenuItem_Click;
            // 
            // transactionLogToolStripMenuItem
            // 
            transactionLogToolStripMenuItem.Name = "transactionLogToolStripMenuItem";
            transactionLogToolStripMenuItem.Size = new Size(224, 26);
            transactionLogToolStripMenuItem.Text = "Transaction Log";
            transactionLogToolStripMenuItem.Click += transactionLogToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userGuideToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.Size = new Size(163, 26);
            userGuideToolStripMenuItem.Text = "User guide";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(163, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            WindowState = FormWindowState.Maximized;
            KeyDown += Trangchu_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MenuStrip menuStrip1;
        public ToolStripMenuItem fileToolStripMenuItem;
        public ToolStripMenuItem loginToolStripMenuItem;
        public ToolStripMenuItem logoutToolStripMenuItem;
        public ToolStripMenuItem exitToolStripMenuItem;
        public ToolStripMenuItem systemToolStripMenuItem;
        public ToolStripMenuItem employeeToolStripMenuItem;
        public ToolStripMenuItem branchToolStripMenuItem;
        public ToolStripMenuItem bankingToolStripMenuItem;
        public ToolStripMenuItem depositAmountToolStripMenuItem;
        public ToolStripMenuItem withdrawAmountToolStripMenuItem;
        public ToolStripMenuItem transactionAmountToolStripMenuItem;
        public ToolStripMenuItem balanceAccountToolStripMenuItem;
        public ToolStripMenuItem transactionLogToolStripMenuItem;
        public ToolStripMenuItem helpToolStripMenuItem;
        public ToolStripMenuItem userGuideToolStripMenuItem;
        public ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
    }
}