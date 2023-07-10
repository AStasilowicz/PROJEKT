namespace Portfel
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LabelUsername = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonTransactionList = new System.Windows.Forms.Button();
            this.ButtonProceedsList = new System.Windows.Forms.Button();
            this.ButtonExpensesList = new System.Windows.Forms.Button();
            this.PanelProfil = new System.Windows.Forms.Panel();
            this.LabelSaldo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelUserID = new System.Windows.Forms.Label();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.PictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.TimmerRefreshAccountSaldo = new System.Windows.Forms.Timer(this.components);
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.TimerAccountName = new System.Windows.Forms.Timer(this.components);
            this.PanelUser.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelProfil.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.BackColor = System.Drawing.Color.Transparent;
            this.LabelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelUsername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUsername.Location = new System.Drawing.Point(45, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(174, 22);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Username";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Exit.Location = new System.Drawing.Point(1061, 822);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PanelUser
            // 
            this.PanelUser.Controls.Add(this.flowLayoutPanel1);
            this.PanelUser.Controls.Add(this.PanelProfil);
            this.PanelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelUser.Location = new System.Drawing.Point(0, 0);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(264, 681);
            this.PanelUser.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ButtonTransactionList);
            this.flowLayoutPanel1.Controls.Add(this.ButtonProceedsList);
            this.flowLayoutPanel1.Controls.Add(this.ButtonExpensesList);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 601);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ButtonTransactionList
            // 
            this.ButtonTransactionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTransactionList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonTransactionList.Location = new System.Drawing.Point(10, 10);
            this.ButtonTransactionList.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ButtonTransactionList.Name = "ButtonTransactionList";
            this.ButtonTransactionList.Size = new System.Drawing.Size(244, 53);
            this.ButtonTransactionList.TabIndex = 0;
            this.ButtonTransactionList.Text = "Transaction List";
            this.ButtonTransactionList.UseVisualStyleBackColor = true;
            this.ButtonTransactionList.Click += new System.EventHandler(this.ButtonTransactionList_Click);
            this.ButtonTransactionList.Enter += new System.EventHandler(this.ButtonTransactionList_Enter);
            this.ButtonTransactionList.Leave += new System.EventHandler(this.ButtonTransactionList_Leave);
            this.ButtonTransactionList.MouseEnter += new System.EventHandler(this.ButtonTransactionList_Enter);
            this.ButtonTransactionList.MouseLeave += new System.EventHandler(this.ButtonTransactionList_Leave);
            // 
            // ButtonProceedsList
            // 
            this.ButtonProceedsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProceedsList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonProceedsList.Location = new System.Drawing.Point(10, 73);
            this.ButtonProceedsList.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ButtonProceedsList.Name = "ButtonProceedsList";
            this.ButtonProceedsList.Size = new System.Drawing.Size(244, 53);
            this.ButtonProceedsList.TabIndex = 1;
            this.ButtonProceedsList.Text = "Proceeds List";
            this.ButtonProceedsList.UseVisualStyleBackColor = true;
            this.ButtonProceedsList.Click += new System.EventHandler(this.ButtonProceedsList_Click);
            this.ButtonProceedsList.Enter += new System.EventHandler(this.ButtonProceedsList_Enter);
            this.ButtonProceedsList.Leave += new System.EventHandler(this.ButtonProceedsList_Leave);
            this.ButtonProceedsList.MouseEnter += new System.EventHandler(this.ButtonProceedsList_Enter);
            this.ButtonProceedsList.MouseLeave += new System.EventHandler(this.ButtonProceedsList_Leave);
            // 
            // ButtonExpensesList
            // 
            this.ButtonExpensesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExpensesList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonExpensesList.Location = new System.Drawing.Point(10, 136);
            this.ButtonExpensesList.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ButtonExpensesList.Name = "ButtonExpensesList";
            this.ButtonExpensesList.Size = new System.Drawing.Size(244, 53);
            this.ButtonExpensesList.TabIndex = 2;
            this.ButtonExpensesList.Text = "Expenses List";
            this.ButtonExpensesList.UseVisualStyleBackColor = true;
            this.ButtonExpensesList.Click += new System.EventHandler(this.ButtonExpensesList_Click);
            this.ButtonExpensesList.Enter += new System.EventHandler(this.ButtonExpensesList_Enter);
            this.ButtonExpensesList.Leave += new System.EventHandler(this.ButtonExpensesList_Leave);
            this.ButtonExpensesList.MouseEnter += new System.EventHandler(this.ButtonExpensesList_Enter);
            this.ButtonExpensesList.MouseLeave += new System.EventHandler(this.ButtonExpensesList_Leave);
            // 
            // PanelProfil
            // 
            this.PanelProfil.BackColor = System.Drawing.Color.Transparent;
            this.PanelProfil.Controls.Add(this.LabelSaldo);
            this.PanelProfil.Controls.Add(this.panel1);
            this.PanelProfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelProfil.Location = new System.Drawing.Point(0, 601);
            this.PanelProfil.Margin = new System.Windows.Forms.Padding(0);
            this.PanelProfil.Name = "PanelProfil";
            this.PanelProfil.Size = new System.Drawing.Size(264, 80);
            this.PanelProfil.TabIndex = 1;
            // 
            // LabelSaldo
            // 
            this.LabelSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LabelSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSaldo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSaldo.Location = new System.Drawing.Point(0, 0);
            this.LabelSaldo.Name = "LabelSaldo";
            this.LabelSaldo.Size = new System.Drawing.Size(264, 35);
            this.LabelSaldo.TabIndex = 3;
            this.LabelSaldo.Text = "Saldo";
            this.LabelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PictureBoxSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelUsername);
            this.panel2.Controls.Add(this.LabelUserID);
            this.panel2.Controls.Add(this.PictureBoxProfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 45);
            this.panel2.TabIndex = 5;
            // 
            // LabelUserID
            // 
            this.LabelUserID.BackColor = System.Drawing.Color.Transparent;
            this.LabelUserID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelUserID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUserID.Location = new System.Drawing.Point(45, 23);
            this.LabelUserID.Name = "LabelUserID";
            this.LabelUserID.Size = new System.Drawing.Size(174, 22);
            this.LabelUserID.TabIndex = 4;
            this.LabelUserID.Text = "#UserID";
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBoxProfile.Image = global::Portfel.Properties.Resources.User_Ico;
            this.PictureBoxProfile.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(45, 45);
            this.PictureBoxProfile.TabIndex = 4;
            this.PictureBoxProfile.TabStop = false;
            // 
            // PictureBoxSettings
            // 
            this.PictureBoxSettings.BackgroundImage = global::Portfel.Properties.Resources.Setting;
            this.PictureBoxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBoxSettings.Location = new System.Drawing.Point(219, 0);
            this.PictureBoxSettings.Name = "PictureBoxSettings";
            this.PictureBoxSettings.Size = new System.Drawing.Size(45, 45);
            this.PictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxSettings.TabIndex = 6;
            this.PictureBoxSettings.TabStop = false;
            this.PictureBoxSettings.Click += new System.EventHandler(this.PictureBoxSettings_Click);
            // 
            // TimmerRefreshAccountSaldo
            // 
            this.TimmerRefreshAccountSaldo.Enabled = true;
            this.TimmerRefreshAccountSaldo.Interval = 10000;
            this.TimmerRefreshAccountSaldo.Tick += new System.EventHandler(this.TimmerRefreshAccountSaldo_Tick);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(264, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1000, 681);
            this.PanelContainer.TabIndex = 1;
            // 
            // TimerAccountName
            // 
            this.TimerAccountName.Enabled = true;
            this.TimerAccountName.Interval = 10000;
            this.TimerAccountName.Tick += new System.EventHandler(this.TimerAccountName_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallet";
            this.PanelUser.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelProfil.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel PanelUser;
        public System.Windows.Forms.Timer TimmerRefreshAccountSaldo;
        private System.Windows.Forms.Label LabelSaldo;
        private System.Windows.Forms.Panel PanelProfil;
        private System.Windows.Forms.PictureBox PictureBoxProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelUserID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PictureBoxSettings;
        private System.Windows.Forms.Button ButtonTransactionList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonProceedsList;
        private System.Windows.Forms.Button ButtonExpensesList;
        private System.Windows.Forms.Panel PanelContainer;
        public System.Windows.Forms.Timer TimerAccountName;
    }
}