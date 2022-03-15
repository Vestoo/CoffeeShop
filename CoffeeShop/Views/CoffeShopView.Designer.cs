
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
            this.dgvCoffeeShop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffeeShop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCoffeeShop
            // 
            this.dgvCoffeeShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoffeeShop.Location = new System.Drawing.Point(49, 49);
            this.dgvCoffeeShop.Name = "dgvCoffeeShop";
            this.dgvCoffeeShop.Size = new System.Drawing.Size(406, 150);
            this.dgvCoffeeShop.TabIndex = 0;
            // 
            // CoffeShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCoffeeShop);
            this.Name = "CoffeShopView";
            this.Text = "CoffeShopForm";
            this.Load += new System.EventHandler(this.CoffeShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffeeShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCoffeeShop;
    }
}