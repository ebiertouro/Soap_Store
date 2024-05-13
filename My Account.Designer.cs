
namespace SemesterProject
{
    partial class My_Account
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
            this.shop_btn = new System.Windows.Forms.Button();
            this.balance_btn = new System.Windows.Forms.Button();
            this.purchases_btn = new System.Windows.Forms.Button();
            this.cart_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shop_btn
            // 
            this.shop_btn.BackColor = System.Drawing.Color.MintCream;
            this.shop_btn.Location = new System.Drawing.Point(222, 58);
            this.shop_btn.Name = "shop_btn";
            this.shop_btn.Size = new System.Drawing.Size(127, 99);
            this.shop_btn.TabIndex = 0;
            this.shop_btn.Text = "Shop";
            this.shop_btn.UseVisualStyleBackColor = false;
            this.shop_btn.Click += new System.EventHandler(this.shop_btn_Click);
            // 
            // balance_btn
            // 
            this.balance_btn.BackColor = System.Drawing.Color.MintCream;
            this.balance_btn.Location = new System.Drawing.Point(396, 191);
            this.balance_btn.Name = "balance_btn";
            this.balance_btn.Size = new System.Drawing.Size(135, 122);
            this.balance_btn.TabIndex = 2;
            this.balance_btn.Text = "Check and Pay Balance";
            this.balance_btn.UseVisualStyleBackColor = false;
            this.balance_btn.Click += new System.EventHandler(this.balance_btn_Click);
            // 
            // purchases_btn
            // 
            this.purchases_btn.BackColor = System.Drawing.Color.MintCream;
            this.purchases_btn.Location = new System.Drawing.Point(222, 191);
            this.purchases_btn.Name = "purchases_btn";
            this.purchases_btn.Size = new System.Drawing.Size(127, 122);
            this.purchases_btn.TabIndex = 4;
            this.purchases_btn.Text = "View Past Purchases";
            this.purchases_btn.UseVisualStyleBackColor = false;
            this.purchases_btn.Click += new System.EventHandler(this.purchases_btn_Click);
            // 
            // cart_btn
            // 
            this.cart_btn.BackColor = System.Drawing.Color.MintCream;
            this.cart_btn.Location = new System.Drawing.Point(396, 58);
            this.cart_btn.Name = "cart_btn";
            this.cart_btn.Size = new System.Drawing.Size(135, 99);
            this.cart_btn.TabIndex = 5;
            this.cart_btn.Text = "View Cart";
            this.cart_btn.UseVisualStyleBackColor = false;
            this.cart_btn.Click += new System.EventHandler(this.cart_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.MintCream;
            this.logout_btn.Location = new System.Drawing.Point(589, 349);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(170, 67);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // My_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.cart_btn);
            this.Controls.Add(this.purchases_btn);
            this.Controls.Add(this.balance_btn);
            this.Controls.Add(this.shop_btn);
            this.Name = "My_Account";
            this.Text = "My Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shop_btn;
        private System.Windows.Forms.Button balance_btn;
        private System.Windows.Forms.Button purchases_btn;
        private System.Windows.Forms.Button cart_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}