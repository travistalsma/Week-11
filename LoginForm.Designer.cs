namespace Midterm
{
    partial class LoginForm
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
            this.CusNumTB = new System.Windows.Forms.TextBox();
            this.PinTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CusNumTB
            // 
            this.CusNumTB.Location = new System.Drawing.Point(152, 56);
            this.CusNumTB.Name = "CusNumTB";
            this.CusNumTB.Size = new System.Drawing.Size(177, 20);
            this.CusNumTB.TabIndex = 0;
            this.CusNumTB.TextChanged += new System.EventHandler(this.CusNumTB_TextChanged);
            // 
            // PinTB
            // 
            this.PinTB.Location = new System.Drawing.Point(152, 107);
            this.PinTB.Name = "PinTB";
            this.PinTB.Size = new System.Drawing.Size(177, 20);
            this.PinTB.TabIndex = 1;
            this.PinTB.TextChanged += new System.EventHandler(this.PinTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PIN";
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(162, 168);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(75, 23);
            this.LoginBTN.TabIndex = 4;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 232);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PinTB);
            this.Controls.Add(this.CusNumTB);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CusNumTB;
        private System.Windows.Forms.TextBox PinTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBTN;
    }
}

