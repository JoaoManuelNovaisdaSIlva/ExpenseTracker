namespace ExpenseTracker.Ui
{
    partial class FormSpendings
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
            buttonLeft = new Button();
            buttonRight = new Button();
            labelMonth = new Label();
            label4 = new Label();
            labelIncome = new Label();
            labelExpense = new Label();
            label3 = new Label();
            label1 = new Label();
            labelBalance = new Label();
            buttonPlusIncome = new Button();
            buttonPlusExpense = new Button();
            buttonBack = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(100, 50);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(94, 29);
            buttonLeft.TabIndex = 0;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(600, 50);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(94, 29);
            buttonRight.TabIndex = 1;
            buttonRight.Text = ">";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Location = new Point(350, 50);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(50, 20);
            labelMonth.TabIndex = 2;
            labelMonth.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 150);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Income:";
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Location = new Point(539, 150);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(50, 20);
            labelIncome.TabIndex = 5;
            labelIncome.Text = "label1";
            // 
            // labelExpense
            // 
            labelExpense.AutoSize = true;
            labelExpense.Location = new Point(539, 190);
            labelExpense.Name = "labelExpense";
            labelExpense.Size = new Size(50, 20);
            labelExpense.TabIndex = 6;
            labelExpense.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 190);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Expense: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 420);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Balance:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Location = new Point(539, 420);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(50, 20);
            labelBalance.TabIndex = 9;
            labelBalance.Text = "label2";
            // 
            // buttonPlusIncome
            // 
            buttonPlusIncome.Location = new Point(495, 478);
            buttonPlusIncome.Name = "buttonPlusIncome";
            buttonPlusIncome.Size = new Size(94, 29);
            buttonPlusIncome.TabIndex = 10;
            buttonPlusIncome.Text = "Income +";
            buttonPlusIncome.UseVisualStyleBackColor = true;
            buttonPlusIncome.Click += buttonPlusIncome_Click;
            // 
            // buttonPlusExpense
            // 
            buttonPlusExpense.Location = new Point(600, 478);
            buttonPlusExpense.Name = "buttonPlusExpense";
            buttonPlusExpense.Size = new Size(94, 29);
            buttonPlusExpense.TabIndex = 11;
            buttonPlusExpense.Text = "Expense +";
            buttonPlusExpense.UseVisualStyleBackColor = true;
            buttonPlusExpense.Click += buttonPlusExpense_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(100, 478);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(594, 188);
            dataGridView1.TabIndex = 13;
            // 
            // FormSpendings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBack);
            Controls.Add(buttonPlusExpense);
            Controls.Add(buttonPlusIncome);
            Controls.Add(labelBalance);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(labelExpense);
            Controls.Add(labelIncome);
            Controls.Add(label4);
            Controls.Add(labelMonth);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Name = "FormSpendings";
            Text = "Spendings";
            Load += FormSpendings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLeft;
        private Button buttonRight;
        private Label labelMonth;
        private Label label4;
        private Label labelIncome;
        private Label labelExpense;
        private Label label3;
        private Label label1;
        private Label labelBalance;
        private Button buttonPlusIncome;
        private Button buttonPlusExpense;
        private Button buttonBack;
        private DataGridView dataGridView1;
    }
}