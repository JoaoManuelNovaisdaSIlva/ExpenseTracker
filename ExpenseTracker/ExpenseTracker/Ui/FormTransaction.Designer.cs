namespace ExpenseTracker.Ui
{
    partial class FormTransaction
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
            dataGridView1 = new DataGridView();
            buttonIncome = new Button();
            buttonExpenses = new Button();
            buttonBack = new Button();
            labelMonth = new Label();
            buttonLeft = new Button();
            buttonRight = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(675, 340);
            dataGridView1.TabIndex = 0;
            // 
            // buttonIncome
            // 
            buttonIncome.Location = new Point(499, 494);
            buttonIncome.Name = "buttonIncome";
            buttonIncome.Size = new Size(94, 29);
            buttonIncome.TabIndex = 1;
            buttonIncome.Text = "Income +";
            buttonIncome.UseVisualStyleBackColor = true;
            // 
            // buttonExpenses
            // 
            buttonExpenses.Location = new Point(635, 494);
            buttonExpenses.Name = "buttonExpenses";
            buttonExpenses.Size = new Size(94, 29);
            buttonExpenses.TabIndex = 2;
            buttonExpenses.Text = "Expenses +";
            buttonExpenses.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.ImageAlign = ContentAlignment.TopCenter;
            buttonBack.Location = new Point(54, 484);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Location = new Point(372, 38);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(50, 20);
            labelMonth.TabIndex = 4;
            labelMonth.Text = "label1";
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(54, 38);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(94, 29);
            buttonLeft.TabIndex = 5;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(635, 38);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(94, 29);
            buttonRight.TabIndex = 6;
            buttonRight.Text = ">";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // FormTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(labelMonth);
            Controls.Add(buttonBack);
            Controls.Add(buttonExpenses);
            Controls.Add(buttonIncome);
            Controls.Add(dataGridView1);
            Name = "FormTransaction";
            Text = "Transaction";
            Load += FormTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonIncome;
        private Button buttonExpenses;
        private Button buttonBack;
        private Label labelMonth;
        private Button buttonLeft;
        private Button buttonRight;
    }
}