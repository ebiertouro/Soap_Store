
namespace SemesterProject
{
    partial class Shop
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
            this.home_btn = new System.Windows.Forms.Button();
            this.cart_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_selector = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soap_products = new SemesterProject.soap_products();
            this.quantity_selector = new System.Windows.Forms.NumericUpDown();
            this.productsTableAdapter = new SemesterProject.soap_productsTableAdapters.ProductsTableAdapter();
            this.shop_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soap_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_selector)).BeginInit();
            this.SuspendLayout();
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.MintCream;
            this.home_btn.Location = new System.Drawing.Point(39, 42);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(127, 44);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "My Account";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // cart_btn
            // 
            this.cart_btn.BackColor = System.Drawing.Color.MintCream;
            this.cart_btn.Location = new System.Drawing.Point(603, 357);
            this.cart_btn.Name = "cart_btn";
            this.cart_btn.Size = new System.Drawing.Size(127, 44);
            this.cart_btn.TabIndex = 1;
            this.cart_btn.Text = "Add to Cart";
            this.cart_btn.UseVisualStyleBackColor = false;
            this.cart_btn.Click += new System.EventHandler(this.cart_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a product: ";
            // 
            // product_selector
            // 
            this.product_selector.BackColor = System.Drawing.Color.MintCream;
            this.product_selector.CausesValidation = false;
            this.product_selector.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "product_id", true));
            this.product_selector.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productsBindingSource, "product_id", true));
            this.product_selector.DataSource = this.productsBindingSource;
            this.product_selector.DisplayMember = "description";
            this.product_selector.FormattingEnabled = true;
            this.product_selector.Location = new System.Drawing.Point(174, 150);
            this.product_selector.Name = "product_selector";
            this.product_selector.Size = new System.Drawing.Size(342, 28);
            this.product_selector.TabIndex = 4;
            this.product_selector.SelectedIndexChanged += new System.EventHandler(this.product_selector_SelectedIndexChanged);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.soap_products;
            // 
            // soap_products
            // 
            this.soap_products.DataSetName = "soap_products";
            this.soap_products.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantity_selector
            // 
            this.quantity_selector.BackColor = System.Drawing.Color.MintCream;
            this.quantity_selector.Location = new System.Drawing.Point(671, 150);
            this.quantity_selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity_selector.Name = "quantity_selector";
            this.quantity_selector.Size = new System.Drawing.Size(59, 26);
            this.quantity_selector.TabIndex = 5;
            this.quantity_selector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity_selector.ValueChanged += new System.EventHandler(this.quantity_selector_ValueChanged);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // shop_btn
            // 
            this.shop_btn.BackColor = System.Drawing.Color.MintCream;
            this.shop_btn.Location = new System.Drawing.Point(372, 62);
            this.shop_btn.Name = "shop_btn";
            this.shop_btn.Size = new System.Drawing.Size(127, 44);
            this.shop_btn.TabIndex = 6;
            this.shop_btn.Text = "Shop";
            this.shop_btn.UseVisualStyleBackColor = false;
            this.shop_btn.Click += new System.EventHandler(this.shop_btn_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shop_btn);
            this.Controls.Add(this.quantity_selector);
            this.Controls.Add(this.product_selector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cart_btn);
            this.Controls.Add(this.home_btn);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soap_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_selector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button cart_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox product_selector;
        private System.Windows.Forms.NumericUpDown quantity_selector;
        private soap_products soap_products;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private soap_productsTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button shop_btn;
    }
}