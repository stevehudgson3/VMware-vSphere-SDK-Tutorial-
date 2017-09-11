namespace DotNet_SDK_Tutorial
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
            this.lbVM = new System.Windows.Forms.ListBox();
            this.lbHost = new System.Windows.Forms.ListBox();
            this.lbCluster = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVCS = new System.Windows.Forms.TextBox();
            this.tbUN = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVM
            // 
            this.lbVM.FormattingEnabled = true;
            this.lbVM.Location = new System.Drawing.Point(40, 35);
            this.lbVM.Name = "lbVM";
            this.lbVM.Size = new System.Drawing.Size(217, 290);
            this.lbVM.TabIndex = 0;
            // 
            // lbHost
            // 
            this.lbHost.FormattingEnabled = true;
            this.lbHost.Location = new System.Drawing.Point(292, 35);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(217, 290);
            this.lbHost.TabIndex = 1;
            // 
            // lbCluster
            // 
            this.lbCluster.FormattingEnabled = true;
            this.lbCluster.Location = new System.Drawing.Point(548, 35);
            this.lbCluster.Name = "lbCluster";
            this.lbCluster.Size = new System.Drawing.Size(217, 290);
            this.lbCluster.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VMs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hosts";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clusters";
            // 
            // tbVCS
            // 
            this.tbVCS.Location = new System.Drawing.Point(119, 348);
            this.tbVCS.Name = "tbVCS";
            this.tbVCS.Size = new System.Drawing.Size(261, 20);
            this.tbVCS.TabIndex = 6;
            this.tbVCS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbUN
            // 
            this.tbUN.Location = new System.Drawing.Point(119, 390);
            this.tbUN.Name = "tbUN";
            this.tbUN.Size = new System.Drawing.Size(261, 20);
            this.tbUN.TabIndex = 7;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(119, 425);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(261, 20);
            this.tbPW.TabIndex = 8;
            this.tbPW.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "vCenter Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(434, 393);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 457);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbUN);
            this.Controls.Add(this.tbVCS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCluster);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.lbVM);
            this.Name = "Form1";
            this.Text = "vCenter Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVM;
        private System.Windows.Forms.ListBox lbHost;
        private System.Windows.Forms.ListBox lbCluster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVCS;
        private System.Windows.Forms.TextBox tbUN;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConnect;
    }
}

