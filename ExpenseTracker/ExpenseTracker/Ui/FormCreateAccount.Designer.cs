namespace ExpenseTracker.Ui
{
    partial class FormCreateAccount
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxPw = new TextBox();
            buttonBack = new Button();
            buttonCreate = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 100);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 190);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 280);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(419, 97);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(419, 190);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxPw
            // 
            textBoxPw.Location = new Point(419, 273);
            textBoxPw.Name = "textBoxPw";
            textBoxPw.Size = new Size(125, 27);
            textBoxPw.TabIndex = 5;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(160, 370);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(419, 370);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 7;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(268, 330);
            labelError.Name = "labelError";
            labelError.Size = new Size(179, 20);
            labelError.TabIndex = 8;
            labelError.Text = "Not enough data inserted";
            // 
            // FormCreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelError);
            Controls.Add(buttonCreate);
            Controls.Add(buttonBack);
            Controls.Add(textBoxPw);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCreateAccount";
            Text = "Create Account";
            Load += FormCreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxPw;
        private Button buttonBack;
        private Button buttonCreate;
        private Label labelError;
    }
}