namespace Midterm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.WithCheck = new System.Windows.Forms.Button();
            this.WithSav = new System.Windows.Forms.Button();
            this.TransC2S = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ViewCheck = new System.Windows.Forms.Button();
            this.ViewSav = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.TransS2C = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.CustNumLabel = new System.Windows.Forms.Label();
            this.customerDataDataSet = new Midterm.CustomerDataDataSet();
            this.customerDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WithCheck
            // 
            this.WithCheck.Location = new System.Drawing.Point(83, 48);
            this.WithCheck.Name = "WithCheck";
            this.WithCheck.Size = new System.Drawing.Size(75, 54);
            this.WithCheck.TabIndex = 0;
            this.WithCheck.Text = "Withdraw Checking";
            this.WithCheck.UseVisualStyleBackColor = true;
            this.WithCheck.Click += new System.EventHandler(this.WithCheck_Click);
            // 
            // WithSav
            // 
            this.WithSav.Location = new System.Drawing.Point(220, 48);
            this.WithSav.Name = "WithSav";
            this.WithSav.Size = new System.Drawing.Size(75, 54);
            this.WithSav.TabIndex = 1;
            this.WithSav.Text = "Withdraw Savings";
            this.WithSav.UseVisualStyleBackColor = true;
            this.WithSav.Click += new System.EventHandler(this.WithSav_Click);
            // 
            // TransC2S
            // 
            this.TransC2S.Location = new System.Drawing.Point(353, 48);
            this.TransC2S.Name = "TransC2S";
            this.TransC2S.Size = new System.Drawing.Size(75, 54);
            this.TransC2S.TabIndex = 2;
            this.TransC2S.Text = "Transfer Checking to Savings";
            this.TransC2S.UseVisualStyleBackColor = true;
            this.TransC2S.Click += new System.EventHandler(this.TransC2S_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(83, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 30);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ViewCheck
            // 
            this.ViewCheck.Location = new System.Drawing.Point(83, 133);
            this.ViewCheck.Name = "ViewCheck";
            this.ViewCheck.Size = new System.Drawing.Size(75, 54);
            this.ViewCheck.TabIndex = 4;
            this.ViewCheck.Text = "View Checking";
            this.ViewCheck.UseVisualStyleBackColor = true;
            this.ViewCheck.Click += new System.EventHandler(this.ViewCheck_Click);
            // 
            // ViewSav
            // 
            this.ViewSav.Location = new System.Drawing.Point(220, 133);
            this.ViewSav.Name = "ViewSav";
            this.ViewSav.Size = new System.Drawing.Size(75, 54);
            this.ViewSav.TabIndex = 5;
            this.ViewSav.Text = "View Savings";
            this.ViewSav.UseVisualStyleBackColor = true;
            this.ViewSav.Click += new System.EventHandler(this.ViewSav_Click);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(132, 231);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(212, 20);
            this.Amount.TabIndex = 6;
            this.Amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TransS2C
            // 
            this.TransS2C.Location = new System.Drawing.Point(353, 133);
            this.TransS2C.Name = "TransS2C";
            this.TransS2C.Size = new System.Drawing.Size(75, 54);
            this.TransS2C.TabIndex = 7;
            this.TransS2C.Text = "Transfer Savings to Checking";
            this.TransS2C.UseVisualStyleBackColor = true;
            this.TransS2C.Click += new System.EventHandler(this.TransS2C_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(403, 284);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // CustNumLabel
            // 
            this.CustNumLabel.AutoSize = true;
            this.CustNumLabel.Location = new System.Drawing.Point(17, 17);
            this.CustNumLabel.Name = "CustNumLabel";
            this.CustNumLabel.Size = new System.Drawing.Size(35, 13);
            this.CustNumLabel.TabIndex = 10;
            this.CustNumLabel.Text = "label2";
            this.CustNumLabel.Click += new System.EventHandler(this.CustNumLabel_Click);
            // 
            // customerDataDataSet
            // 
            this.customerDataDataSet.DataSetName = "CustomerDataDataSet";
            this.customerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDataDataSetBindingSource
            // 
            this.customerDataDataSetBindingSource.DataSource = this.customerDataDataSet;
            this.customerDataDataSetBindingSource.Position = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 332);
            this.Controls.Add(this.CustNumLabel);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransS2C);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ViewSav);
            this.Controls.Add(this.ViewCheck);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TransC2S);
            this.Controls.Add(this.WithSav);
            this.Controls.Add(this.WithCheck);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WithCheck;
        private System.Windows.Forms.Button WithSav;
        private System.Windows.Forms.Button TransC2S;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ViewCheck;
        private System.Windows.Forms.Button ViewSav;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Button TransS2C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label CustNumLabel;
        private System.Windows.Forms.BindingSource customerDataDataSetBindingSource;
        private CustomerDataDataSet customerDataDataSet;
    }
}