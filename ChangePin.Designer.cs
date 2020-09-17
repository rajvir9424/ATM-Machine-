namespace ATM
{
    partial class ChangePin
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
            this.newpin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.oldpin = new System.Windows.Forms.TextBox();
            this.oldenter = new System.Windows.Forms.Button();
            this.oldclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newpin
            // 
            this.newpin.BackColor = System.Drawing.Color.Thistle;
            this.newpin.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpin.ForeColor = System.Drawing.Color.Maroon;
            this.newpin.Location = new System.Drawing.Point(337, 231);
            this.newpin.Multiline = true;
            this.newpin.Name = "newpin";
            this.newpin.Size = new System.Drawing.Size(216, 42);
            this.newpin.TabIndex = 0;
            this.newpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newpin.TextChanged += new System.EventHandler(this.pintext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(-4, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter New pin ";
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.Color.Thistle;
            this.btnenter.ForeColor = System.Drawing.Color.Maroon;
            this.btnenter.Location = new System.Drawing.Point(266, 305);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(137, 38);
            this.btnenter.TabIndex = 2;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Thistle;
            this.btnclear.ForeColor = System.Drawing.Color.Maroon;
            this.btnclear.Location = new System.Drawing.Point(488, 305);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(137, 38);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Old pin ";
            // 
            // oldpin
            // 
            this.oldpin.BackColor = System.Drawing.Color.Thistle;
            this.oldpin.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpin.ForeColor = System.Drawing.Color.Maroon;
            this.oldpin.Location = new System.Drawing.Point(337, 48);
            this.oldpin.Multiline = true;
            this.oldpin.Name = "oldpin";
            this.oldpin.Size = new System.Drawing.Size(225, 43);
            this.oldpin.TabIndex = 5;
            this.oldpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldpin.TextChanged += new System.EventHandler(this.oldpin_TextChanged);
            // 
            // oldenter
            // 
            this.oldenter.BackColor = System.Drawing.Color.Thistle;
            this.oldenter.ForeColor = System.Drawing.Color.Maroon;
            this.oldenter.Location = new System.Drawing.Point(266, 137);
            this.oldenter.Name = "oldenter";
            this.oldenter.Size = new System.Drawing.Size(137, 38);
            this.oldenter.TabIndex = 6;
            this.oldenter.Text = "Enter";
            this.oldenter.UseVisualStyleBackColor = false;
            this.oldenter.Click += new System.EventHandler(this.oldenter_Click);
            // 
            // oldclear
            // 
            this.oldclear.BackColor = System.Drawing.Color.Thistle;
            this.oldclear.ForeColor = System.Drawing.Color.Maroon;
            this.oldclear.Location = new System.Drawing.Point(501, 137);
            this.oldclear.Name = "oldclear";
            this.oldclear.Size = new System.Drawing.Size(137, 38);
            this.oldclear.TabIndex = 7;
            this.oldclear.Text = "Clear";
            this.oldclear.UseVisualStyleBackColor = false;
            this.oldclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oldclear);
            this.Controls.Add(this.oldenter);
            this.Controls.Add(this.oldpin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newpin);
            this.Name = "ChangePin";
            this.Text = "ChangePin";
            this.Load += new System.EventHandler(this.ChangePin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newpin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldpin;
        private System.Windows.Forms.Button oldenter;
        private System.Windows.Forms.Button oldclear;
    }
}