
namespace CrmUI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.продавецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSaller = new System.Windows.Forms.ToolStripMenuItem();
            this.покупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарToolStripMenuItem,
            this.продавецToolStripMenuItem,
            this.покупательToolStripMenuItem,
            this.чекToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.сущностиToolStripMenuItem.Text = "Entities";
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProduct});
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.товарToolStripMenuItem.Text = "Product";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // addProduct
            // 
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(180, 22);
            this.addProduct.Text = "Add";
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // продавецToolStripMenuItem
            // 
            this.продавецToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSaller});
            this.продавецToolStripMenuItem.Name = "продавецToolStripMenuItem";
            this.продавецToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.продавецToolStripMenuItem.Text = "Seller";
            this.продавецToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // addSaller
            // 
            this.addSaller.Name = "addSaller";
            this.addSaller.Size = new System.Drawing.Size(96, 22);
            this.addSaller.Text = "Add";
            this.addSaller.Click += new System.EventHandler(this.addSaller_Click);
            // 
            // покупательToolStripMenuItem
            // 
            this.покупательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomer});
            this.покупательToolStripMenuItem.Name = "покупательToolStripMenuItem";
            this.покупательToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупательToolStripMenuItem.Text = "Customer";
            this.покупательToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(180, 22);
            this.addCustomer.Text = "Add";
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // чекToolStripMenuItem
            // 
            this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            this.чекToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.чекToolStripMenuItem.Text = "Check";
            this.чекToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 317);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProduct;
        private System.Windows.Forms.ToolStripMenuItem addSaller;
        private System.Windows.Forms.ToolStripMenuItem addCustomer;
    }
}