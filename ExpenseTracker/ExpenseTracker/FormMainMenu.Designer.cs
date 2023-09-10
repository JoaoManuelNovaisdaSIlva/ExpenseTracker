namespace ExpenseTracker
{
    partial class FormMainMenu
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
            buttonSpendings = new Button();
            buttonTransactions = new Button();
            buttonCategories = new Button();
            buttonSettings = new Button();
            buttonLogOut = new Button();
            labelMenu = new Label();
            labelWelcome = new Label();
            SuspendLayout();
            // 
            // buttonSpendings
            // 
            buttonSpendings.Location = new Point(350, 120);
            buttonSpendings.Name = "buttonSpendings";
            buttonSpendings.Size = new Size(94, 29);
            buttonSpendings.TabIndex = 0;
            buttonSpendings.Text = "Spendings";
            buttonSpendings.UseVisualStyleBackColor = true;
            // 
            // buttonTransactions
            // 
            buttonTransactions.Location = new Point(350, 200);
            buttonTransactions.Name = "buttonTransactions";
            buttonTransactions.Size = new Size(94, 29);
            buttonTransactions.TabIndex = 1;
            buttonTransactions.Text = "Transactions";
            buttonTransactions.UseVisualStyleBackColor = true;
            // 
            // buttonCategories
            // 
            buttonCategories.Location = new Point(350, 280);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Size = new Size(94, 29);
            buttonCategories.TabIndex = 2;
            buttonCategories.Text = "Categories";
            buttonCategories.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(350, 360);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.RightToLeft = RightToLeft.No;
            buttonSettings.Size = new Size(94, 29);
            buttonSettings.TabIndex = 3;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(51, 471);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(94, 29);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "LogOut";
            buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Location = new Point(355, 30);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(83, 20);
            labelMenu.TabIndex = 5;
            labelMenu.Text = "Main Menu";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(649, 30);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(50, 20);
            labelWelcome.TabIndex = 6;
            labelWelcome.Text = "label2";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(labelWelcome);
            Controls.Add(labelMenu);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonSettings);
            Controls.Add(buttonCategories);
            Controls.Add(buttonTransactions);
            Controls.Add(buttonSpendings);
            Name = "FormMainMenu";
            Text = "Expense Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSpendings;
        private Button buttonTransactions;
        private Button buttonCategories;
        private Button buttonSettings;
        private Button buttonLogOut;
        private Label labelMenu;
        private Label labelWelcome;
    }
}