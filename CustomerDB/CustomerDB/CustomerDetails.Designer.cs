namespace CustomerDB
{
    partial class CustomerDetails
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnListCustomers = new System.Windows.Forms.Button();
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tblContent = new System.Windows.Forms.TableLayoutPanel();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tblCustomreDetails = new System.Windows.Forms.TableLayoutPanel();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tblContent.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.tblCustomreDetails.SuspendLayout();
            this.tblSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(533, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(773, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(773, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 45);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(533, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Location = new System.Drawing.Point(292, 99);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(135, 45);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnListCustomers
            // 
            this.btnListCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCustomers.Location = new System.Drawing.Point(52, 99);
            this.btnListCustomers.Name = "btnListCustomers";
            this.btnListCustomers.Size = new System.Drawing.Size(135, 45);
            this.btnListCustomers.TabIndex = 2;
            this.btnListCustomers.Text = "List Customers";
            this.btnListCustomers.UseVisualStyleBackColor = true;
            this.btnListCustomers.Click += new System.EventHandler(this.btnListCustomers_Click);
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 20;
            this.lbxCustomers.Location = new System.Drawing.Point(3, 135);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(477, 324);
            this.lbxCustomers.TabIndex = 0;
            this.lbxCustomers.SelectedIndexChanged += new System.EventHandler(this.lbxCustomers_SelectedIndexChanged);
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(219, 250);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(206, 26);
            this.tbxPhone.TabIndex = 2;
            this.tbxPhone.Enter += new System.EventHandler(this.tbxPhone_Enter);
            this.tbxPhone.Leave += new System.EventHandler(this.tbxPhone_Leave);
            // 
            // tbxLastname
            // 
            this.tbxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastname.Location = new System.Drawing.Point(219, 167);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(206, 26);
            this.tbxLastname.TabIndex = 1;
            this.tbxLastname.Enter += new System.EventHandler(this.tbxLastname_Enter);
            this.tbxLastname.Leave += new System.EventHandler(this.tbxLastname_Leave);
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstname.Location = new System.Drawing.Point(219, 85);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(206, 26);
            this.tbxFirstname.TabIndex = 0;
            this.tbxFirstname.Enter += new System.EventHandler(this.tbxFirstname_Enter);
            this.tbxFirstname.Leave += new System.EventHandler(this.tbxFirstname_Leave);
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerDetails.AutoSize = true;
            this.tblCustomreDetails.SetColumnSpan(this.lblCustomerDetails, 2);
            this.lblCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.Location = new System.Drawing.Point(100, 29);
            this.lblCustomerDetails.Margin = new System.Windows.Forms.Padding(100, 0, 3, 0);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(229, 24);
            this.lblCustomerDetails.TabIndex = 20;
            this.lblCustomerDetails.Text = "Enter Customer Details:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(100, 247);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(100, 0, 3, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Phone:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(100, 82);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(100, 0, 3, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(90, 20);
            this.lblFirstname.TabIndex = 21;
            this.lblFirstname.Text = "First Name:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(100, 164);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(100, 0, 3, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(90, 20);
            this.lblLastname.TabIndex = 22;
            this.lblLastname.Text = "Last Name:";
            // 
            // tblContent
            // 
            this.tblContent.ColumnCount = 2;
            this.tblContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContent.Controls.Add(this.tblButtons, 0, 2);
            this.tblContent.Controls.Add(this.tblCustomreDetails, 1, 1);
            this.tblContent.Controls.Add(this.tblSearch, 0, 0);
            this.tblContent.Controls.Add(this.lbxCustomers, 0, 1);
            this.tblContent.Location = new System.Drawing.Point(56, 22);
            this.tblContent.Name = "tblContent";
            this.tblContent.RowCount = 3;
            this.tblContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.5347F));
            this.tblContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.46529F));
            this.tblContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tblContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblContent.Size = new System.Drawing.Size(966, 633);
            this.tblContent.TabIndex = 34;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButtons.ColumnCount = 4;
            this.tblContent.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tblButtons.Controls.Add(this.btnAdd, 3, 0);
            this.tblButtons.Controls.Add(this.btnUpdate, 2, 0);
            this.tblButtons.Controls.Add(this.btnClear, 3, 1);
            this.tblButtons.Controls.Add(this.btnDelete, 2, 1);
            this.tblButtons.Controls.Add(this.btnClearList, 1, 1);
            this.tblButtons.Controls.Add(this.btnListCustomers, 0, 1);
            this.tblButtons.Location = new System.Drawing.Point(3, 467);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 2;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Size = new System.Drawing.Size(960, 163);
            this.tblButtons.TabIndex = 3;
            // 
            // tblCustomreDetails
            // 
            this.tblCustomreDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCustomreDetails.ColumnCount = 2;
            this.tblCustomreDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.28302F));
            this.tblCustomreDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.tblCustomreDetails.Controls.Add(this.tbxPhone, 1, 3);
            this.tblCustomreDetails.Controls.Add(this.tbxLastname, 1, 2);
            this.tblCustomreDetails.Controls.Add(this.tbxFirstname, 1, 1);
            this.tblCustomreDetails.Controls.Add(this.lblPhone, 0, 3);
            this.tblCustomreDetails.Controls.Add(this.lblLastname, 0, 2);
            this.tblCustomreDetails.Controls.Add(this.lblFirstname, 0, 1);
            this.tblCustomreDetails.Controls.Add(this.lblCustomerDetails, 0, 0);
            this.tblCustomreDetails.Location = new System.Drawing.Point(486, 135);
            this.tblCustomreDetails.Name = "tblCustomreDetails";
            this.tblCustomreDetails.RowCount = 4;
            this.tblCustomreDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCustomreDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCustomreDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblCustomreDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tblCustomreDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCustomreDetails.Size = new System.Drawing.Size(477, 326);
            this.tblCustomreDetails.TabIndex = 2;
            // 
            // tblSearch
            // 
            this.tblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSearch.ColumnCount = 2;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSearch.Controls.Add(this.lblCustomerName, 0, 0);
            this.tblSearch.Controls.Add(this.btnSearch, 1, 1);
            this.tblSearch.Controls.Add(this.tbxCustomerName, 0, 1);
            this.tblSearch.Location = new System.Drawing.Point(3, 3);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 2;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSearch.Size = new System.Drawing.Size(477, 126);
            this.tblSearch.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(3, 39);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(222, 24);
            this.lblCustomerName.TabIndex = 17;
            this.lblCustomerName.Text = "Enter Customer Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(241, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCustomerName.Location = new System.Drawing.Point(3, 81);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(232, 26);
            this.tbxCustomerName.TabIndex = 0;
            this.tbxCustomerName.Enter += new System.EventHandler(this.tbxCustomerName_Enter);
            this.tbxCustomerName.Leave += new System.EventHandler(this.tbxCustomerName_Leave);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tblContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Database";
            this.tblContent.ResumeLayout(false);
            this.tblButtons.ResumeLayout(false);
            this.tblCustomreDetails.ResumeLayout(false);
            this.tblCustomreDetails.PerformLayout();
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnListCustomers;
        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TableLayoutPanel tblContent;
        private System.Windows.Forms.TableLayoutPanel tblSearch;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TableLayoutPanel tblCustomreDetails;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
    }
}

