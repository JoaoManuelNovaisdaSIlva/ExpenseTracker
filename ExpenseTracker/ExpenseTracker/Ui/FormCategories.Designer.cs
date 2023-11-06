namespace ExpenseTracker.Ui
{
    partial class FormCategories
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
            buttonAddCategory = new Button();
            buttonBack = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(624, 470);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(104, 29);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = "Category +/-";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(47, 470);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(83, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(612, 344);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 38);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 4;
            label1.Text = "Current Categories";
            // 
            // FormCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(buttonBack);
            Controls.Add(buttonAddCategory);
            Name = "FormCategories";
            Text = "Categories";
            Load += FormCategories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAddCategory;
        private Button buttonBack;
        private ListBox listBox1;
        private Label label1;
    }
}