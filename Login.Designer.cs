
namespace SemesterProject
{
    partial class Login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.MintCream;
            this.login_btn.Location = new System.Drawing.Point(492, 310);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(146, 65);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(217, 107);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(55, 20);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(217, 177);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(82, 20);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password:";
            // 
            // name_input
            // 
            this.name_input.BackColor = System.Drawing.Color.MintCream;
            this.name_input.Location = new System.Drawing.Point(330, 107);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(159, 26);
            this.name_input.TabIndex = 3;
            this.name_input.TextChanged += new System.EventHandler(this.username_input_TextChanged);
            // 
            // password_input
            // 
            this.password_input.BackColor = System.Drawing.Color.MintCream;
            this.password_input.Location = new System.Drawing.Point(330, 177);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(159, 26);
            this.password_input.TabIndex = 4;
            this.password_input.TextChanged += new System.EventHandler(this.password_input_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.login_btn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox password_input;
    }
}

