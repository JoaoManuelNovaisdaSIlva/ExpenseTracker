namespace ExpenseTracker.Ui
{
    partial class FormNewExpense
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
            comboBoxCategories = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAmount = new TextBox();
            textBoxDate = new TextBox();
            label4 = new Label();
            buttonAdd = new Button();
            buttonCancel = new Button();
            label5 = new Label();
            textBoxDescription = new TextBox();
            SuspendLayout();
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(475, 53);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(151, 28);
            comboBoxCategories.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 56);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Category: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 155);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 250);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(475, 152);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(151, 27);
            textBoxAmount.TabIndex = 4;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(475, 243);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(151, 27);
            textBoxDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 273);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "dd/mm/yy";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(532, 461);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(91, 461);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Back";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 344);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "Decription";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(475, 344);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(151, 27);
            textBoxDescription.TabIndex = 10;
            // 
            // FormNewExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(textBoxDescription);
            Controls.Add(label5);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(label4);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCategories);
            Name = "FormNewExpense";
            Text = "Add Expense";
            Load += FormNewExpense_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategories;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAmount;
        private TextBox textBoxDate;
        private Label label4;
        private Button buttonAdd;
        private Button buttonCancel;
        private Label label5;
        private TextBox textBoxDescription;
    }
}