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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.panelCreatAccount = new System.Windows.Forms.Panel();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.payInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.buttonDepositMoney = new System.Windows.Forms.Button();
            this.buttonWithdawMoney = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelWithdraw = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxWAccountInfo = new System.Windows.Forms.GroupBox();
            this.labelWBalance = new System.Windows.Forms.Label();
            this.labelWAddress = new System.Windows.Forms.Label();
            this.labelWName = new System.Windows.Forms.Label();
            this.textBoxWBalance = new System.Windows.Forms.TextBox();
            this.textBoxWaddress = new System.Windows.Forms.TextBox();
            this.textBoxWName = new System.Windows.Forms.TextBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonWSearch = new System.Windows.Forms.Button();
            this.textBoxWAccountNo = new System.Windows.Forms.TextBox();
            this.textBoxWithdraw = new System.Windows.Forms.TextBox();
            this.labelWAccountNo = new System.Windows.Forms.Label();
            this.labelWithdraw = new System.Windows.Forms.Label();
            this.panelDeposit = new System.Windows.Forms.Panel();
            this.labelDepsoitAmount = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.groupBoxDepositInfo = new System.Windows.Forms.GroupBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelDAddress = new System.Windows.Forms.Label();
            this.labelDName = new System.Windows.Forms.Label();
            this.textBoxDBalance = new System.Windows.Forms.TextBox();
            this.textBoxDAddress = new System.Windows.Forms.TextBox();
            this.textBoxDName = new System.Windows.Forms.TextBox();
            this.buttonDepsit = new System.Windows.Forms.Button();
            this.labelDAccountNo = new System.Windows.Forms.Label();
            this.buttonDSearchAcc = new System.Windows.Forms.Button();
            this.textBoxDepsoitAmout = new System.Windows.Forms.TextBox();
            this.textBoxDAccountNo = new System.Windows.Forms.TextBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hsbcDbDataSet = new HsbcDatabase.HsbcDbDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.accountsTableAdapter = new HsbcDatabase.HsbcDbDataSetTableAdapters.AccountsTableAdapter();
            this.groupBoxAccountType.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.panelCreatAccount.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.panelWithdraw.SuspendLayout();
            this.groupBoxWAccountInfo.SuspendLayout();
            this.panelDeposit.SuspendLayout();
            this.groupBoxDepositInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsbcDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 46);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(59, 91);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(143, 85);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 1;
            // 
            // radioButtonCurrentA
            // 
            this.radioButtonCurrentA.AutoSize = true;
            this.radioButtonCurrentA.Checked = true;
            this.radioButtonCurrentA.Location = new System.Drawing.Point(5, 30);
            this.radioButtonCurrentA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.radioButtonSavingA.Location = new System.Drawing.Point(115, 30);
            this.radioButtonSavingA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.radioButtonMale.Location = new System.Drawing.Point(5, 34);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.radioButtonFemale.Location = new System.Drawing.Point(115, 34);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAcc
            // 
            this.buttonCreateAcc.Location = new System.Drawing.Point(174, 324);
            this.buttonCreateAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.groupBoxAccountType.Location = new System.Drawing.Point(62, 135);
            this.groupBoxAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAccountType.Name = "groupBoxAccountType";
            this.groupBoxAccountType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAccountType.Size = new System.Drawing.Size(251, 71);
            this.groupBoxAccountType.TabIndex = 4;
            this.groupBoxAccountType.TabStop = false;
            this.groupBoxAccountType.Text = "Account type?";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(62, 227);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxGender.Size = new System.Drawing.Size(251, 71);
            this.groupBoxGender.TabIndex = 5;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender?";
            // 
            // labelAccountCreated
            // 
            this.labelAccountCreated.AutoSize = true;
            this.labelAccountCreated.Location = new System.Drawing.Point(59, 376);
            this.labelAccountCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountCreated.Name = "labelAccountCreated";
            this.labelAccountCreated.Size = new System.Drawing.Size(0, 17);
            this.labelAccountCreated.TabIndex = 6;
            // 
            // panelCreatAccount
            // 
            this.panelCreatAccount.Controls.Add(this.buttonCreateAcc);
            this.panelCreatAccount.Controls.Add(this.labelAccountCreated);
            this.panelCreatAccount.Controls.Add(this.labelName);
            this.panelCreatAccount.Controls.Add(this.labelCreateAccount);
            this.panelCreatAccount.Controls.Add(this.groupBoxGender);
            this.panelCreatAccount.Controls.Add(this.labelAddress);
            this.panelCreatAccount.Controls.Add(this.groupBoxAccountType);
            this.panelCreatAccount.Controls.Add(this.textBoxName);
            this.panelCreatAccount.Controls.Add(this.textBoxAddress);
            this.panelCreatAccount.Location = new System.Drawing.Point(410, 3);
            this.panelCreatAccount.Name = "panelCreatAccount";
            this.panelCreatAccount.Size = new System.Drawing.Size(401, 445);
            this.panelCreatAccount.TabIndex = 8;
            this.panelCreatAccount.Visible = false;
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Location = new System.Drawing.Point(129, 14);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(126, 17);
            this.labelCreateAccount.TabIndex = 0;
            this.labelCreateAccount.Text = "Create An Account";
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.withdrawToolStripMenuItem1,
            this.payInToolStripMenuItem,
            this.welcomeToolStripMenuItem});
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.withdrawToolStripMenuItem.Text = "account";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.addAccountToolStripMenuItem.Text = "Create an account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.changePannelButton_Click);
            // 
            // withdrawToolStripMenuItem1
            // 
            this.withdrawToolStripMenuItem1.Name = "withdrawToolStripMenuItem1";
            this.withdrawToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.withdrawToolStripMenuItem1.Text = "Withdraw";
            this.withdrawToolStripMenuItem1.Click += new System.EventHandler(this.changePannelButton_Click);
            // 
            // payInToolStripMenuItem
            // 
            this.payInToolStripMenuItem.Name = "payInToolStripMenuItem";
            this.payInToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.payInToolStripMenuItem.Text = "Deposit";
            this.payInToolStripMenuItem.Click += new System.EventHandler(this.changePannelButton_Click);
            // 
            // welcomeToolStripMenuItem
            // 
            this.welcomeToolStripMenuItem.Name = "welcomeToolStripMenuItem";
            this.welcomeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.welcomeToolStripMenuItem.Text = "Welcome";
            this.welcomeToolStripMenuItem.Click += new System.EventHandler(this.changePannelButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1660, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.panelWelcome);
            this.flowLayoutPanel2.Controls.Add(this.panelCreatAccount);
            this.flowLayoutPanel2.Controls.Add(this.panelWithdraw);
            this.flowLayoutPanel2.Controls.Add(this.panelDeposit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1628, 451);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.buttonDepositMoney);
            this.panelWelcome.Controls.Add(this.buttonWithdawMoney);
            this.panelWelcome.Controls.Add(this.buttonCreateAccount);
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(3, 3);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(401, 445);
            this.panelWelcome.TabIndex = 8;
            // 
            // buttonDepositMoney
            // 
            this.buttonDepositMoney.Location = new System.Drawing.Point(98, 305);
            this.buttonDepositMoney.Name = "buttonDepositMoney";
            this.buttonDepositMoney.Size = new System.Drawing.Size(191, 41);
            this.buttonDepositMoney.TabIndex = 1;
            this.buttonDepositMoney.Text = "Deposit";
            this.buttonDepositMoney.UseVisualStyleBackColor = true;
            this.buttonDepositMoney.Click += new System.EventHandler(this.changePannelButton_Click);
            // 
            // buttonWithdawMoney
            // 
            this.buttonWithdawMoney.Location = new System.Drawing.Point(98, 234);
            this.buttonWithdawMoney.Name = "buttonWithdawMoney";
            this.buttonWithdawMoney.Size = new System.Drawing.Size(191, 41);
            this.buttonWithdawMoney.TabIndex = 1;
            this.buttonWithdawMoney.Text = "Withdraw";
            this.buttonWithdawMoney.UseVisualStyleBackColor = true;
            this.buttonWithdawMoney.Click += new System.EventHandler(this.changePannelButton_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(98, 158);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(191, 41);
            this.buttonCreateAccount.TabIndex = 1;
            this.buttonCreateAccount.Text = "Create an account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.changePannelButton_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(126, 14);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(128, 17);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome To HSBC";
            // 
            // panelWithdraw
            // 
            this.panelWithdraw.Controls.Add(this.label1);
            this.panelWithdraw.Controls.Add(this.groupBoxWAccountInfo);
            this.panelWithdraw.Controls.Add(this.buttonWithdraw);
            this.panelWithdraw.Controls.Add(this.buttonWSearch);
            this.panelWithdraw.Controls.Add(this.textBoxWAccountNo);
            this.panelWithdraw.Controls.Add(this.textBoxWithdraw);
            this.panelWithdraw.Controls.Add(this.labelWAccountNo);
            this.panelWithdraw.Controls.Add(this.labelWithdraw);
            this.panelWithdraw.Location = new System.Drawing.Point(817, 3);
            this.panelWithdraw.Name = "panelWithdraw";
            this.panelWithdraw.Size = new System.Drawing.Size(401, 445);
            this.panelWithdraw.TabIndex = 8;
            this.panelWithdraw.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Withdraw Amount";
            // 
            // groupBoxWAccountInfo
            // 
            this.groupBoxWAccountInfo.Controls.Add(this.labelWBalance);
            this.groupBoxWAccountInfo.Controls.Add(this.labelWAddress);
            this.groupBoxWAccountInfo.Controls.Add(this.labelWName);
            this.groupBoxWAccountInfo.Controls.Add(this.textBoxWBalance);
            this.groupBoxWAccountInfo.Controls.Add(this.textBoxWaddress);
            this.groupBoxWAccountInfo.Controls.Add(this.textBoxWName);
            this.groupBoxWAccountInfo.Location = new System.Drawing.Point(26, 180);
            this.groupBoxWAccountInfo.Name = "groupBoxWAccountInfo";
            this.groupBoxWAccountInfo.Size = new System.Drawing.Size(303, 164);
            this.groupBoxWAccountInfo.TabIndex = 4;
            this.groupBoxWAccountInfo.TabStop = false;
            this.groupBoxWAccountInfo.Text = "Account Info";
            // 
            // labelWBalance
            // 
            this.labelWBalance.AutoSize = true;
            this.labelWBalance.Location = new System.Drawing.Point(45, 125);
            this.labelWBalance.Name = "labelWBalance";
            this.labelWBalance.Size = new System.Drawing.Size(59, 17);
            this.labelWBalance.TabIndex = 1;
            this.labelWBalance.Text = "Balance";
            // 
            // labelWAddress
            // 
            this.labelWAddress.AutoSize = true;
            this.labelWAddress.Location = new System.Drawing.Point(45, 85);
            this.labelWAddress.Name = "labelWAddress";
            this.labelWAddress.Size = new System.Drawing.Size(60, 17);
            this.labelWAddress.TabIndex = 1;
            this.labelWAddress.Text = "Address";
            // 
            // labelWName
            // 
            this.labelWName.AutoSize = true;
            this.labelWName.Location = new System.Drawing.Point(45, 45);
            this.labelWName.Name = "labelWName";
            this.labelWName.Size = new System.Drawing.Size(45, 17);
            this.labelWName.TabIndex = 1;
            this.labelWName.Text = "Name";
            // 
            // textBoxWBalance
            // 
            this.textBoxWBalance.Enabled = false;
            this.textBoxWBalance.Location = new System.Drawing.Point(116, 122);
            this.textBoxWBalance.Name = "textBoxWBalance";
            this.textBoxWBalance.Size = new System.Drawing.Size(168, 22);
            this.textBoxWBalance.TabIndex = 2;
            // 
            // textBoxWaddress
            // 
            this.textBoxWaddress.Enabled = false;
            this.textBoxWaddress.Location = new System.Drawing.Point(116, 82);
            this.textBoxWaddress.Name = "textBoxWaddress";
            this.textBoxWaddress.Size = new System.Drawing.Size(168, 22);
            this.textBoxWaddress.TabIndex = 2;
            // 
            // textBoxWName
            // 
            this.textBoxWName.Enabled = false;
            this.textBoxWName.Location = new System.Drawing.Point(116, 42);
            this.textBoxWName.Name = "textBoxWName";
            this.textBoxWName.Size = new System.Drawing.Size(168, 22);
            this.textBoxWName.TabIndex = 2;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(299, 371);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(75, 23);
            this.buttonWithdraw.TabIndex = 3;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            // 
            // buttonWSearch
            // 
            this.buttonWSearch.Location = new System.Drawing.Point(299, 71);
            this.buttonWSearch.Name = "buttonWSearch";
            this.buttonWSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonWSearch.TabIndex = 3;
            this.buttonWSearch.Text = "Search";
            this.buttonWSearch.UseVisualStyleBackColor = true;
            this.buttonWSearch.Click += new System.EventHandler(this.buttonWDSearch_Click);
            // 
            // textBoxWAccountNo
            // 
            this.textBoxWAccountNo.Location = new System.Drawing.Point(142, 71);
            this.textBoxWAccountNo.Name = "textBoxWAccountNo";
            this.textBoxWAccountNo.Size = new System.Drawing.Size(123, 22);
            this.textBoxWAccountNo.TabIndex = 2;
            // 
            // textBoxWithdraw
            // 
            this.textBoxWithdraw.Location = new System.Drawing.Point(177, 374);
            this.textBoxWithdraw.Name = "textBoxWithdraw";
            this.textBoxWithdraw.Size = new System.Drawing.Size(97, 22);
            this.textBoxWithdraw.TabIndex = 2;
            // 
            // labelWAccountNo
            // 
            this.labelWAccountNo.AutoSize = true;
            this.labelWAccountNo.Location = new System.Drawing.Point(23, 76);
            this.labelWAccountNo.Name = "labelWAccountNo";
            this.labelWAccountNo.Size = new System.Drawing.Size(113, 17);
            this.labelWAccountNo.TabIndex = 1;
            this.labelWAccountNo.Text = "Account Number";
            // 
            // labelWithdraw
            // 
            this.labelWithdraw.AutoSize = true;
            this.labelWithdraw.Location = new System.Drawing.Point(154, 17);
            this.labelWithdraw.Name = "labelWithdraw";
            this.labelWithdraw.Size = new System.Drawing.Size(66, 17);
            this.labelWithdraw.TabIndex = 0;
            this.labelWithdraw.Text = "Withdraw";
            // 
            // panelDeposit
            // 
            this.panelDeposit.Controls.Add(this.labelDepsoitAmount);
            this.panelDeposit.Controls.Add(this.labelDeposit);
            this.panelDeposit.Controls.Add(this.groupBoxDepositInfo);
            this.panelDeposit.Controls.Add(this.buttonDepsit);
            this.panelDeposit.Controls.Add(this.labelDAccountNo);
            this.panelDeposit.Controls.Add(this.buttonDSearchAcc);
            this.panelDeposit.Controls.Add(this.textBoxDepsoitAmout);
            this.panelDeposit.Controls.Add(this.textBoxDAccountNo);
            this.panelDeposit.Location = new System.Drawing.Point(1224, 3);
            this.panelDeposit.Name = "panelDeposit";
            this.panelDeposit.Size = new System.Drawing.Size(401, 445);
            this.panelDeposit.TabIndex = 8;
            this.panelDeposit.Visible = false;
            // 
            // labelDepsoitAmount
            // 
            this.labelDepsoitAmount.AutoSize = true;
            this.labelDepsoitAmount.Location = new System.Drawing.Point(53, 377);
            this.labelDepsoitAmount.Name = "labelDepsoitAmount";
            this.labelDepsoitAmount.Size = new System.Drawing.Size(108, 17);
            this.labelDepsoitAmount.TabIndex = 1;
            this.labelDepsoitAmount.Text = "Deposit Amount";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Location = new System.Drawing.Point(154, 17);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(56, 17);
            this.labelDeposit.TabIndex = 0;
            this.labelDeposit.Text = "Deposit";
            // 
            // groupBoxDepositInfo
            // 
            this.groupBoxDepositInfo.Controls.Add(this.labelBalance);
            this.groupBoxDepositInfo.Controls.Add(this.labelDAddress);
            this.groupBoxDepositInfo.Controls.Add(this.labelDName);
            this.groupBoxDepositInfo.Controls.Add(this.textBoxDBalance);
            this.groupBoxDepositInfo.Controls.Add(this.textBoxDAddress);
            this.groupBoxDepositInfo.Controls.Add(this.textBoxDName);
            this.groupBoxDepositInfo.Location = new System.Drawing.Point(26, 180);
            this.groupBoxDepositInfo.Name = "groupBoxDepositInfo";
            this.groupBoxDepositInfo.Size = new System.Drawing.Size(303, 164);
            this.groupBoxDepositInfo.TabIndex = 4;
            this.groupBoxDepositInfo.TabStop = false;
            this.groupBoxDepositInfo.Text = "Account Info";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(45, 125);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(59, 17);
            this.labelBalance.TabIndex = 1;
            this.labelBalance.Text = "Balance";
            // 
            // labelDAddress
            // 
            this.labelDAddress.AutoSize = true;
            this.labelDAddress.Location = new System.Drawing.Point(45, 85);
            this.labelDAddress.Name = "labelDAddress";
            this.labelDAddress.Size = new System.Drawing.Size(60, 17);
            this.labelDAddress.TabIndex = 1;
            this.labelDAddress.Text = "Address";
            // 
            // labelDName
            // 
            this.labelDName.AutoSize = true;
            this.labelDName.Location = new System.Drawing.Point(45, 45);
            this.labelDName.Name = "labelDName";
            this.labelDName.Size = new System.Drawing.Size(45, 17);
            this.labelDName.TabIndex = 1;
            this.labelDName.Text = "Name";
            // 
            // textBoxDBalance
            // 
            this.textBoxDBalance.Enabled = false;
            this.textBoxDBalance.Location = new System.Drawing.Point(116, 122);
            this.textBoxDBalance.Name = "textBoxDBalance";
            this.textBoxDBalance.Size = new System.Drawing.Size(168, 22);
            this.textBoxDBalance.TabIndex = 2;
            // 
            // textBoxDAddress
            // 
            this.textBoxDAddress.Enabled = false;
            this.textBoxDAddress.Location = new System.Drawing.Point(116, 82);
            this.textBoxDAddress.Name = "textBoxDAddress";
            this.textBoxDAddress.Size = new System.Drawing.Size(168, 22);
            this.textBoxDAddress.TabIndex = 2;
            // 
            // textBoxDName
            // 
            this.textBoxDName.Enabled = false;
            this.textBoxDName.Location = new System.Drawing.Point(116, 42);
            this.textBoxDName.Name = "textBoxDName";
            this.textBoxDName.Size = new System.Drawing.Size(168, 22);
            this.textBoxDName.TabIndex = 2;
            // 
            // buttonDepsit
            // 
            this.buttonDepsit.Location = new System.Drawing.Point(299, 371);
            this.buttonDepsit.Name = "buttonDepsit";
            this.buttonDepsit.Size = new System.Drawing.Size(75, 23);
            this.buttonDepsit.TabIndex = 3;
            this.buttonDepsit.Text = "Deposit";
            this.buttonDepsit.UseVisualStyleBackColor = true;
            // 
            // labelDAccountNo
            // 
            this.labelDAccountNo.AutoSize = true;
            this.labelDAccountNo.Location = new System.Drawing.Point(23, 76);
            this.labelDAccountNo.Name = "labelDAccountNo";
            this.labelDAccountNo.Size = new System.Drawing.Size(113, 17);
            this.labelDAccountNo.TabIndex = 1;
            this.labelDAccountNo.Text = "Account Number";
            // 
            // buttonDSearchAcc
            // 
            this.buttonDSearchAcc.Location = new System.Drawing.Point(299, 71);
            this.buttonDSearchAcc.Name = "buttonDSearchAcc";
            this.buttonDSearchAcc.Size = new System.Drawing.Size(75, 23);
            this.buttonDSearchAcc.TabIndex = 3;
            this.buttonDSearchAcc.Text = "Search";
            this.buttonDSearchAcc.UseVisualStyleBackColor = true;
            this.buttonDSearchAcc.Click += new System.EventHandler(this.buttonWDSearch_Click);
            // 
            // textBoxDepsoitAmout
            // 
            this.textBoxDepsoitAmout.Location = new System.Drawing.Point(177, 374);
            this.textBoxDepsoitAmout.Name = "textBoxDepsoitAmout";
            this.textBoxDepsoitAmout.Size = new System.Drawing.Size(97, 22);
            this.textBoxDepsoitAmout.TabIndex = 2;
            // 
            // textBoxDAccountNo
            // 
            this.textBoxDAccountNo.Location = new System.Drawing.Point(142, 71);
            this.textBoxDAccountNo.Name = "textBoxDAccountNo";
            this.textBoxDAccountNo.Size = new System.Drawing.Size(123, 22);
            this.textBoxDAccountNo.TabIndex = 2;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.hsbcDbDataSet;
            // 
            // hsbcDbDataSet
            // 
            this.hsbcDbDataSet.DataSetName = "HsbcDbDataSet";
            this.hsbcDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ph-0928114453.jpg");
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1660, 835);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAccountType.ResumeLayout(false);
            this.groupBoxAccountType.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.panelCreatAccount.ResumeLayout(false);
            this.panelCreatAccount.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelWithdraw.ResumeLayout(false);
            this.panelWithdraw.PerformLayout();
            this.groupBoxWAccountInfo.ResumeLayout(false);
            this.groupBoxWAccountInfo.PerformLayout();
            this.panelDeposit.ResumeLayout(false);
            this.panelDeposit.PerformLayout();
            this.groupBoxDepositInfo.ResumeLayout(false);
            this.groupBoxDepositInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsbcDbDataSet)).EndInit();
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
        private System.Windows.Forms.Panel panelCreatAccount;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem payInToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonWithdawMoney;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonDepositMoney;
        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.Panel panelWithdraw;
        private System.Windows.Forms.Label labelWithdraw;
        private System.Windows.Forms.Panel panelDeposit;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.ToolStripMenuItem welcomeToolStripMenuItem;
        private System.Windows.Forms.Label labelWName;
        private HsbcDbDataSet hsbcDbDataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private HsbcDbDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxWAccountInfo;
        private System.Windows.Forms.Label labelWBalance;
        private System.Windows.Forms.Label labelWAddress;
        private System.Windows.Forms.TextBox textBoxWBalance;
        private System.Windows.Forms.TextBox textBoxWaddress;
        private System.Windows.Forms.TextBox textBoxWName;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonWSearch;
        private System.Windows.Forms.TextBox textBoxWAccountNo;
        private System.Windows.Forms.TextBox textBoxWithdraw;
        private System.Windows.Forms.Label labelWAccountNo;
        private System.Windows.Forms.Label labelDepsoitAmount;
        private System.Windows.Forms.GroupBox groupBoxDepositInfo;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelDAddress;
        private System.Windows.Forms.Label labelDName;
        private System.Windows.Forms.TextBox textBoxDBalance;
        private System.Windows.Forms.TextBox textBoxDAddress;
        private System.Windows.Forms.TextBox textBoxDName;
        private System.Windows.Forms.Button buttonDepsit;
        private System.Windows.Forms.Label labelDAccountNo;
        private System.Windows.Forms.Button buttonDSearchAcc;
        private System.Windows.Forms.TextBox textBoxDepsoitAmout;
        private System.Windows.Forms.TextBox textBoxDAccountNo;
    }
}

