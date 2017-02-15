namespace HsbcDatabase
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.radioButtonCurrentA = new System.Windows.Forms.RadioButton();
            this.radioButtonSavingA = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.buttonCreateAcc = new System.Windows.Forms.Button();
            this.groupBoxAccountType = new System.Windows.Forms.GroupBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.groupBoxAccountType.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(52, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(52, 79);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(136, 73);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 1;
            // 
            // radioButtonCurrentA
            // 
            this.radioButtonCurrentA.AutoSize = true;
            this.radioButtonCurrentA.Checked = true;
            this.radioButtonCurrentA.Location = new System.Drawing.Point(6, 30);
            this.radioButtonCurrentA.Name = "radioButtonCurrentA";
            this.radioButtonCurrentA.Size = new System.Drawing.Size(76, 21);
            this.radioButtonCurrentA.TabIndex = 2;
            this.radioButtonCurrentA.TabStop = true;
            this.radioButtonCurrentA.Text = "Current";
            this.radioButtonCurrentA.UseVisualStyleBackColor = true;
            // 
            // radioButtonSavingA
            // 
            this.radioButtonSavingA.AutoSize = true;
            this.radioButtonSavingA.Location = new System.Drawing.Point(114, 30);
            this.radioButtonSavingA.Name = "radioButtonSavingA";
            this.radioButtonSavingA.Size = new System.Drawing.Size(79, 21);
            this.radioButtonSavingA.TabIndex = 2;
            this.radioButtonSavingA.Text = "Savings";
            this.radioButtonSavingA.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 35);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(114, 35);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAcc
            // 
            this.buttonCreateAcc.Location = new System.Drawing.Point(249, 311);
            this.buttonCreateAcc.Name = "buttonCreateAcc";
            this.buttonCreateAcc.Size = new System.Drawing.Size(139, 41);
            this.buttonCreateAcc.TabIndex = 3;
            this.buttonCreateAcc.Text = "Create Account";
            this.buttonCreateAcc.UseVisualStyleBackColor = true;
            this.buttonCreateAcc.Click += new System.EventHandler(this.buttonCreateAcc_Click);
            // 
            // groupBoxAccountType
            // 
            this.groupBoxAccountType.Controls.Add(this.radioButtonCurrentA);
            this.groupBoxAccountType.Controls.Add(this.radioButtonSavingA);
            this.groupBoxAccountType.Location = new System.Drawing.Point(55, 123);
            this.groupBoxAccountType.Name = "groupBoxAccountType";
            this.groupBoxAccountType.Size = new System.Drawing.Size(251, 72);
            this.groupBoxAccountType.TabIndex = 4;
            this.groupBoxAccountType.TabStop = false;
            this.groupBoxAccountType.Text = "Account type?";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(55, 215);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(251, 72);
            this.groupBoxGender.TabIndex = 5;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 364);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.groupBoxAccountType);
            this.Controls.Add(this.buttonCreateAcc);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAccountType.ResumeLayout(false);
            this.groupBoxAccountType.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.RadioButton radioButtonCurrentA;
        private System.Windows.Forms.RadioButton radioButtonSavingA;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Button buttonCreateAcc;
        private System.Windows.Forms.GroupBox groupBoxAccountType;
        private System.Windows.Forms.GroupBox groupBoxGender;
    }
}

