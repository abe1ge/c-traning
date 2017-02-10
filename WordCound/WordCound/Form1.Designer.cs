namespace WordCound
{
    partial class Form1
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
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.labelWords = new System.Windows.Forms.Label();
            this.textBoxCWords = new System.Windows.Forms.TextBox();
            this.labelConvert = new System.Windows.Forms.Label();
            this.textBoxConverted = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxWords
            // 
            this.textBoxWords.Location = new System.Drawing.Point(65, 39);
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.Size = new System.Drawing.Size(325, 20);
            this.textBoxWords.TabIndex = 0;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(9, 40);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(56, 13);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Message :";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(409, 35);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(75, 23);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // labelWords
            // 
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(21, 77);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(44, 13);
            this.labelWords.TabIndex = 3;
            this.labelWords.Text = "Words :";
            // 
            // textBoxCWords
            // 
            this.textBoxCWords.Enabled = false;
            this.textBoxCWords.Location = new System.Drawing.Point(65, 70);
            this.textBoxCWords.Name = "textBoxCWords";
            this.textBoxCWords.Size = new System.Drawing.Size(100, 20);
            this.textBoxCWords.TabIndex = 4;
            // 
            // labelConvert
            // 
            this.labelConvert.AutoSize = true;
            this.labelConvert.Location = new System.Drawing.Point(3, 103);
            this.labelConvert.Name = "labelConvert";
            this.labelConvert.Size = new System.Drawing.Size(62, 13);
            this.labelConvert.TabIndex = 3;
            this.labelConvert.Text = "Converted :";
            // 
            // textBoxConverted
            // 
            this.textBoxConverted.Enabled = false;
            this.textBoxConverted.Location = new System.Drawing.Point(65, 100);
            this.textBoxConverted.Name = "textBoxConverted";
            this.textBoxConverted.Size = new System.Drawing.Size(325, 20);
            this.textBoxConverted.TabIndex = 0;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(409, 97);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 186);
            this.Controls.Add(this.textBoxCWords);
            this.Controls.Add(this.labelConvert);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxConverted);
            this.Controls.Add(this.textBoxWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWords;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.TextBox textBoxCWords;
        private System.Windows.Forms.Label labelConvert;
        private System.Windows.Forms.TextBox textBoxConverted;
        private System.Windows.Forms.Button buttonConvert;
    }
}

