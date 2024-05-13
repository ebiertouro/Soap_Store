
namespace SemesterProject
{
    partial class Confirmation
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
            this.confirmation_text = new System.Windows.Forms.Label();
            this.view_cart_btn = new System.Windows.Forms.Button();
            this.purchase_btn = new System.Windows.Forms.Button();
            this.act_btn = new System.Windows.Forms.Button();
            this.item_label = new System.Windows.Forms.Label();
            this.product_info_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmation_text
            // 
            this.confirmation_text.AutoSize = true;
            this.confirmation_text.Location = new System.Drawing.Point(387, 38);
            this.confirmation_text.Name = "confirmation_text";
            this.confirmation_text.Size = new System.Drawing.Size(154, 20);
            this.confirmation_text.TabIndex = 0;
            this.confirmation_text.Text = "Purchase confirmed!";
            // 
            // view_cart_btn
            // 
            this.view_cart_btn.BackColor = System.Drawing.Color.MintCream;
            this.view_cart_btn.Location = new System.Drawing.Point(375, 306);
            this.view_cart_btn.Name = "view_cart_btn";
            this.view_cart_btn.Size = new System.Drawing.Size(132, 81);
            this.view_cart_btn.TabIndex = 1;
            this.view_cart_btn.Text = "View Cart";
            this.view_cart_btn.UseVisualStyleBackColor = false;
            this.view_cart_btn.Click += new System.EventHandler(this.view_cart_btn_Click);
            // 
            // purchase_btn
            // 
            this.purchase_btn.BackColor = System.Drawing.Color.MintCream;
            this.purchase_btn.Location = new System.Drawing.Point(562, 306);
            this.purchase_btn.Name = "purchase_btn";
            this.purchase_btn.Size = new System.Drawing.Size(132, 81);
            this.purchase_btn.TabIndex = 2;
            this.purchase_btn.Text = "Make Another Purchase";
            this.purchase_btn.UseVisualStyleBackColor = false;
            this.purchase_btn.Click += new System.EventHandler(this.purchase_btn_Click);
            // 
            // act_btn
            // 
            this.act_btn.BackColor = System.Drawing.Color.MintCream;
            this.act_btn.Location = new System.Drawing.Point(24, 22);
            this.act_btn.Name = "act_btn";
            this.act_btn.Size = new System.Drawing.Size(123, 36);
            this.act_btn.TabIndex = 8;
            this.act_btn.Text = "My Account";
            this.act_btn.UseVisualStyleBackColor = false;
            this.act_btn.Click += new System.EventHandler(this.act_btn_Click);
            // 
            // item_label
            // 
            this.item_label.AutoSize = true;
            this.item_label.Location = new System.Drawing.Point(339, 120);
            this.item_label.Name = "item_label";
            this.item_label.Size = new System.Drawing.Size(0, 20);
            this.item_label.TabIndex = 9;
            // 
            // product_info_label
            // 
            this.product_info_label.AutoSize = true;
            this.product_info_label.Location = new System.Drawing.Point(387, 143);
            this.product_info_label.Name = "product_info_label";
            this.product_info_label.Size = new System.Drawing.Size(0, 20);
            this.product_info_label.TabIndex = 10;
            this.product_info_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.product_info_label);
            this.Controls.Add(this.item_label);
            this.Controls.Add(this.act_btn);
            this.Controls.Add(this.purchase_btn);
            this.Controls.Add(this.view_cart_btn);
            this.Controls.Add(this.confirmation_text);
            this.Name = "Confirmation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmation_text;
        private System.Windows.Forms.Button view_cart_btn;
        private System.Windows.Forms.Button purchase_btn;
        private System.Windows.Forms.Button act_btn;
        private System.Windows.Forms.Label item_label;
        private System.Windows.Forms.Label product_info_label;
    }
}