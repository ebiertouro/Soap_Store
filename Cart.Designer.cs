
namespace SemesterProject
{
    partial class Cart
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
            this.cart_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.act_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.total_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cart_txt
            // 
            this.cart_txt.AutoSize = true;
            this.cart_txt.Location = new System.Drawing.Point(297, 13);
            this.cart_txt.Name = "cart_txt";
            this.cart_txt.Size = new System.Drawing.Size(39, 20);
            this.cart_txt.TabIndex = 0;
            this.cart_txt.Text = "Cart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cart total: ";
            // 
            // act_btn
            // 
            this.act_btn.BackColor = System.Drawing.Color.MintCream;
            this.act_btn.Location = new System.Drawing.Point(24, 27);
            this.act_btn.Name = "act_btn";
            this.act_btn.Size = new System.Drawing.Size(123, 36);
            this.act_btn.TabIndex = 8;
            this.act_btn.Text = "My Account";
            this.act_btn.UseVisualStyleBackColor = false;
            this.act_btn.Click += new System.EventHandler(this.act_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.MintCream;
            this.dashboard_btn.Location = new System.Drawing.Point(197, 207);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(184, 93);
            this.dashboard_btn.TabIndex = 9;
            this.dashboard_btn.Text = "Continue Shopping";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // checkout_btn
            // 
            this.checkout_btn.BackColor = System.Drawing.Color.MintCream;
            this.checkout_btn.Location = new System.Drawing.Point(436, 207);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(181, 93);
            this.checkout_btn.TabIndex = 10;
            this.checkout_btn.Text = "Check Out";
            this.checkout_btn.UseVisualStyleBackColor = false;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(240, 97);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(0, 20);
            this.total_label.TabIndex = 11;
            this.total_label.Click += new System.EventHandler(this.total_label_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.dashboard_btn);
            this.Controls.Add(this.act_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cart_txt);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cart_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button act_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.Label total_label;
    }
}