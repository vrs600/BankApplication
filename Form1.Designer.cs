namespace BankApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtAccName = new TextBox();
            txtAccNo = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBxBalance = new TextBox();
            groupBox2 = new GroupBox();
            btnExit = new Button();
            btnCheck = new Button();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnOpen = new Button();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtAccName
            // 
            txtAccName.Location = new Point(121, 51);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(158, 23);
            txtAccName.TabIndex = 0;
            txtAccName.TextChanged += textBox1_TextChanged;
            // 
            // txtAccNo
            // 
            txtAccNo.Location = new Point(121, 22);
            txtAccNo.Name = "txtAccNo";
            txtAccNo.Size = new Size(158, 23);
            txtAccNo.TabIndex = 1;
            txtAccNo.TextChanged += txtAccNo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(309, 18);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 2;
            label1.Text = "APNA BANK";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBxBalance);
            groupBox1.Controls.Add(txtAccNo);
            groupBox1.Controls.Add(txtAccName);
            groupBox1.Location = new Point(228, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 127);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 88);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 6;
            label4.Text = "Enter Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 59);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Enter Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 30);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "Account No";
            // 
            // txtBxBalance
            // 
            txtBxBalance.Location = new Point(121, 80);
            txtBxBalance.Name = "txtBxBalance";
            txtBxBalance.Size = new Size(158, 23);
            txtBxBalance.TabIndex = 2;
            txtBxBalance.TextChanged += txtBxBalance_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnCheck);
            groupBox2.Controls.Add(btnWithdraw);
            groupBox2.Controls.Add(btnDeposit);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Location = new Point(170, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 75);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(333, 33);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(249, 33);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(168, 33);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(75, 23);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(87, 33);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(75, 23);
            btnDeposit.TabIndex = 1;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(6, 33);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 298);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(414, 140);
            textBox4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccName;
        private TextBox txtAccNo;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtBxBalance;
        private GroupBox groupBox2;
        private Button btnExit;
        private Button btnCheck;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnOpen;
        private TextBox textBox4;
    }
}
