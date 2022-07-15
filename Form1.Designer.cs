
namespace Bank_Account_Manager
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
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.accountBalanceBox = new System.Windows.Forms.TextBox();
            this.accountHistoryBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transactionStatusBox = new System.Windows.Forms.TextBox();
            this.transactionStatusLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.transactionAmountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.withdrawalButton = new System.Windows.Forms.RadioButton();
            this.depositButton = new System.Windows.Forms.RadioButton();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.getStatusButton = new System.Windows.Forms.Button();
            this.getHistoryButton = new System.Windows.Forms.Button();
            this.accountHistoryButton = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.Location = new System.Drawing.Point(143, 26);
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.ReadOnly = true;
            this.accountNumberBox.Size = new System.Drawing.Size(185, 23);
            this.accountNumberBox.TabIndex = 0;
            // 
            // accountBalanceBox
            // 
            this.accountBalanceBox.Location = new System.Drawing.Point(476, 26);
            this.accountBalanceBox.Name = "accountBalanceBox";
            this.accountBalanceBox.ReadOnly = true;
            this.accountBalanceBox.Size = new System.Drawing.Size(183, 23);
            this.accountBalanceBox.TabIndex = 1;
            // 
            // accountHistoryBox
            // 
            this.accountHistoryBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accountHistoryBox.FormattingEnabled = true;
            this.accountHistoryBox.ItemHeight = 15;
            this.accountHistoryBox.Location = new System.Drawing.Point(675, 65);
            this.accountHistoryBox.Name = "accountHistoryBox";
            this.accountHistoryBox.Size = new System.Drawing.Size(264, 244);
            this.accountHistoryBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.transactionStatusBox);
            this.panel1.Controls.Add(this.transactionStatusLabel);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.transactionAmountBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.withdrawalButton);
            this.panel1.Controls.Add(this.depositButton);
            this.panel1.Location = new System.Drawing.Point(35, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 244);
            this.panel1.TabIndex = 3;
            // 
            // transactionStatusBox
            // 
            this.transactionStatusBox.Location = new System.Drawing.Point(155, 197);
            this.transactionStatusBox.Name = "transactionStatusBox";
            this.transactionStatusBox.ReadOnly = true;
            this.transactionStatusBox.Size = new System.Drawing.Size(452, 23);
            this.transactionStatusBox.TabIndex = 6;
            // 
            // transactionStatusLabel
            // 
            this.transactionStatusLabel.AutoSize = true;
            this.transactionStatusLabel.Location = new System.Drawing.Point(23, 200);
            this.transactionStatusLabel.Name = "transactionStatusLabel";
            this.transactionStatusLabel.Size = new System.Drawing.Size(105, 15);
            this.transactionStatusLabel.TabIndex = 5;
            this.transactionStatusLabel.Text = "Transaction Status:";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.submitButton.Location = new System.Drawing.Point(31, 147);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // transactionAmountBox
            // 
            this.transactionAmountBox.Location = new System.Drawing.Point(155, 111);
            this.transactionAmountBox.Name = "transactionAmountBox";
            this.transactionAmountBox.Size = new System.Drawing.Size(154, 23);
            this.transactionAmountBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaction Amount:";
            // 
            // withdrawalButton
            // 
            this.withdrawalButton.AutoSize = true;
            this.withdrawalButton.Location = new System.Drawing.Point(31, 71);
            this.withdrawalButton.Name = "withdrawalButton";
            this.withdrawalButton.Size = new System.Drawing.Size(85, 19);
            this.withdrawalButton.TabIndex = 1;
            this.withdrawalButton.Text = "Withdrawal";
            this.withdrawalButton.UseVisualStyleBackColor = true;
            // 
            // depositButton
            // 
            this.depositButton.AutoSize = true;
            this.depositButton.Checked = true;
            this.depositButton.Location = new System.Drawing.Point(31, 45);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(65, 19);
            this.depositButton.TabIndex = 0;
            this.depositButton.TabStop = true;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(35, 29);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(102, 15);
            this.accountNumberLabel.TabIndex = 4;
            this.accountNumberLabel.Text = "Account Number:";
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.AutoSize = true;
            this.accountBalanceLabel.Location = new System.Drawing.Point(371, 34);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(99, 15);
            this.accountBalanceLabel.TabIndex = 5;
            this.accountBalanceLabel.Text = "Account Balance:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.getStatusButton);
            this.panel2.Controls.Add(this.getHistoryButton);
            this.panel2.Location = new System.Drawing.Point(14, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 51);
            this.panel2.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(816, 14);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // getStatusButton
            // 
            this.getStatusButton.Location = new System.Drawing.Point(118, 14);
            this.getStatusButton.Name = "getStatusButton";
            this.getStatusButton.Size = new System.Drawing.Size(75, 23);
            this.getStatusButton.TabIndex = 1;
            this.getStatusButton.Text = "Get Status";
            this.getStatusButton.UseVisualStyleBackColor = true;
            this.getStatusButton.Click += new System.EventHandler(this.getStatusButton_Click);
            // 
            // getHistoryButton
            // 
            this.getHistoryButton.Location = new System.Drawing.Point(21, 14);
            this.getHistoryButton.Name = "getHistoryButton";
            this.getHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.getHistoryButton.TabIndex = 0;
            this.getHistoryButton.Text = "Get History";
            this.getHistoryButton.UseVisualStyleBackColor = true;
            this.getHistoryButton.Click += new System.EventHandler(this.getHistoryButton_Click);
            // 
            // accountHistoryButton
            // 
            this.accountHistoryButton.AutoSize = true;
            this.accountHistoryButton.Location = new System.Drawing.Point(684, 41);
            this.accountHistoryButton.Name = "accountHistoryButton";
            this.accountHistoryButton.Size = new System.Drawing.Size(96, 15);
            this.accountHistoryButton.TabIndex = 7;
            this.accountHistoryButton.Text = "Account History:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 392);
            this.Controls.Add(this.accountHistoryButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.accountBalanceLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accountHistoryBox);
            this.Controls.Add(this.accountBalanceBox);
            this.Controls.Add(this.accountNumberBox);
            this.Name = "Form1";
            this.Text = "Bank Account Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.TextBox accountBalanceBox;
        private System.Windows.Forms.ListBox accountHistoryBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox transactionAmountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton withdrawalButton;
        private System.Windows.Forms.RadioButton depositButton;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.TextBox transactionStatusBox;
        private System.Windows.Forms.Label transactionStatusLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button getStatusButton;
        private System.Windows.Forms.Button getHistoryButton;
        private System.Windows.Forms.Label accountHistoryButton;
    }
}

