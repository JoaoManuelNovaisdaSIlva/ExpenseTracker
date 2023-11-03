namespace ExpenseTracker.Ui
{
    partial class FormNewIncome
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
            textBoxIncome = new TextBox();
            label1 = new Label();
            buttonAdd = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxIncome
            // 
            textBoxIncome.Location = new Point(409, 198);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new Size(125, 27);
            textBoxIncome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 205);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "New Income: ";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(440, 331);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(201, 331);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Back";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormNewIncome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(textBoxIncome);
            Name = "FormNewIncome";
            Text = "Add Income";
            Load += FormNewIncome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIncome;
        private Label label1;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}