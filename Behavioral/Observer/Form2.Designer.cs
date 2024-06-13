namespace Observer
{
    partial class Form2
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
            buttonSubcribe = new Button();
            buttonUnsubscribe = new Button();
            SuspendLayout();
            // 
            // buttonSubcribe
            // 
            buttonSubcribe.Location = new Point(278, 142);
            buttonSubcribe.Name = "buttonSubcribe";
            buttonSubcribe.Size = new Size(226, 34);
            buttonSubcribe.TabIndex = 0;
            buttonSubcribe.Text = "Abone Ol";
            buttonSubcribe.UseVisualStyleBackColor = true;
            buttonSubcribe.Click += buttonSubcribe_Click;
            // 
            // buttonUnsubscribe
            // 
            buttonUnsubscribe.Location = new Point(278, 182);
            buttonUnsubscribe.Name = "buttonUnsubscribe";
            buttonUnsubscribe.Size = new Size(226, 34);
            buttonUnsubscribe.TabIndex = 1;
            buttonUnsubscribe.Text = "Abonelikten Çık";
            buttonUnsubscribe.UseVisualStyleBackColor = true;
            buttonUnsubscribe.Click += buttonUnsubscribe_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUnsubscribe);
            Controls.Add(buttonSubcribe);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSubcribe;
        private Button buttonUnsubscribe;
    }
}