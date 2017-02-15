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
            this.labelAccountCreated = new System.Windows.Forms.Label();
            this.groupBoxAccountType.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 32);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 28);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(76, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(39, 64);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(102, 59);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(76, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // radioButtonCurrentA
            // 
            this.radioButtonCurrentA.AutoSize = true;
            this.radioButtonCurrentA.Checked = true;
            this.radioButtonCurrentA.Location = new System.Drawing.Point(4, 24);
            this.radioButtonCurrentA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonCurrentA.Name = "radioButtonCurrentA";
            this.radioButtonCurrentA.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCurrentA.TabIndex = 2;
            this.radioButtonCurrentA.TabStop = true;
            this.radioButtonCurrentA.Text = "Current";
            this.radioButtonCurrentA.UseVisualStyleBackColor = true;
            // 
            // radioButtonSavingA
            // 
            this.radioButtonSavingA.AutoSize = true;
            this.radioButtonSavingA.Location = new System.Drawing.Point(86, 24);
            this.radioButtonSavingA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSavingA.Name = "radioButtonSavingA";
            this.radioButtonSavingA.Size = new System.Drawing.Size(63, 17);
            this.radioButtonSavingA.TabIndex = 2;
            this.radioButtonSavingA.Text = "Savings";
            this.radioButtonSavingA.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(4, 28);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(86, 28);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAcc
            // 
            this.buttonCreateAcc.Location = new System.Drawing.Point(187, 253);
            this.buttonCreateAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateAcc.Name = "buttonCreateAcc";
            this.buttonCreateAcc.Size = new System.Drawing.Size(104, 33);
            this.buttonCreateAcc.TabIndex = 3;
            this.buttonCreateAcc.Text = "Create Account";
            this.buttonCreateAcc.UseVisualStyleBackColor = true;
            this.buttonCreateAcc.Click += new System.EventHandler(this.buttonCreateAcc_Click);
            // 
            // groupBoxAccountType
            // 
            this.groupBoxAccountType.Controls.Add(this.radioButtonCurrentA);
            this.groupBoxAccountType.Controls.Add(this.radioButtonSavingA);
            this.groupBoxAccountType.Location = new System.Drawing.Point(41, 100);
            this.groupBoxAccountType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAccountType.Name = "groupBoxAccountType";
            this.groupBoxAccountType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAccountType.Size = new System.Drawing.Size(188, 58);
            this.groupBoxAccountType.TabIndex = 4;
            this.groupBoxAccountType.TabStop = false;
            this.groupBoxAccountType.Text = "Account type?";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(41, 175);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGender.Size = new System.Drawing.Size(188, 58);
            this.groupBoxGender.TabIndex = 5;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender?";
            // 
            // labelAccountCreated
            // 
            this.labelAccountCreated.AutoSize = true;
            this.labelAccountCreated.Location = new System.Drawing.Point(39, 263);
            this.labelAccountCreated.Name = "labelAccountCreated";
            this.labelAccountCreated.Size = new System.Drawing.Size(0, 13);
            this.labelAccountCreated.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 296);
            this.Controls.Add(this.labelAccountCreated);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.groupBoxAccountType);
            this.Controls.Add(this.buttonCreateAcc);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label labelAccountCreated;
    }
}

