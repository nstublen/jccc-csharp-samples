namespace JCCC.Samples.ErrorProvider
{
    partial class FormErrorProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormErrorProvider));
            System.Windows.Forms.Label invoiceIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label productTotalLabel;
            System.Windows.Forms.Label salesTaxLabel;
            System.Windows.Forms.Label shippingLabel;
            System.Windows.Forms.Label invoiceTotalLabel;
            this.invoicesDataSet = new JCCC.Samples.ErrorProvider.InvoicesDataSet();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new JCCC.Samples.ErrorProvider.InvoicesDataSetTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new JCCC.Samples.ErrorProvider.InvoicesDataSetTableAdapters.TableAdapterManager();
            this.invoicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.invoicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.shippingTextBox = new System.Windows.Forms.TextBox();
            this.invoiceTotalTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            invoiceIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            productTotalLabel = new System.Windows.Forms.Label();
            salesTaxLabel = new System.Windows.Forms.Label();
            shippingLabel = new System.Windows.Forms.Label();
            invoiceTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).BeginInit();
            this.invoicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesDataSet
            // 
            this.invoicesDataSet.DataSetName = "InvoicesDataSet";
            this.invoicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.invoicesDataSet;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = JCCC.Samples.ErrorProvider.InvoicesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoicesBindingNavigator
            // 
            this.invoicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoicesBindingNavigator.BindingSource = this.invoicesBindingSource;
            this.invoicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.invoicesBindingNavigatorSaveItem});
            this.invoicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoicesBindingNavigator.Name = "invoicesBindingNavigator";
            this.invoicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoicesBindingNavigator.Size = new System.Drawing.Size(332, 25);
            this.invoicesBindingNavigator.TabIndex = 0;
            this.invoicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // invoicesBindingNavigatorSaveItem
            // 
            this.invoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoicesBindingNavigatorSaveItem.Image")));
            this.invoicesBindingNavigatorSaveItem.Name = "invoicesBindingNavigatorSaveItem";
            this.invoicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.invoicesBindingNavigatorSaveItem.Text = "Save Data";
            this.invoicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoicesBindingNavigatorSaveItem_Click);
            // 
            // invoiceIDLabel
            // 
            invoiceIDLabel.AutoSize = true;
            invoiceIDLabel.Location = new System.Drawing.Point(32, 57);
            invoiceIDLabel.Name = "invoiceIDLabel";
            invoiceIDLabel.Size = new System.Drawing.Size(59, 13);
            invoiceIDLabel.TabIndex = 1;
            invoiceIDLabel.Text = "Invoice ID:";
            // 
            // invoiceIDTextBox
            // 
            this.invoiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceID", true));
            this.invoiceIDTextBox.Location = new System.Drawing.Point(112, 54);
            this.invoiceIDTextBox.Name = "invoiceIDTextBox";
            this.invoiceIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoiceIDTextBox.TabIndex = 2;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(32, 83);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 3;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(112, 80);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerIDTextBox.TabIndex = 4;
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(32, 110);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            invoiceDateLabel.TabIndex = 5;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(112, 106);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateDateTimePicker.TabIndex = 6;
            // 
            // productTotalLabel
            // 
            productTotalLabel.AutoSize = true;
            productTotalLabel.Location = new System.Drawing.Point(32, 135);
            productTotalLabel.Name = "productTotalLabel";
            productTotalLabel.Size = new System.Drawing.Size(74, 13);
            productTotalLabel.TabIndex = 7;
            productTotalLabel.Text = "Product Total:";
            // 
            // productTotalTextBox
            // 
            this.productTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "ProductTotal", true));
            this.productTotalTextBox.Location = new System.Drawing.Point(112, 132);
            this.productTotalTextBox.Name = "productTotalTextBox";
            this.productTotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.productTotalTextBox.TabIndex = 8;
            // 
            // salesTaxLabel
            // 
            salesTaxLabel.AutoSize = true;
            salesTaxLabel.Location = new System.Drawing.Point(32, 161);
            salesTaxLabel.Name = "salesTaxLabel";
            salesTaxLabel.Size = new System.Drawing.Size(57, 13);
            salesTaxLabel.TabIndex = 9;
            salesTaxLabel.Text = "Sales Tax:";
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "SalesTax", true));
            this.salesTaxTextBox.Location = new System.Drawing.Point(112, 158);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.Size = new System.Drawing.Size(200, 20);
            this.salesTaxTextBox.TabIndex = 10;
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.Location = new System.Drawing.Point(32, 187);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new System.Drawing.Size(51, 13);
            shippingLabel.TabIndex = 11;
            shippingLabel.Text = "Shipping:";
            // 
            // shippingTextBox
            // 
            this.shippingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Shipping", true));
            this.shippingTextBox.Location = new System.Drawing.Point(112, 184);
            this.shippingTextBox.Name = "shippingTextBox";
            this.shippingTextBox.Size = new System.Drawing.Size(200, 20);
            this.shippingTextBox.TabIndex = 12;
            // 
            // invoiceTotalLabel
            // 
            invoiceTotalLabel.AutoSize = true;
            invoiceTotalLabel.Location = new System.Drawing.Point(32, 213);
            invoiceTotalLabel.Name = "invoiceTotalLabel";
            invoiceTotalLabel.Size = new System.Drawing.Size(72, 13);
            invoiceTotalLabel.TabIndex = 13;
            invoiceTotalLabel.Text = "Invoice Total:";
            // 
            // invoiceTotalTextBox
            // 
            this.invoiceTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceTotal", true));
            this.invoiceTotalTextBox.Location = new System.Drawing.Point(112, 210);
            this.invoiceTotalTextBox.Name = "invoiceTotalTextBox";
            this.invoiceTotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoiceTotalTextBox.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataMember = "";
            this.errorProvider1.DataSource = this.invoicesBindingSource;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 264);
            this.Controls.Add(invoiceIDLabel);
            this.Controls.Add(this.invoiceIDTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(productTotalLabel);
            this.Controls.Add(this.productTotalTextBox);
            this.Controls.Add(salesTaxLabel);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(shippingLabel);
            this.Controls.Add(this.shippingTextBox);
            this.Controls.Add(invoiceTotalLabel);
            this.Controls.Add(this.invoiceTotalTextBox);
            this.Controls.Add(this.invoicesBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).EndInit();
            this.invoicesBindingNavigator.ResumeLayout(false);
            this.invoicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InvoicesDataSet invoicesDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private InvoicesDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private InvoicesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invoicesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton invoicesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoiceIDTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.TextBox productTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox shippingTextBox;
        private System.Windows.Forms.TextBox invoiceTotalTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}