
namespace Lab4 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.dtRequired = new System.Windows.Forms.DateTimePicker();
            this.dtShipped = new System.Windows.Forms.DateTimePicker();
            this.lblShipped = new System.Windows.Forms.Label();
            this.orderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.lblOrderTotalCalc = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.checkBoxNull = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(18, 55);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(78, 13);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Enter Order ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(120, 52);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(226, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(18, 115);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(18, 145);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // dtOrder
            // 
            this.dtOrder.Enabled = false;
            this.dtOrder.Location = new System.Drawing.Point(120, 138);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(200, 20);
            this.dtOrder.TabIndex = 5;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(120, 112);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 6;
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(18, 172);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(79, 13);
            this.lblRequiredDate.TabIndex = 7;
            this.lblRequiredDate.Text = "Required Date:";
            // 
            // dtRequired
            // 
            this.dtRequired.Enabled = false;
            this.dtRequired.Location = new System.Drawing.Point(120, 165);
            this.dtRequired.Name = "dtRequired";
            this.dtRequired.Size = new System.Drawing.Size(200, 20);
            this.dtRequired.TabIndex = 8;
            // 
            // dtShipped
            // 
            this.dtShipped.Enabled = false;
            this.dtShipped.Location = new System.Drawing.Point(120, 192);
            this.dtShipped.Name = "dtShipped";
            this.dtShipped.Size = new System.Drawing.Size(200, 20);
            this.dtShipped.TabIndex = 9;
            this.dtShipped.ValueChanged += new System.EventHandler(this.dtShipped_ValueChanged);
            // 
            // lblShipped
            // 
            this.lblShipped.AutoSize = true;
            this.lblShipped.Location = new System.Drawing.Point(18, 199);
            this.lblShipped.Name = "lblShipped";
            this.lblShipped.Size = new System.Drawing.Size(75, 13);
            this.lblShipped.TabIndex = 10;
            this.lblShipped.Text = "Shipped Date:";
            // 
            // orderDetailDataGridView
            // 
            this.orderDetailDataGridView.AutoGenerateColumns = false;
            this.orderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.orderDetailDataGridView.DataSource = this.orderDetailBindingSource;
            this.orderDetailDataGridView.Location = new System.Drawing.Point(21, 273);
            this.orderDetailDataGridView.Name = "orderDetailDataGridView";
            this.orderDetailDataGridView.ReadOnly = true;
            this.orderDetailDataGridView.Size = new System.Drawing.Size(543, 138);
            this.orderDetailDataGridView.TabIndex = 11;
            // 
            // lblOrderTotalCalc
            // 
            this.lblOrderTotalCalc.AutoSize = true;
            this.lblOrderTotalCalc.Location = new System.Drawing.Point(493, 254);
            this.lblOrderTotalCalc.Name = "lblOrderTotalCalc";
            this.lblOrderTotalCalc.Size = new System.Drawing.Size(35, 13);
            this.lblOrderTotalCalc.TabIndex = 12;
            this.lblOrderTotalCalc.Text = "label1";
            this.lblOrderTotalCalc.Visible = false;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(424, 254);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(63, 13);
            this.lblOrderTotal.TabIndex = 13;
            this.lblOrderTotal.Text = "Order Total:";
            this.lblOrderTotal.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(120, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // checkBoxNull
            // 
            this.checkBoxNull.AutoSize = true;
            this.checkBoxNull.Enabled = false;
            this.checkBoxNull.Location = new System.Drawing.Point(327, 194);
            this.checkBoxNull.Name = "checkBoxNull";
            this.checkBoxNull.Size = new System.Drawing.Size(61, 17);
            this.checkBoxNull.TabIndex = 16;
            this.checkBoxNull.Text = "Is Null?";
            this.checkBoxNull.UseVisualStyleBackColor = true;
            this.checkBoxNull.CheckedChanged += new System.EventHandler(this.checkBoxNull_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(Lab4.OrderDetail);
            // 
            // orderDetailDBBindingSource
            // 
            this.orderDetailDBBindingSource.DataSource = typeof(Lab4.OrderDetailDB);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 436);
            this.Controls.Add(this.checkBoxNull);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.lblOrderTotalCalc);
            this.Controls.Add(this.orderDetailDataGridView);
            this.Controls.Add(this.lblShipped);
            this.Controls.Add(this.dtShipped);
            this.Controls.Add(this.dtRequired);
            this.Controls.Add(this.lblRequiredDate);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.dtOrder);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblRequiredDate;
        private System.Windows.Forms.DateTimePicker dtRequired;
        private System.Windows.Forms.DateTimePicker dtShipped;
        private System.Windows.Forms.Label lblShipped;
        private System.Windows.Forms.BindingSource orderDetailDBBindingSource;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridView orderDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblOrderTotalCalc;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox checkBoxNull;
    }
}

