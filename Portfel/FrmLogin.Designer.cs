namespace Portfel
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
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.LabeltTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelPassCorrect = new System.Windows.Forms.Label();
            this.Timmer = new System.Windows.Forms.Timer(this.components);
            this.PanelLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.BackColor = System.Drawing.Color.Black;
            this.TextBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxLogin.Location = new System.Drawing.Point(20, 46);
            this.TextBoxLogin.MaxLength = 32;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(221, 26);
            this.TextBoxLogin.TabIndex = 0;
            this.TextBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxLogin_KeyDown);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxPassword.Location = new System.Drawing.Point(20, 124);
            this.TextBoxPassword.MaxLength = 32;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(221, 26);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxLogin_KeyDown);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelLogin.Location = new System.Drawing.Point(16, 24);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(75, 19);
            this.LabelLogin.TabIndex = 2000;
            this.LabelLogin.Text = "Username";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPassword.Location = new System.Drawing.Point(16, 102);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(71, 19);
            this.LabelPassword.TabIndex = 20001;
            this.LabelPassword.Text = "Password";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLogin.Location = new System.Drawing.Point(20, 169);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(221, 41);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Sing in";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.ButtonLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxLogin_KeyDown);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRegister.Location = new System.Drawing.Point(105, 419);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(260, 41);
            this.ButtonRegister.TabIndex = 1;
            this.ButtonRegister.Text = "Sing up";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Controls.Add(this.TextBoxLogin);
            this.PanelLogin.Controls.Add(this.LabelPassword);
            this.PanelLogin.Controls.Add(this.TextBoxPassword);
            this.PanelLogin.Controls.Add(this.ButtonLogin);
            this.PanelLogin.Location = new System.Drawing.Point(105, 178);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(260, 225);
            this.PanelLogin.TabIndex = 0;
            // 
            // LabeltTitle
            // 
            this.LabeltTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabeltTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabeltTitle.Location = new System.Drawing.Point(105, 131);
            this.LabeltTitle.Name = "LabeltTitle";
            this.LabeltTitle.Size = new System.Drawing.Size(260, 44);
            this.LabeltTitle.TabIndex = 20003;
            this.LabeltTitle.Text = "Sing in to Wallet";
            this.LabeltTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(864, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 681);
            this.panel1.TabIndex = 2000;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 681);
            this.panel2.TabIndex = 2000;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabelPassCorrect);
            this.panel3.Controls.Add(this.LabeltTitle);
            this.panel3.Controls.Add(this.ButtonRegister);
            this.panel3.Controls.Add(this.PanelLogin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 681);
            this.panel3.TabIndex = 0;
            // 
            // LabelPassCorrect
            // 
            this.LabelPassCorrect.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassCorrect.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPassCorrect.Location = new System.Drawing.Point(0, 476);
            this.LabelPassCorrect.Name = "LabelPassCorrect";
            this.LabelPassCorrect.Size = new System.Drawing.Size(464, 175);
            this.LabelPassCorrect.TabIndex = 2000;
            this.LabelPassCorrect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelPassCorrect.Visible = false;
            // 
            // Timmer
            // 
            this.Timmer.Interval = 4000;
            this.Timmer.Tick += new System.EventHandler(this.Timmer_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallet";
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label LabeltTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelPassCorrect;
        public System.Windows.Forms.Timer Timmer;
    }
}

