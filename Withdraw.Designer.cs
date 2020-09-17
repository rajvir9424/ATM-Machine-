namespace ATM
{
    partial class Withdraw
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
            this.balancetext = new System.Windows.Forms.TextBox();
            this.showbalance = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.Withdrawamount = new System.Windows.Forms.Button();
            this.balancelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // balancetext
            // 
            this.balancetext.BackColor = System.Drawing.Color.Thistle;
            this.balancetext.ForeColor = System.Drawing.Color.Maroon;
            this.balancetext.Location = new System.Drawing.Point(51, 140);
            this.balancetext.Multiline = true;
            this.balancetext.Name = "balancetext";
            this.balancetext.Size = new System.Drawing.Size(237, 49);
            this.balancetext.TabIndex = 0;
            this.balancetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.balancetext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // showbalance
            // 
            this.showbalance.BackColor = System.Drawing.Color.Thistle;
            this.showbalance.ForeColor = System.Drawing.Color.Maroon;
            this.showbalance.Location = new System.Drawing.Point(379, 140);
            this.showbalance.Name = "showbalance";
            this.showbalance.Size = new System.Drawing.Size(160, 43);
            this.showbalance.TabIndex = 1;
            this.showbalance.Text = "Show balance";
            this.showbalance.UseVisualStyleBackColor = false;
            this.showbalance.Click += new System.EventHandler(this.showbalance_Click);
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.Thistle;
            this.amount.ForeColor = System.Drawing.Color.Maroon;
            this.amount.Location = new System.Drawing.Point(51, 291);
            this.amount.Multiline = true;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(237, 49);
            this.amount.TabIndex = 2;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Withdrawamount
            // 
            this.Withdrawamount.BackColor = System.Drawing.Color.Thistle;
            this.Withdrawamount.ForeColor = System.Drawing.Color.Maroon;
            this.Withdrawamount.Location = new System.Drawing.Point(379, 293);
            this.Withdrawamount.Name = "Withdrawamount";
            this.Withdrawamount.Size = new System.Drawing.Size(166, 47);
            this.Withdrawamount.TabIndex = 3;
            this.Withdrawamount.Text = "Withdraw";
            this.Withdrawamount.UseVisualStyleBackColor = false;
            this.Withdrawamount.Click += new System.EventHandler(this.Withdrawamount_Click);
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.Location = new System.Drawing.Point(560, 119);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(0, 20);
            this.balancelbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check your Balance and Withdraw Money";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balancelbl);
            this.Controls.Add(this.Withdrawamount);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.showbalance);
            this.Controls.Add(this.balancetext);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox balancetext;
        private System.Windows.Forms.Button showbalance;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button Withdrawamount;
        private System.Windows.Forms.Label balancelbl;
        private System.Windows.Forms.Label label1;
    }
}