
namespace SemesterProject
{
    partial class Balance
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
            this.act_btn = new System.Windows.Forms.Button();
            this.txt_label = new System.Windows.Forms.Label();
            this.display_bal_label = new System.Windows.Forms.Label();
            this.bal_btn = new System.Windows.Forms.RadioButton();
            this.other_btn = new System.Windows.Forms.RadioButton();
            this.amount_picker = new System.Windows.Forms.NumericUpDown();
            this.pay_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount_picker)).BeginInit();
            this.SuspendLayout();
            // 
            // act_btn
            // 
            this.act_btn.BackColor = System.Drawing.Color.MintCream;
            this.act_btn.Location = new System.Drawing.Point(12, 12);
            this.act_btn.Name = "act_btn";
            this.act_btn.Size = new System.Drawing.Size(123, 36);
            this.act_btn.TabIndex = 8;
            this.act_btn.Text = "My Account";
            this.act_btn.UseVisualStyleBackColor = false;
            this.act_btn.Click += new System.EventHandler(this.act_btn_Click);
            // 
            // txt_label
            // 
            this.txt_label.AutoSize = true;
            this.txt_label.Location = new System.Drawing.Point(251, 112);
            this.txt_label.Name = "txt_label";
            this.txt_label.Size = new System.Drawing.Size(176, 20);
            this.txt_label.TabIndex = 9;
            this.txt_label.Text = "Your current balance is:";
            // 
            // display_bal_label
            // 
            this.display_bal_label.AutoSize = true;
            this.display_bal_label.Location = new System.Drawing.Point(431, 112);
            this.display_bal_label.Name = "display_bal_label";
            this.display_bal_label.Size = new System.Drawing.Size(0, 20);
            this.display_bal_label.TabIndex = 10;
            // 
            // bal_btn
            // 
            this.bal_btn.AutoSize = true;
            this.bal_btn.Location = new System.Drawing.Point(272, 174);
            this.bal_btn.Name = "bal_btn";
            this.bal_btn.Size = new System.Drawing.Size(113, 24);
            this.bal_btn.TabIndex = 12;
            this.bal_btn.TabStop = true;
            this.bal_btn.Text = "Pay Balace";
            this.bal_btn.UseVisualStyleBackColor = true;
            this.bal_btn.CheckedChanged += new System.EventHandler(this.bal_btn_CheckedChanged);
            // 
            // other_btn
            // 
            this.other_btn.AutoSize = true;
            this.other_btn.Location = new System.Drawing.Point(272, 223);
            this.other_btn.Name = "other_btn";
            this.other_btn.Size = new System.Drawing.Size(181, 24);
            this.other_btn.TabIndex = 13;
            this.other_btn.TabStop = true;
            this.other_btn.Text = "Pay Another Amount";
            this.other_btn.UseVisualStyleBackColor = true;
            this.other_btn.CheckedChanged += new System.EventHandler(this.other_btn_CheckedChanged);
            // 
            // amount_picker
            // 
            this.amount_picker.BackColor = System.Drawing.Color.MintCream;
            this.amount_picker.DecimalPlaces = 2;
            this.amount_picker.Location = new System.Drawing.Point(502, 223);
            this.amount_picker.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amount_picker.Name = "amount_picker";
            this.amount_picker.Size = new System.Drawing.Size(78, 26);
            this.amount_picker.TabIndex = 14;
            this.amount_picker.ThousandsSeparator = true;
            this.amount_picker.ValueChanged += new System.EventHandler(this.amount_picker_ValueChanged);
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.MintCream;
            this.pay_btn.Location = new System.Drawing.Point(255, 330);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(172, 70);
            this.pay_btn.TabIndex = 15;
            this.pay_btn.Text = "Pay Now";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.amount_picker);
            this.Controls.Add(this.other_btn);
            this.Controls.Add(this.bal_btn);
            this.Controls.Add(this.display_bal_label);
            this.Controls.Add(this.txt_label);
            this.Controls.Add(this.act_btn);
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amount_picker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button act_btn;
        private System.Windows.Forms.Label txt_label;
        private System.Windows.Forms.Label display_bal_label;
        private System.Windows.Forms.RadioButton bal_btn;
        private System.Windows.Forms.RadioButton other_btn;
        private System.Windows.Forms.NumericUpDown amount_picker;
        private System.Windows.Forms.Button pay_btn;
    }
}