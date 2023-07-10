namespace Portfel.UserControls
{
    partial class UserControlProceedsList
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
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewExpensesList = new System.Windows.Forms.ListView();
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonSerch = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.NumericValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.LabelData = new System.Windows.Forms.Label();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.ButtonInsertTransaction = new System.Windows.Forms.Button();
            this.TextBoxComment = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelComm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericValue)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Text = "Add time";
            this.Time.Width = 197;
            // 
            // CategoryID
            // 
            this.CategoryID.Text = "Category";
            this.CategoryID.Width = 159;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 192;
            // 
            // ID
            // 
            this.ID.Tag = "1";
            this.ID.Text = "ID";
            this.ID.Width = 65;
            // 
            // ListViewExpensesList
            // 
            this.ListViewExpensesList.BackColor = System.Drawing.Color.Black;
            this.ListViewExpensesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Amount,
            this.CategoryID,
            this.Comment,
            this.Time});
            this.ListViewExpensesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewExpensesList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListViewExpensesList.ForeColor = System.Drawing.Color.White;
            this.ListViewExpensesList.FullRowSelect = true;
            this.ListViewExpensesList.GridLines = true;
            this.ListViewExpensesList.HideSelection = false;
            this.ListViewExpensesList.Location = new System.Drawing.Point(0, 85);
            this.ListViewExpensesList.Name = "ListViewExpensesList";
            this.ListViewExpensesList.Size = new System.Drawing.Size(1000, 596);
            this.ListViewExpensesList.TabIndex = 7;
            this.ListViewExpensesList.UseCompatibleStateImageBehavior = false;
            this.ListViewExpensesList.View = System.Windows.Forms.View.Details;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 357;
            // 
            // ButtonSerch
            // 
            this.ButtonSerch.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonSerch.FlatAppearance.BorderSize = 0;
            this.ButtonSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSerch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSerch.ForeColor = System.Drawing.Color.White;
            this.ButtonSerch.Location = new System.Drawing.Point(305, 0);
            this.ButtonSerch.Name = "ButtonSerch";
            this.ButtonSerch.Size = new System.Drawing.Size(62, 85);
            this.ButtonSerch.TabIndex = 6;
            this.ButtonSerch.Text = "Serch";
            this.ButtonSerch.UseVisualStyleBackColor = true;
            this.ButtonSerch.Click += new System.EventHandler(this.ButtonSerch_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2.Location = new System.Drawing.Point(73, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(225, 21);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2023, 1, 17, 0, 0, 0, 0);
            this.dateTimePicker2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateTimePickerFrom_KeyDown);
            // 
            // NumericValue
            // 
            this.NumericValue.BackColor = System.Drawing.Color.Black;
            this.NumericValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.NumericValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericValue.ForeColor = System.Drawing.Color.White;
            this.NumericValue.Location = new System.Drawing.Point(929, 0);
            this.NumericValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericValue.Name = "NumericValue";
            this.NumericValue.Size = new System.Drawing.Size(71, 27);
            this.NumericValue.TabIndex = 9;
            this.NumericValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 20000;
            this.label1.Text = "To:";
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimePickerFrom.Location = new System.Drawing.Point(73, 9);
            this.DateTimePickerFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(225, 21);
            this.DateTimePickerFrom.TabIndex = 4;
            this.DateTimePickerFrom.Value = new System.DateTime(2023, 1, 16, 0, 0, 0, 0);
            this.DateTimePickerFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateTimePickerFrom_KeyDown);
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelData.ForeColor = System.Drawing.Color.White;
            this.LabelData.Location = new System.Drawing.Point(22, 10);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(45, 19);
            this.LabelData.TabIndex = 20000;
            this.LabelData.Text = "From:";
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxAmount.Location = new System.Drawing.Point(723, 51);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(200, 27);
            this.TextBoxAmount.TabIndex = 1;
            this.TextBoxAmount.TextChanged += new System.EventHandler(this.userTextChanged);
            this.TextBoxAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxComment_KeyDown);
            // 
            // ButtonInsertTransaction
            // 
            this.ButtonInsertTransaction.Enabled = false;
            this.ButtonInsertTransaction.FlatAppearance.BorderSize = 0;
            this.ButtonInsertTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInsertTransaction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonInsertTransaction.ForeColor = System.Drawing.Color.White;
            this.ButtonInsertTransaction.Location = new System.Drawing.Point(929, 37);
            this.ButtonInsertTransaction.Name = "ButtonInsertTransaction";
            this.ButtonInsertTransaction.Size = new System.Drawing.Size(71, 48);
            this.ButtonInsertTransaction.TabIndex = 2;
            this.ButtonInsertTransaction.Text = "Add";
            this.ButtonInsertTransaction.UseVisualStyleBackColor = true;
            this.ButtonInsertTransaction.Click += new System.EventHandler(this.ButtonInsertTransaction_Click);
            // 
            // TextBoxComment
            // 
            this.TextBoxComment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxComment.Location = new System.Drawing.Point(541, 7);
            this.TextBoxComment.Name = "TextBoxComment";
            this.TextBoxComment.Size = new System.Drawing.Size(382, 27);
            this.TextBoxComment.TabIndex = 0;
            this.TextBoxComment.TextChanged += new System.EventHandler(this.userTextChanged);
            this.TextBoxComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxComment_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonSerch);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DateTimePickerFrom);
            this.panel1.Controls.Add(this.LabelData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 85);
            this.panel1.TabIndex = 3;
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.Color.Transparent;
            this.PanelAdd.Controls.Add(this.label2);
            this.PanelAdd.Controls.Add(this.LabelComm);
            this.PanelAdd.Controls.Add(this.TextBoxAmount);
            this.PanelAdd.Controls.Add(this.ButtonInsertTransaction);
            this.PanelAdd.Controls.Add(this.TextBoxComment);
            this.PanelAdd.Controls.Add(this.NumericValue);
            this.PanelAdd.Controls.Add(this.panel1);
            this.PanelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAdd.Location = new System.Drawing.Point(0, 0);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(1000, 85);
            this.PanelAdd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(654, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 20000;
            this.label2.Text = "Ammount:";
            // 
            // LabelComm
            // 
            this.LabelComm.AutoSize = true;
            this.LabelComm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelComm.ForeColor = System.Drawing.Color.White;
            this.LabelComm.Location = new System.Drawing.Point(445, 7);
            this.LabelComm.Name = "LabelComm";
            this.LabelComm.Size = new System.Drawing.Size(90, 23);
            this.LabelComm.TabIndex = 20000;
            this.LabelComm.Text = "Comment:";
            // 
            // UserControlProceedsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewExpensesList);
            this.Controls.Add(this.PanelAdd);
            this.Name = "UserControlProceedsList";
            this.Size = new System.Drawing.Size(1000, 681);
            ((System.ComponentModel.ISupportInitialize)(this.NumericValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader CategoryID;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ListView ListViewExpensesList;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.Button ButtonSerch;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.NumericUpDown NumericValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.Button ButtonInsertTransaction;
        private System.Windows.Forms.TextBox TextBoxComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelComm;
    }
}
