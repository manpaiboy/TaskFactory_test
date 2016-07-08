namespace PlatformTools
{
    partial class MyUpdatePackageFileVerification
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("客户端更新\\version.dat");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("version", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("服务端更新\\");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("服务端更新目录", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("客户端更新\\ini\\play.dat");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("play", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("客户端更新\\ini\\oem.dat");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("oem", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyUpdatePackageFileVerification));
            this.Btn_Seleparete = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.labClientPath = new System.Windows.Forms.Label();
            this.labPackagePath = new System.Windows.Forms.Label();
            this.btnRunVerity = new System.Windows.Forms.Button();
            this.btnLoadClient = new System.Windows.Forms.Button();
            this.btnLoadPackage = new System.Windows.Forms.Button();
            this.skinCaptionPanel1 = new CCWin.SkinControl.SkinCaptionPanel();
            this.richTextBoxPrintWaring = new ExtendedRichTextBox.RichTextBoxPrintCtrl();
            this.richTxtWarning = new System.Windows.Forms.RichTextBox();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.tv_default = new System.Windows.Forms.TreeView();
            this.cBoxListDefaultFunction = new System.Windows.Forms.CheckedListBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.cBoxListFunction = new System.Windows.Forms.CheckedListBox();
            this.gBoxRightResult = new System.Windows.Forms.GroupBox();
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.label3 = new System.Windows.Forms.Label();
            this.gBoxLeftList = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogPackage = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogClient = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelLoadProcess = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFilesCount = new System.Windows.Forms.Label();
            this.skinProgressBar1 = new CCWin.SkinControl.SkinProgressBar();
            this.btnLoadpCancel = new CCWin.SkinControl.SkinButton();
            this.panelMain.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.skinCaptionPanel1.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.gBoxRightResult.SuspendLayout();
            this.gBoxLeftList.SuspendLayout();
            this.panelLoadProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Seleparete
            // 
            this.Btn_Seleparete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Seleparete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Btn_Seleparete.Location = new System.Drawing.Point(1403, 8);
            this.Btn_Seleparete.Name = "Btn_Seleparete";
            this.Btn_Seleparete.Size = new System.Drawing.Size(24, 23);
            this.Btn_Seleparete.TabIndex = 40;
            this.Btn_Seleparete.Text = "分离";
            this.Btn_Seleparete.UseVisualStyleBackColor = false;
            this.Btn_Seleparete.Click += new System.EventHandler(this.Btn_Seleparete_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.skinPanel1);
            this.panelMain.Controls.Add(this.skinCaptionPanel1);
            this.panelMain.Controls.Add(this.skinGroupBox1);
            this.panelMain.Controls.Add(this.gBoxRightResult);
            this.panelMain.Location = new System.Drawing.Point(11, 42);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1496, 689);
            this.panelMain.TabIndex = 41;
            // 
            // skinPanel1
            // 
            this.skinPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinButton1);
            this.skinPanel1.Controls.Add(this.labClientPath);
            this.skinPanel1.Controls.Add(this.labPackagePath);
            this.skinPanel1.Controls.Add(this.btnRunVerity);
            this.skinPanel1.Controls.Add(this.btnLoadClient);
            this.skinPanel1.Controls.Add(this.btnLoadPackage);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(246, 615);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(1222, 68);
            this.skinPanel1.TabIndex = 47;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(305, 4);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(86, 41);
            this.skinButton1.TabIndex = 12;
            this.skinButton1.Text = "比对";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Visible = false;
            // 
            // labClientPath
            // 
            this.labClientPath.AutoSize = true;
            this.labClientPath.ForeColor = System.Drawing.Color.LightGray;
            this.labClientPath.Location = new System.Drawing.Point(407, 51);
            this.labClientPath.Name = "labClientPath";
            this.labClientPath.Size = new System.Drawing.Size(83, 12);
            this.labClientPath.TabIndex = 11;
            this.labClientPath.Text = "客户端路径...";
            // 
            // labPackagePath
            // 
            this.labPackagePath.AutoSize = true;
            this.labPackagePath.ForeColor = System.Drawing.Color.LightGray;
            this.labPackagePath.Location = new System.Drawing.Point(98, 51);
            this.labPackagePath.Name = "labPackagePath";
            this.labPackagePath.Size = new System.Drawing.Size(83, 12);
            this.labPackagePath.TabIndex = 10;
            this.labPackagePath.Text = "更新包路径...";
            // 
            // btnRunVerity
            // 
            this.btnRunVerity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunVerity.Location = new System.Drawing.Point(690, 4);
            this.btnRunVerity.Name = "btnRunVerity";
            this.btnRunVerity.Size = new System.Drawing.Size(145, 41);
            this.btnRunVerity.TabIndex = 9;
            this.btnRunVerity.Text = "执行检查(&R)";
            this.btnRunVerity.UseVisualStyleBackColor = true;
            this.btnRunVerity.Click += new System.EventHandler(this.btnRunVerity_Click);
            // 
            // btnLoadClient
            // 
            this.btnLoadClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadClient.Location = new System.Drawing.Point(424, 4);
            this.btnLoadClient.Name = "btnLoadClient";
            this.btnLoadClient.Size = new System.Drawing.Size(145, 41);
            this.btnLoadClient.TabIndex = 8;
            this.btnLoadClient.Text = "载入客户端(&C)";
            this.btnLoadClient.UseVisualStyleBackColor = true;
            this.btnLoadClient.Click += new System.EventHandler(this.btnLoadClient_Click);
            // 
            // btnLoadPackage
            // 
            this.btnLoadPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPackage.Location = new System.Drawing.Point(133, 4);
            this.btnLoadPackage.Name = "btnLoadPackage";
            this.btnLoadPackage.Size = new System.Drawing.Size(145, 41);
            this.btnLoadPackage.TabIndex = 7;
            this.btnLoadPackage.Text = "载入更新包(&U)";
            this.btnLoadPackage.UseVisualStyleBackColor = true;
            this.btnLoadPackage.Click += new System.EventHandler(this.btnLoadPackage_Click);
            // 
            // skinCaptionPanel1
            // 
            this.skinCaptionPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinCaptionPanel1.CaptionFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCaptionPanel1.Controls.Add(this.panelLoadProcess);
            this.skinCaptionPanel1.Controls.Add(this.richTextBoxPrintWaring);
            this.skinCaptionPanel1.Controls.Add(this.richTxtWarning);
            this.skinCaptionPanel1.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCaptionPanel1.Location = new System.Drawing.Point(353, 30);
            this.skinCaptionPanel1.Name = "skinCaptionPanel1";
            this.skinCaptionPanel1.Size = new System.Drawing.Size(1117, 579);
            this.skinCaptionPanel1.TabIndex = 45;
            this.skinCaptionPanel1.Text = "结果输出";
            // 
            // richTextBoxPrintWaring
            // 
            this.richTextBoxPrintWaring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPrintWaring.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxPrintWaring.Location = new System.Drawing.Point(2, 24);
            this.richTextBoxPrintWaring.Name = "richTextBoxPrintWaring";
            this.richTextBoxPrintWaring.ShowSelectionMargin = true;
            this.richTextBoxPrintWaring.Size = new System.Drawing.Size(1113, 553);
            this.richTextBoxPrintWaring.TabIndex = 45;
            this.richTextBoxPrintWaring.Text = "";
            // 
            // richTxtWarning
            // 
            this.richTxtWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtWarning.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTxtWarning.Location = new System.Drawing.Point(2, 24);
            this.richTxtWarning.Name = "richTxtWarning";
            this.richTxtWarning.Size = new System.Drawing.Size(1113, 553);
            this.richTxtWarning.TabIndex = 45;
            this.richTxtWarning.Text = "";
            this.richTxtWarning.Visible = false;
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.skinGroupBox3);
            this.skinGroupBox1.Controls.Add(this.skinGroupBox2);
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.skinGroupBox1.Location = new System.Drawing.Point(23, 30);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(324, 562);
            this.skinGroupBox1.TabIndex = 46;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "功能列表";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBox3.Controls.Add(this.tv_default);
            this.skinGroupBox3.Controls.Add(this.cBoxListDefaultFunction);
            this.skinGroupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox3.ForeColor = System.Drawing.Color.Gray;
            this.skinGroupBox3.Location = new System.Drawing.Point(6, 294);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(312, 261);
            this.skinGroupBox3.TabIndex = 1;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "默认功能：";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.Gray;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tv_default
            // 
            this.tv_default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.tv_default.CheckBoxes = true;
            this.tv_default.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold);
            this.tv_default.ForeColor = System.Drawing.Color.Gray;
            this.tv_default.Location = new System.Drawing.Point(6, 20);
            this.tv_default.Name = "tv_default";
            treeNode1.Name = "节点5";
            treeNode1.Text = "客户端更新\\version.dat";
            treeNode2.Name = "节点0";
            treeNode2.Text = "version";
            treeNode3.Name = "节点6";
            treeNode3.Text = "服务端更新\\";
            treeNode4.Name = "节点1";
            treeNode4.Text = "服务端更新目录";
            treeNode5.Name = "节点3";
            treeNode5.Text = "客户端更新\\ini\\play.dat";
            treeNode6.Name = "节点4";
            treeNode6.Text = "play";
            treeNode7.Name = "节点8";
            treeNode7.Text = "客户端更新\\ini\\oem.dat";
            treeNode8.Name = "节点7";
            treeNode8.Text = "oem";
            this.tv_default.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8});
            this.tv_default.Size = new System.Drawing.Size(300, 231);
            this.tv_default.TabIndex = 46;
            this.tv_default.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_default_AfterCheck);
            // 
            // cBoxListDefaultFunction
            // 
            this.cBoxListDefaultFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.cBoxListDefaultFunction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cBoxListDefaultFunction.CheckOnClick = true;
            this.cBoxListDefaultFunction.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxListDefaultFunction.ForeColor = System.Drawing.Color.Gray;
            this.cBoxListDefaultFunction.FormattingEnabled = true;
            this.cBoxListDefaultFunction.Location = new System.Drawing.Point(6, 20);
            this.cBoxListDefaultFunction.Name = "cBoxListDefaultFunction";
            this.cBoxListDefaultFunction.ScrollAlwaysVisible = true;
            this.cBoxListDefaultFunction.Size = new System.Drawing.Size(300, 231);
            this.cBoxListDefaultFunction.TabIndex = 44;
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Controls.Add(this.cBoxListFunction);
            this.skinGroupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Location = new System.Drawing.Point(6, 22);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(312, 261);
            this.skinGroupBox2.TabIndex = 0;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "可选功能：";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // cBoxListFunction
            // 
            this.cBoxListFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.cBoxListFunction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cBoxListFunction.CheckOnClick = true;
            this.cBoxListFunction.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxListFunction.FormattingEnabled = true;
            this.cBoxListFunction.Location = new System.Drawing.Point(6, 25);
            this.cBoxListFunction.Name = "cBoxListFunction";
            this.cBoxListFunction.ScrollAlwaysVisible = true;
            this.cBoxListFunction.Size = new System.Drawing.Size(300, 231);
            this.cBoxListFunction.TabIndex = 43;
            // 
            // gBoxRightResult
            // 
            this.gBoxRightResult.Controls.Add(this.textEditorControl1);
            this.gBoxRightResult.Controls.Add(this.label3);
            this.gBoxRightResult.Controls.Add(this.gBoxLeftList);
            this.gBoxRightResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxRightResult.Location = new System.Drawing.Point(23, 615);
            this.gBoxRightResult.Name = "gBoxRightResult";
            this.gBoxRightResult.Size = new System.Drawing.Size(87, 579);
            this.gBoxRightResult.TabIndex = 1;
            this.gBoxRightResult.TabStop = false;
            this.gBoxRightResult.Visible = false;
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.AutoScroll = true;
            this.textEditorControl1.IsReadOnly = false;
            this.textEditorControl1.Location = new System.Drawing.Point(3, 45);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(74, 534);
            this.textEditorControl1.TabIndex = 42;
            this.textEditorControl1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "结果输出";
            // 
            // gBoxLeftList
            // 
            this.gBoxLeftList.Controls.Add(this.label2);
            this.gBoxLeftList.Controls.Add(this.label1);
            this.gBoxLeftList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxLeftList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBoxLeftList.Location = new System.Drawing.Point(776, 74);
            this.gBoxLeftList.Name = "gBoxLeftList";
            this.gBoxLeftList.Size = new System.Drawing.Size(335, 566);
            this.gBoxLeftList.TabIndex = 0;
            this.gBoxLeftList.TabStop = false;
            this.gBoxLeftList.Text = "功能列表";
            this.gBoxLeftList.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "默认功能：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "可选功能：";
            // 
            // panelLoadProcess
            // 
            this.panelLoadProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoadProcess.Controls.Add(this.btnLoadpCancel);
            this.panelLoadProcess.Controls.Add(this.skinProgressBar1);
            this.panelLoadProcess.Controls.Add(this.lbFilesCount);
            this.panelLoadProcess.Controls.Add(this.label4);
            this.panelLoadProcess.Location = new System.Drawing.Point(246, 220);
            this.panelLoadProcess.Name = "panelLoadProcess";
            this.panelLoadProcess.Size = new System.Drawing.Size(447, 87);
            this.panelLoadProcess.TabIndex = 46;
            this.panelLoadProcess.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "正在载入客户端文件...";
            // 
            // lbFilesCount
            // 
            this.lbFilesCount.AutoSize = true;
            this.lbFilesCount.Location = new System.Drawing.Point(332, 43);
            this.lbFilesCount.Name = "lbFilesCount";
            this.lbFilesCount.Size = new System.Drawing.Size(56, 14);
            this.lbFilesCount.TabIndex = 3;
            this.lbFilesCount.Text = "{0}/{0}";
            // 
            // skinProgressBar1
            // 
            this.skinProgressBar1.Back = null;
            this.skinProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.BarBack = null;
            this.skinProgressBar1.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.ForeColor = System.Drawing.Color.Red;
            this.skinProgressBar1.Location = new System.Drawing.Point(63, 37);
            this.skinProgressBar1.Name = "skinProgressBar1";
            this.skinProgressBar1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.Size = new System.Drawing.Size(263, 23);
            this.skinProgressBar1.TabIndex = 4;
            // 
            // btnLoadpCancel
            // 
            this.btnLoadpCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnLoadpCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnLoadpCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLoadpCancel.DownBack = null;
            this.btnLoadpCancel.Font = new System.Drawing.Font("新宋体", 9.5F);
            this.btnLoadpCancel.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.btnLoadpCancel.Location = new System.Drawing.Point(392, 2);
            this.btnLoadpCancel.MouseBack = null;
            this.btnLoadpCancel.Name = "btnLoadpCancel";
            this.btnLoadpCancel.NormlBack = null;
            this.btnLoadpCancel.Size = new System.Drawing.Size(51, 23);
            this.btnLoadpCancel.TabIndex = 5;
            this.btnLoadpCancel.Text = "取消";
            this.btnLoadpCancel.UseVisualStyleBackColor = false;
            this.btnLoadpCancel.Click += new System.EventHandler(this.btnLoadpCancel_Click);
            // 
            // MyUpdatePackageFileVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 753);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.Btn_Seleparete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyUpdatePackageFileVerification";
            this.Text = "魔域更新包检查工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyUpdatePackageFileVerification_FormClosing);
            this.Load += new System.EventHandler(this.MyUpdatePackageFileVerification_Load);
            this.Move += new System.EventHandler(this.MyUpdatePackageFileVerification_Move);
            this.panelMain.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinCaptionPanel1.ResumeLayout(false);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox2.ResumeLayout(false);
            this.gBoxRightResult.ResumeLayout(false);
            this.gBoxRightResult.PerformLayout();
            this.gBoxLeftList.ResumeLayout(false);
            this.gBoxLeftList.PerformLayout();
            this.panelLoadProcess.ResumeLayout(false);
            this.panelLoadProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Btn_Seleparete;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gBoxLeftList;
        private System.Windows.Forms.GroupBox gBoxRightResult;
        private System.Windows.Forms.RichTextBox richTxtWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cBoxListDefaultFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPackage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogClient;
        private System.Windows.Forms.ToolTip toolTip1;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private System.Windows.Forms.CheckedListBox cBoxListFunction;
        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Label labClientPath;
        private System.Windows.Forms.Label labPackagePath;
        private System.Windows.Forms.Button btnRunVerity;
        private System.Windows.Forms.Button btnLoadClient;
        private System.Windows.Forms.Button btnLoadPackage;
        private CCWin.SkinControl.SkinButton skinButton1;
        private ExtendedRichTextBox.RichTextBoxPrintCtrl richTextBoxPrintWaring;
        /// <summary>
        /// 默认功能加载树
        /// </summary>
        private System.Windows.Forms.TreeView tv_default;
        private System.Windows.Forms.Panel panelLoadProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFilesCount;
        private CCWin.SkinControl.SkinProgressBar skinProgressBar1;
        private CCWin.SkinControl.SkinButton btnLoadpCancel;
    }
}