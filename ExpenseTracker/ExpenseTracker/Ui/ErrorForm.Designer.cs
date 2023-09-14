namespace ExpenseTracker
{
    partial class ErrorFrom
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            buttonErrorOk = new Button();
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // buttonErrorOk
            // 
            buttonErrorOk.Location = new Point(150, 90);
            buttonErrorOk.Name = "buttonErrorOk";
            buttonErrorOk.Size = new Size(94, 29);
            buttonErrorOk.TabIndex = 0;
            buttonErrorOk.Text = "Ok";
            buttonErrorOk.UseVisualStyleBackColor = true;
            buttonErrorOk.Click += buttonErrorOk_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(130, 30);
            labelError.Name = "labelError";
            labelError.Size = new Size(134, 20);
            labelError.TabIndex = 1;
            labelError.Text = "Error when login in";
            // 
            // ErrorFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 153);
            Controls.Add(labelError);
            Controls.Add(buttonErrorOk);
            Name = "ErrorFrom";
            Text = "Error";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label labelError;
        private Button buttonErrorOk;
    }
}