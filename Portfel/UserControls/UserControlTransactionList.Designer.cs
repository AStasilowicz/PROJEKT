namespace Portfel.UserControls
{
    partial class UserControlTransactionList
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListViewTransaction = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumPanel = new System.Windows.Forms.Panel();
            this.LabelNoData = new System.Windows.Forms.Label();
            this.NumericValue = new System.Windows.Forms.NumericUpDown();
            this.ButtonSerch = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.NumPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListViewTransaction);
            this.panel2.Controls.Add(this.NumPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 681);
            this.panel2.TabIndex = 0;
            // 
            // ListViewTransaction
            // 
            this.ListViewTransaction.BackColor = System.Drawing.Color.Black;
            this.ListViewTransaction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Amount,
            this.CategoryID,
            this.Comment,
            this.Time});
            this.ListViewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewTransaction.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListViewTransaction.ForeColor = System.Drawing.Color.White;
            this.ListViewTransaction.FullRowSelect = true;
            this.ListViewTransaction.GridLines = true;
            this.ListViewTransaction.HideSelection = false;
            this.ListViewTransaction.Location = new System.Drawing.Point(0, 34);
            this.ListViewTransaction.Name = "ListViewTransaction";
            this.ListViewTransaction.Size = new System.Drawing.Size(1000, 647);
            this.ListViewTransaction.TabIndex = 20;
            this.ListViewTransaction.UseCompatibleStateImageBehavior = false;
            this.ListViewTransaction.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Tag = "1";
            this.ID.Text = "ID";
            this.ID.Width = 56;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 192;
            // 
            // CategoryID
            // 
            this.CategoryID.Text = "Category";
            this.CategoryID.Width = 163;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 385;
            // 
            // Time
            // 
            this.Time.Text = "Add time";
            this.Time.Width = 197;
            // 
            // NumPanel
            // 
            this.NumPanel.Controls.Add(this.LabelNoData);
            this.NumPanel.Controls.Add(this.NumericValue);
            this.NumPanel.Controls.Add(this.ButtonSerch);
            this.NumPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumPanel.Location = new System.Drawing.Point(0, 0);
            this.NumPanel.Name = "NumPanel";
            this.NumPanel.Size = new System.Drawing.Size(1000, 34);
            this.NumPanel.TabIndex = 0;
            // 
            // LabelNoData
            // 
            this.LabelNoData.AutoSize = true;
            this.LabelNoData.BackColor = System.Drawing.Color.Transparent;
            this.LabelNoData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNoData.ForeColor = System.Drawing.Color.Red;
            this.LabelNoData.Location = new System.Drawing.Point(3, 5);
            this.LabelNoData.Name = "LabelNoData";
            this.LabelNoData.Size = new System.Drawing.Size(74, 23);
            this.LabelNoData.TabIndex = 2;
            this.LabelNoData.Text = "No Data";
            this.LabelNoData.Visible = false;
            // 
            // NumericValue
            // 
            this.NumericValue.BackColor = System.Drawing.Color.Black;
            this.NumericValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumericValue.ForeColor = System.Drawing.Color.White;
            this.NumericValue.Location = new System.Drawing.Point(861, 3);
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
            this.NumericValue.TabIndex = 0;
            this.NumericValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ButtonSerch
            // 
            this.ButtonSerch.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonSerch.FlatAppearance.BorderSize = 0;
            this.ButtonSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSerch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSerch.ForeColor = System.Drawing.Color.White;
            this.ButtonSerch.Location = new System.Drawing.Point(938, 0);
            this.ButtonSerch.Name = "ButtonSerch";
            this.ButtonSerch.Size = new System.Drawing.Size(62, 34);
            this.ButtonSerch.TabIndex = 1;
            this.ButtonSerch.Text = "Serch";
            this.ButtonSerch.UseVisualStyleBackColor = true;
            this.ButtonSerch.Click += new System.EventHandler(this.ButtonSerch_Click);
            // 
            // UserControlTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UserControlTransactionList";
            this.Size = new System.Drawing.Size(1000, 681);
            this.panel2.ResumeLayout(false);
            this.NumPanel.ResumeLayout(false);
            this.NumPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView ListViewTransaction;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader CategoryID;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Panel NumPanel;
        public System.Windows.Forms.NumericUpDown NumericValue;
        private System.Windows.Forms.Button ButtonSerch;
        private System.Windows.Forms.Label LabelNoData;
    }
}
