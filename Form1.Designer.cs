namespace ATM
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pintext = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(173, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your pin to start";
            // 
            // pintext
            // 
            this.pintext.BackColor = System.Drawing.Color.Thistle;
            this.pintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pintext.ForeColor = System.Drawing.Color.Maroon;
            this.pintext.Location = new System.Drawing.Point(170, 142);
            this.pintext.Multiline = true;
            this.pintext.Name = "pintext";
            this.pintext.Size = new System.Drawing.Size(411, 70);
            this.pintext.TabIndex = 2;
            this.pintext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pintext.TextChanged += new System.EventHandler(this.pintext_TextChanged);
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.Color.Thistle;
            this.btnenter.ForeColor = System.Drawing.Color.Maroon;
            this.btnenter.Location = new System.Drawing.Point(141, 290);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(130, 48);
            this.btnenter.TabIndex = 3;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Thistle;
            this.btnclear.ForeColor = System.Drawing.Color.Maroon;
            this.btnclear.Location = new System.Drawing.Point(436, 290);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(130, 48);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.pintext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pintext;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnclear;
    }
}

