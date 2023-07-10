namespace Portfel.UserControls
{
    partial class UserControlSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelAddCategory = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelWrongData = new System.Windows.Forms.Label();
            this.ButtonAddType = new System.Windows.Forms.Button();
            this.TextBoxTyp = new System.Windows.Forms.TextBox();
            this.LabelAddTransaction = new System.Windows.Forms.Label();
            this.Timmer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelChangeUserdata = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioButtonUsername = new System.Windows.Forms.RadioButton();
            this.RadioButtonPassword = new System.Windows.Forms.RadioButton();
            this.LabelError = new System.Windows.Forms.Label();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.TextBoxNewName = new System.Windows.Forms.TextBox();
            this.LabelNewUsername = new System.Windows.Forms.Label();
            this.TextBoxNewPassword2 = new System.Windows.Forms.TextBox();
            this.TextBoxNewPassword = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelNewPassword2 = new System.Windows.Forms.Label();
            this.LabelNewPassword = new System.Windows.Forms.Label();
            this.LabelPasswordCurrent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelAddCategory.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelChangeUserdata.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAddCategory
            // 
            this.PanelAddCategory.Controls.Add(this.listView);
            this.PanelAddCategory.Controls.Add(this.LabelWrongData);
            this.PanelAddCategory.Controls.Add(this.ButtonAddType);
            this.PanelAddCategory.Controls.Add(this.TextBoxTyp);
            this.PanelAddCategory.Controls.Add(this.LabelAddTransaction);
            this.PanelAddCategory.Location = new System.Drawing.Point(10, 294);
            this.PanelAddCategory.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.PanelAddCategory.Name = "PanelAddCategory";
            this.PanelAddCategory.Size = new System.Drawing.Size(968, 144);
            this.PanelAddCategory.TabIndex = 1;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type});
            this.listView.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(722, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(246, 144);
            this.listView.TabIndex = 20000;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.VirtualListSize = 25;
            // 
            // Type
            // 
            this.Type.Text = "Category";
            this.Type.Width = 220;
            // 
            // LabelWrongData
            // 
            this.LabelWrongData.AutoSize = true;
            this.LabelWrongData.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelWrongData.Location = new System.Drawing.Point(133, 81);
            this.LabelWrongData.Name = "LabelWrongData";
            this.LabelWrongData.Size = new System.Drawing.Size(114, 26);
            this.LabelWrongData.TabIndex = 20000;
            this.LabelWrongData.Text = "Wrong Data";
            this.LabelWrongData.Visible = false;
            // 
            // ButtonAddType
            // 
            this.ButtonAddType.FlatAppearance.BorderSize = 0;
            this.ButtonAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddType.Location = new System.Drawing.Point(352, 29);
            this.ButtonAddType.Name = "ButtonAddType";
            this.ButtonAddType.Size = new System.Drawing.Size(96, 31);
            this.ButtonAddType.TabIndex = 1;
            this.ButtonAddType.Text = "Add";
            this.ButtonAddType.UseVisualStyleBackColor = true;
            this.ButtonAddType.Click += new System.EventHandler(this.ButtonAddType_Click);
            // 
            // TextBoxTyp
            // 
            this.TextBoxTyp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxTyp.Location = new System.Drawing.Point(138, 30);
            this.TextBoxTyp.MaxLength = 32;
            this.TextBoxTyp.Name = "TextBoxTyp";
            this.TextBoxTyp.Size = new System.Drawing.Size(208, 31);
            this.TextBoxTyp.TabIndex = 0;
            // 
            // LabelAddTransaction
            // 
            this.LabelAddTransaction.AutoSize = true;
            this.LabelAddTransaction.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAddTransaction.Location = new System.Drawing.Point(3, 31);
            this.LabelAddTransaction.Name = "LabelAddTransaction";
            this.LabelAddTransaction.Size = new System.Drawing.Size(129, 26);
            this.LabelAddTransaction.TabIndex = 20000;
            this.LabelAddTransaction.Text = "Add Category";
            // 
            // Timmer
            // 
            this.Timmer.Interval = 4000;
            this.Timmer.Tick += new System.EventHandler(this.Timmer_Tick_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.PanelChangeUserdata);
            this.flowLayoutPanel1.Controls.Add(this.PanelAddCategory);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 681);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PanelChangeUserdata
            // 
            this.PanelChangeUserdata.Controls.Add(this.label2);
            this.PanelChangeUserdata.Controls.Add(this.RadioButtonUsername);
            this.PanelChangeUserdata.Controls.Add(this.RadioButtonPassword);
            this.PanelChangeUserdata.Controls.Add(this.LabelError);
            this.PanelChangeUserdata.Controls.Add(this.ButtonAccept);
            this.PanelChangeUserdata.Controls.Add(this.TextBoxNewName);
            this.PanelChangeUserdata.Controls.Add(this.LabelNewUsername);
            this.PanelChangeUserdata.Controls.Add(this.TextBoxNewPassword2);
            this.PanelChangeUserdata.Controls.Add(this.TextBoxNewPassword);
            this.PanelChangeUserdata.Controls.Add(this.TextBoxPassword);
            this.PanelChangeUserdata.Controls.Add(this.LabelNewPassword2);
            this.PanelChangeUserdata.Controls.Add(this.LabelNewPassword);
            this.PanelChangeUserdata.Controls.Add(this.LabelPasswordCurrent);
            this.PanelChangeUserdata.ForeColor = System.Drawing.Color.White;
            this.PanelChangeUserdata.Location = new System.Drawing.Point(10, 10);
            this.PanelChangeUserdata.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.PanelChangeUserdata.Name = "PanelChangeUserdata";
            this.PanelChangeUserdata.Size = new System.Drawing.Size(968, 274);
            this.PanelChangeUserdata.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(592, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RadioButtonUsername
            // 
            this.RadioButtonUsername.AutoSize = true;
            this.RadioButtonUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonUsername.ForeColor = System.Drawing.Color.White;
            this.RadioButtonUsername.Location = new System.Drawing.Point(761, 66);
            this.RadioButtonUsername.Name = "RadioButtonUsername";
            this.RadioButtonUsername.Size = new System.Drawing.Size(192, 30);
            this.RadioButtonUsername.TabIndex = 6;
            this.RadioButtonUsername.Text = "Change User Name";
            this.RadioButtonUsername.UseVisualStyleBackColor = true;
            this.RadioButtonUsername.CheckedChanged += new System.EventHandler(this.RadioButtonPassword_CheckedChanged);
            // 
            // RadioButtonPassword
            // 
            this.RadioButtonPassword.AutoSize = true;
            this.RadioButtonPassword.Checked = true;
            this.RadioButtonPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonPassword.ForeColor = System.Drawing.Color.White;
            this.RadioButtonPassword.Location = new System.Drawing.Point(761, 30);
            this.RadioButtonPassword.Name = "RadioButtonPassword";
            this.RadioButtonPassword.Size = new System.Drawing.Size(179, 30);
            this.RadioButtonPassword.TabIndex = 5;
            this.RadioButtonPassword.TabStop = true;
            this.RadioButtonPassword.Text = "Change Password";
            this.RadioButtonPassword.UseVisualStyleBackColor = true;
            this.RadioButtonPassword.CheckedChanged += new System.EventHandler(this.RadioButtonPassword_CheckedChanged);
            // 
            // LabelError
            // 
            this.LabelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelError.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelError.ForeColor = System.Drawing.Color.White;
            this.LabelError.Location = new System.Drawing.Point(0, 0);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(968, 36);
            this.LabelError.TabIndex = 20000;
            this.LabelError.Text = "Error";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelError.Visible = false;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.FlatAppearance.BorderSize = 0;
            this.ButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccept.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAccept.ForeColor = System.Drawing.Color.White;
            this.ButtonAccept.Location = new System.Drawing.Point(378, 203);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(208, 31);
            this.ButtonAccept.TabIndex = 4;
            this.ButtonAccept.Text = "Set";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // TextBoxNewName
            // 
            this.TextBoxNewName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNewName.Location = new System.Drawing.Point(378, 55);
            this.TextBoxNewName.MaxLength = 32;
            this.TextBoxNewName.Name = "TextBoxNewName";
            this.TextBoxNewName.Size = new System.Drawing.Size(208, 33);
            this.TextBoxNewName.TabIndex = 1;
            // 
            // LabelNewUsername
            // 
            this.LabelNewUsername.AutoSize = true;
            this.LabelNewUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNewUsername.ForeColor = System.Drawing.Color.White;
            this.LabelNewUsername.Location = new System.Drawing.Point(221, 56);
            this.LabelNewUsername.Name = "LabelNewUsername";
            this.LabelNewUsername.Size = new System.Drawing.Size(151, 26);
            this.LabelNewUsername.TabIndex = 20000;
            this.LabelNewUsername.Text = "New user name:";
            this.LabelNewUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxNewPassword2
            // 
            this.TextBoxNewPassword2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNewPassword2.Location = new System.Drawing.Point(378, 166);
            this.TextBoxNewPassword2.MaxLength = 32;
            this.TextBoxNewPassword2.Name = "TextBoxNewPassword2";
            this.TextBoxNewPassword2.PasswordChar = '*';
            this.TextBoxNewPassword2.Size = new System.Drawing.Size(208, 33);
            this.TextBoxNewPassword2.TabIndex = 3;
            // 
            // TextBoxNewPassword
            // 
            this.TextBoxNewPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNewPassword.Location = new System.Drawing.Point(378, 129);
            this.TextBoxNewPassword.MaxLength = 32;
            this.TextBoxNewPassword.Name = "TextBoxNewPassword";
            this.TextBoxNewPassword.PasswordChar = '*';
            this.TextBoxNewPassword.Size = new System.Drawing.Size(208, 33);
            this.TextBoxNewPassword.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxPassword.Location = new System.Drawing.Point(378, 92);
            this.TextBoxPassword.MaxLength = 32;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(208, 33);
            this.TextBoxPassword.TabIndex = 0;
            // 
            // LabelNewPassword2
            // 
            this.LabelNewPassword2.AutoSize = true;
            this.LabelNewPassword2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNewPassword2.ForeColor = System.Drawing.Color.White;
            this.LabelNewPassword2.Location = new System.Drawing.Point(168, 167);
            this.LabelNewPassword2.Name = "LabelNewPassword2";
            this.LabelNewPassword2.Size = new System.Drawing.Size(204, 26);
            this.LabelNewPassword2.TabIndex = 20000;
            this.LabelNewPassword2.Text = "Repeat new password:";
            this.LabelNewPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelNewPassword
            // 
            this.LabelNewPassword.AutoSize = true;
            this.LabelNewPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNewPassword.ForeColor = System.Drawing.Color.White;
            this.LabelNewPassword.Location = new System.Drawing.Point(229, 130);
            this.LabelNewPassword.Name = "LabelNewPassword";
            this.LabelNewPassword.Size = new System.Drawing.Size(143, 26);
            this.LabelNewPassword.TabIndex = 20000;
            this.LabelNewPassword.Text = "New Password:";
            this.LabelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelPasswordCurrent
            // 
            this.LabelPasswordCurrent.AutoSize = true;
            this.LabelPasswordCurrent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPasswordCurrent.ForeColor = System.Drawing.Color.White;
            this.LabelPasswordCurrent.Location = new System.Drawing.Point(204, 95);
            this.LabelPasswordCurrent.Name = "LabelPasswordCurrent";
            this.LabelPasswordCurrent.Size = new System.Drawing.Size(168, 26);
            this.LabelPasswordCurrent.TabIndex = 20000;
            this.LabelPasswordCurrent.Text = "Current Password:";
            this.LabelPasswordCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(1000, 681);
            this.PanelAddCategory.ResumeLayout(false);
            this.PanelAddCategory.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelChangeUserdata.ResumeLayout(false);
            this.PanelChangeUserdata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAddCategory;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.Label LabelWrongData;
        private System.Windows.Forms.Button ButtonAddType;
        private System.Windows.Forms.TextBox TextBoxTyp;
        private System.Windows.Forms.Label LabelAddTransaction;
        public System.Windows.Forms.Timer Timmer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelChangeUserdata;
        private System.Windows.Forms.TextBox TextBoxNewPassword2;
        private System.Windows.Forms.TextBox TextBoxNewPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelNewPassword2;
        private System.Windows.Forms.Label LabelNewPassword;
        private System.Windows.Forms.Label LabelPasswordCurrent;
        private System.Windows.Forms.TextBox TextBoxNewName;
        private System.Windows.Forms.Label LabelNewUsername;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.RadioButton RadioButtonUsername;
        private System.Windows.Forms.RadioButton RadioButtonPassword;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer1;
    }
}
