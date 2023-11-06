namespace ExpenseTracker.Ui
{
    partial class FormNewCategory
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
            textBox1 = new TextBox();
            buttonAdd = new Button();
            buttonBack = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 353);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(420, 439);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(113, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add Category";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(237, 439);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(111, 29);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(79, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(615, 224);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 31);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 4;
            label1.Text = "Existing Categories";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(79, 298);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(202, 29);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Remove Selected Category";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // FormNewCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(buttonRemove);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(buttonBack);
            Controls.Add(buttonAdd);
            Controls.Add(textBox1);
            Name = "FormNewCategory";
            Text = "Add Category";
            Load += FormNewCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonAdd;
        private Button buttonBack;
        private ListBox listBox1;
        private Label label1;
        private Button buttonRemove;
    }
}