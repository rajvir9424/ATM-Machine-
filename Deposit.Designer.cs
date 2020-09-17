namespace ATM
{
    partial class Deposit
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
            this.deposittext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depositbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deposittext
            // 
            this.deposittext.BackColor = System.Drawing.Color.Thistle;
            this.deposittext.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposittext.ForeColor = System.Drawing.Color.Maroon;
            this.deposittext.Location = new System.Drawing.Point(232, 181);
            this.deposittext.Name = "deposittext";
            this.deposittext.Size = new System.Drawing.Size(343, 49);
            this.deposittext.TabIndex = 0;
            this.deposittext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(182, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the amount to deposit";
            // 
            // depositbtn
            // 
            this.depositbtn.BackColor = System.Drawing.Color.Thistle;
            this.depositbtn.ForeColor = System.Drawing.Color.Maroon;
            this.depositbtn.Location = new System.Drawing.Point(298, 283);
            this.depositbtn.Name = "depositbtn";
            this.depositbtn.Size = new System.Drawing.Size(218, 49);
            this.depositbtn.TabIndex = 2;
            this.depositbtn.Text = "Deposit";
            this.depositbtn.UseVisualStyleBackColor = false;
            this.depositbtn.Click += new System.EventHandler(this.depositbtn_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 539);
            this.Controls.Add(this.depositbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deposittext);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deposittext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button depositbtn;
    }
}