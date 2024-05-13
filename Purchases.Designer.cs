
namespace SemesterProject
{
    partial class Purchases
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
            this.all_purc_radio = new System.Windows.Forms.RadioButton();
            this.date_purc_radio = new System.Windows.Forms.RadioButton();
            this.price_purc_radio = new System.Windows.Forms.RadioButton();
            this.max_date_picker = new System.Windows.Forms.DateTimePicker();
            this.min_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.min_price_picker = new System.Windows.Forms.NumericUpDown();
            this.max_price_picker = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.list_invoice_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.min_price_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_price_picker)).BeginInit();
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
            // all_purc_radio
            // 
            this.all_purc_radio.AutoSize = true;
            this.all_purc_radio.Location = new System.Drawing.Point(57, 100);
            this.all_purc_radio.Name = "all_purc_radio";
            this.all_purc_radio.Size = new System.Drawing.Size(130, 24);
            this.all_purc_radio.TabIndex = 9;
            this.all_purc_radio.TabStop = true;
            this.all_purc_radio.Text = "All Purchases";
            this.all_purc_radio.UseVisualStyleBackColor = true;
            this.all_purc_radio.CheckedChanged += new System.EventHandler(this.all_purc_radio_CheckedChanged);
            // 
            // date_purc_radio
            // 
            this.date_purc_radio.AutoSize = true;
            this.date_purc_radio.Location = new System.Drawing.Point(57, 215);
            this.date_purc_radio.Name = "date_purc_radio";
            this.date_purc_radio.Size = new System.Drawing.Size(145, 24);
            this.date_purc_radio.TabIndex = 10;
            this.date_purc_radio.TabStop = true;
            this.date_purc_radio.Text = "Purchases from";
            this.date_purc_radio.UseVisualStyleBackColor = true;
            this.date_purc_radio.CheckedChanged += new System.EventHandler(this.date_purc_radio_CheckedChanged);
            // 
            // price_purc_radio
            // 
            this.price_purc_radio.AutoSize = true;
            this.price_purc_radio.Location = new System.Drawing.Point(57, 158);
            this.price_purc_radio.Name = "price_purc_radio";
            this.price_purc_radio.Size = new System.Drawing.Size(145, 24);
            this.price_purc_radio.TabIndex = 11;
            this.price_purc_radio.TabStop = true;
            this.price_purc_radio.Text = "Purchases from";
            this.price_purc_radio.UseVisualStyleBackColor = true;
            this.price_purc_radio.CheckedChanged += new System.EventHandler(this.price_purc_radio_CheckedChanged);
            // 
            // max_date_picker
            // 
            this.max_date_picker.Location = new System.Drawing.Point(350, 271);
            this.max_date_picker.Name = "max_date_picker";
            this.max_date_picker.Size = new System.Drawing.Size(297, 26);
            this.max_date_picker.TabIndex = 12;
            this.max_date_picker.ValueChanged += new System.EventHandler(this.max_date_picker_ValueChanged);
            // 
            // min_date_picker
            // 
            this.min_date_picker.Location = new System.Drawing.Point(213, 215);
            this.min_date_picker.Name = "min_date_picker";
            this.min_date_picker.Size = new System.Drawing.Size(299, 26);
            this.min_date_picker.TabIndex = 13;
            this.min_date_picker.ValueChanged += new System.EventHandler(this.min_date_picker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "to";
            // 
            // min_price_picker
            // 
            this.min_price_picker.DecimalPlaces = 2;
            this.min_price_picker.Location = new System.Drawing.Point(213, 158);
            this.min_price_picker.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.min_price_picker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.min_price_picker.Name = "min_price_picker";
            this.min_price_picker.Size = new System.Drawing.Size(120, 26);
            this.min_price_picker.TabIndex = 16;
            this.min_price_picker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.min_price_picker.ValueChanged += new System.EventHandler(this.min_price_picker_ValueChanged);
            // 
            // max_price_picker
            // 
            this.max_price_picker.DecimalPlaces = 2;
            this.max_price_picker.Location = new System.Drawing.Point(407, 160);
            this.max_price_picker.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.max_price_picker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.max_price_picker.Name = "max_price_picker";
            this.max_price_picker.Size = new System.Drawing.Size(120, 26);
            this.max_price_picker.TabIndex = 17;
            this.max_price_picker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.max_price_picker.ValueChanged += new System.EventHandler(this.max_price_picker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Which purchases would you like to view?";
            // 
            // list_invoice_btn
            // 
            this.list_invoice_btn.BackColor = System.Drawing.Color.MintCream;
            this.list_invoice_btn.Location = new System.Drawing.Point(299, 321);
            this.list_invoice_btn.Name = "list_invoice_btn";
            this.list_invoice_btn.Size = new System.Drawing.Size(138, 89);
            this.list_invoice_btn.TabIndex = 20;
            this.list_invoice_btn.Text = "View Purchases";
            this.list_invoice_btn.UseVisualStyleBackColor = false;
            this.list_invoice_btn.Click += new System.EventHandler(this.list_invoice_btn_Click);
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_invoice_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.max_price_picker);
            this.Controls.Add(this.min_price_picker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min_date_picker);
            this.Controls.Add(this.max_date_picker);
            this.Controls.Add(this.price_purc_radio);
            this.Controls.Add(this.date_purc_radio);
            this.Controls.Add(this.all_purc_radio);
            this.Controls.Add(this.act_btn);
            this.Name = "Purchases";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.min_price_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_price_picker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button act_btn;
        private System.Windows.Forms.RadioButton all_purc_radio;
        private System.Windows.Forms.RadioButton date_purc_radio;
        private System.Windows.Forms.RadioButton price_purc_radio;
        private System.Windows.Forms.DateTimePicker max_date_picker;
        private System.Windows.Forms.DateTimePicker min_date_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown min_price_picker;
        private System.Windows.Forms.NumericUpDown max_price_picker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button list_invoice_btn;
    }
}