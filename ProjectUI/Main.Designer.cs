namespace ProjectUI
{
    partial class Main
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
            this.StartButton = new System.Windows.Forms.Button();
            this.AddWordAndTranslateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(336, 103);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AddWordAndTranslateButton
            // 
            this.AddWordAndTranslateButton.Location = new System.Drawing.Point(12, 121);
            this.AddWordAndTranslateButton.Name = "AddWordAndTranslateButton";
            this.AddWordAndTranslateButton.Size = new System.Drawing.Size(336, 103);
            this.AddWordAndTranslateButton.TabIndex = 3;
            this.AddWordAndTranslateButton.Text = "Добавить слово и перевод";
            this.AddWordAndTranslateButton.UseVisualStyleBackColor = true;
            this.AddWordAndTranslateButton.Click += new System.EventHandler(this.AddWordAndTranslateButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 238);
            this.Controls.Add(this.AddWordAndTranslateButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AddWordAndTranslateButton;
    }
}