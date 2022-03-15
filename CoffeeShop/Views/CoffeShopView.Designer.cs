
namespace CoffeeShop.Views
{
    partial class CoffeShopView
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
            this.dgvCoffeeShop = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffeeShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCoffeeShop
            // 
            this.dgvCoffeeShop.AutoGenerateColumns = false;
            this.dgvCoffeeShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoffeeShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sortNameDataGridViewTextBoxColumn,
            this.sortPriceDataGridViewTextBoxColumn,
            this.sortQuantityDataGridViewTextBoxColumn});
            this.dgvCoffeeShop.DataSource = this.tableBindingSource;
            this.dgvCoffeeShop.Location = new System.Drawing.Point(49, 49);
            this.dgvCoffeeShop.Name = "dgvCoffeeShop";
            this.dgvCoffeeShop.Size = new System.Drawing.Size(406, 150);
            this.dgvCoffeeShop.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(704, 49);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(67, 54);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Sort";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(704, 133);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(67, 54);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "Set a price";
            this.btnPrice.UseVisualStyleBackColor = true;
            // 
            // btnQuantity
            // 
            this.btnQuantity.Location = new System.Drawing.Point(704, 219);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(67, 54);
            this.btnQuantity.TabIndex = 3;
            this.btnQuantity.Text = "Update quantity";
            this.btnQuantity.UseVisualStyleBackColor = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(CoffeeShop.Models.Table);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // sortNameDataGridViewTextBoxColumn
            // 
            this.sortNameDataGridViewTextBoxColumn.DataPropertyName = "SortName";
            this.sortNameDataGridViewTextBoxColumn.HeaderText = "SortName";
            this.sortNameDataGridViewTextBoxColumn.Name = "sortNameDataGridViewTextBoxColumn";
            // 
            // sortPriceDataGridViewTextBoxColumn
            // 
            this.sortPriceDataGridViewTextBoxColumn.DataPropertyName = "SortPrice";
            this.sortPriceDataGridViewTextBoxColumn.HeaderText = "SortPrice";
            this.sortPriceDataGridViewTextBoxColumn.Name = "sortPriceDataGridViewTextBoxColumn";
            // 
            // sortQuantityDataGridViewTextBoxColumn
            // 
            this.sortQuantityDataGridViewTextBoxColumn.DataPropertyName = "SortQuantity";
            this.sortQuantityDataGridViewTextBoxColumn.HeaderText = "SortQuantity";
            this.sortQuantityDataGridViewTextBoxColumn.Name = "sortQuantityDataGridViewTextBoxColumn";
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(581, 67);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(100, 20);
            this.txtCreate.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(581, 151);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(581, 237);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 6;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(517, 70);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(60, 13);
            this.lblCreate.TabIndex = 7;
            this.lblCreate.Text = "Create Sort";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(517, 154);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Set a price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(493, 240);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 13);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Update quantity";
            // 
            // CoffeShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.btnQuantity);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvCoffeeShop);
            this.Name = "CoffeShopView";
            this.Text = "CoffeShopForm";
            this.Load += new System.EventHandler(this.CoffeShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffeeShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCoffeeShop;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
    }
}