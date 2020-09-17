namespace ATM
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnbalance = new System.Windows.Forms.Button();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.btndeposit = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(212, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the function to operate";
            // 
            // btnbalance
            // 
            this.btnbalance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnbalance.BackColor = System.Drawing.Color.Thistle;
            this.btnbalance.ForeColor = System.Drawing.Color.Maroon;
            this.btnbalance.Location = new System.Drawing.Point(38, 172);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(155, 52);
            this.btnbalance.TabIndex = 1;
            this.btnbalance.Text = "Balance";
            this.btnbalance.UseVisualStyleBackColor = false;
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnwithdraw.BackColor = System.Drawing.Color.Thistle;
            this.btnwithdraw.ForeColor = System.Drawing.Color.Maroon;
            this.btnwithdraw.Location = new System.Drawing.Point(792, 172);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(155, 52);
            this.btnwithdraw.TabIndex = 2;
            this.btnwithdraw.Text = "Withdraw";
            this.btnwithdraw.UseVisualStyleBackColor = false;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // btndeposit
            // 
            this.btndeposit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndeposit.BackColor = System.Drawing.Color.Thistle;
            this.btndeposit.ForeColor = System.Drawing.Color.Maroon;
            this.btndeposit.Location = new System.Drawing.Point(38, 298);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(155, 52);
            this.btndeposit.TabIndex = 3;
            this.btndeposit.Text = "Deposit";
            this.btndeposit.UseVisualStyleBackColor = false;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // btnchange
            // 
            this.btnchange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnchange.BackColor = System.Drawing.Color.Thistle;
            this.btnchange.ForeColor = System.Drawing.Color.Maroon;
            this.btnchange.Location = new System.Drawing.Point(792, 298);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(155, 52);
            this.btnchange.TabIndex = 4;
            this.btnchange.Text = "Change Pin";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Thistle;
            this.btnback.ForeColor = System.Drawing.Color.Maroon;
            this.btnback.Location = new System.Drawing.Point(251, 617);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(173, 41);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Thistle;
            this.btnexit.ForeColor = System.Drawing.Color.Maroon;
            this.btnexit.Location = new System.Drawing.Point(497, 617);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(173, 41);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1019, 682);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btndeposit);
            this.Controls.Add(this.btnwithdraw);
            this.Controls.Add(this.btnbalance);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbalance;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnexit;
    }
}