namespace ProjectUI
{
    partial class StartForm
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
            this.WordButton2 = new System.Windows.Forms.Button();
            this.WordButton1 = new System.Windows.Forms.Button();
            this.WordButton4 = new System.Windows.Forms.Button();
            this.WordButton3 = new System.Windows.Forms.Button();
            this.WordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordButton2
            // 
            this.WordButton2.Location = new System.Drawing.Point(153, 168);
            this.WordButton2.Name = "WordButton2";
            this.WordButton2.Size = new System.Drawing.Size(133, 103);
            this.WordButton2.TabIndex = 5;
            this.WordButton2.UseVisualStyleBackColor = true;
            this.WordButton2.Click += new System.EventHandler(this.WordButton2_Click);
            // 
            // WordButton1
            // 
            this.WordButton1.BackColor = System.Drawing.Color.Transparent;
            this.WordButton1.Location = new System.Drawing.Point(12, 168);
            this.WordButton1.Name = "WordButton1";
            this.WordButton1.Size = new System.Drawing.Size(135, 103);
            this.WordButton1.TabIndex = 4;
            this.WordButton1.UseVisualStyleBackColor = false;
            this.WordButton1.Click += new System.EventHandler(this.WordButton1_Click);
            // 
            // WordButton4
            // 
            this.WordButton4.Location = new System.Drawing.Point(153, 277);
            this.WordButton4.Name = "WordButton4";
            this.WordButton4.Size = new System.Drawing.Size(133, 89);
            this.WordButton4.TabIndex = 8;
            this.WordButton4.UseVisualStyleBackColor = true;
            this.WordButton4.Click += new System.EventHandler(this.WordButton4_Click);
            // 
            // WordButton3
            // 
            this.WordButton3.Location = new System.Drawing.Point(12, 277);
            this.WordButton3.Name = "WordButton3";
            this.WordButton3.Size = new System.Drawing.Size(135, 89);
            this.WordButton3.TabIndex = 7;
            this.WordButton3.UseVisualStyleBackColor = true;
            this.WordButton3.Click += new System.EventHandler(this.WordButton3_Click);
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.Location = new System.Drawing.Point(83, 64);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(118, 42);
            this.WordLabel.TabIndex = 9;
            this.WordLabel.Text = "label1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 378);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.WordButton4);
            this.Controls.Add(this.WordButton3);
            this.Controls.Add(this.WordButton2);
            this.Controls.Add(this.WordButton1);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WordButton2;
        private System.Windows.Forms.Button WordButton1;
        private System.Windows.Forms.Button WordButton4;
        private System.Windows.Forms.Button WordButton3;
        private System.Windows.Forms.Label WordLabel;
    }
}