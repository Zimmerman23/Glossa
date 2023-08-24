namespace ProjectUI
{
    partial class AddWordForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WordLabel = new System.Windows.Forms.Label();
            this.TranslateLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Location = new System.Drawing.Point(12, 9);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(90, 13);
            this.WordLabel.TabIndex = 1;
            this.WordLabel.Text = "Добавить слово";
            // 
            // TranslateLabel
            // 
            this.TranslateLabel.AutoSize = true;
            this.TranslateLabel.Location = new System.Drawing.Point(12, 35);
            this.TranslateLabel.Name = "TranslateLabel";
            this.TranslateLabel.Size = new System.Drawing.Size(102, 13);
            this.TranslateLabel.TabIndex = 3;
            this.TranslateLabel.Text = "Добавить перевод";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 70);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 23);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Сбросить";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(130, 70);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TranslateLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "AddWordForm";
            this.Text = "be";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label TranslateLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
    }
}