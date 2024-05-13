
namespace SemesterProject
{
    partial class Display_Purchases
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
            this.invoice_displayer = new System.Windows.Forms.DataGridView();
            this.home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_displayer)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice_displayer
            // 
            this.invoice_displayer.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.invoice_displayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoice_displayer.GridColor = System.Drawing.Color.MintCream;
            this.invoice_displayer.Location = new System.Drawing.Point(34, 114);
            this.invoice_displayer.Name = "invoice_displayer";
            this.invoice_displayer.RowHeadersWidth = 62;
            this.invoice_displayer.RowTemplate.Height = 28;
            this.invoice_displayer.Size = new System.Drawing.Size(716, 268);
            this.invoice_displayer.TabIndex = 0;
            this.invoice_displayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.MintCream;
            this.home_btn.Location = new System.Drawing.Point(34, 32);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(122, 53);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "My Account";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // Display_Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.invoice_displayer);
            this.Name = "Display_Purchases";
            this.Text = "Display Purchases";
            this.Load += new System.EventHandler(this.Display_Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoice_displayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView invoice_displayer;
        private System.Windows.Forms.Button home_btn;
    }
}