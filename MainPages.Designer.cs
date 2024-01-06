namespace EasyBackup
{
    partial class MainPages
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
            home = new Button();
            homePanel = new Panel();
            homeProcessLable = new Label();
            homeStatusLabel = new Label();
            homeProgressBar = new ProgressBar();
            homeLabel1 = new Label();
            backupSelectedItemButton = new Button();
            backupAllFilesButton = new Button();
            deleteSelectedItemButton = new Button();
            addDirButton = new Button();
            addFileButton = new Button();
            backupFilesListBox = new ListBox();
            homeLabel0 = new Label();
            settings = new Button();
            settingsPanel = new Panel();
            settings_ResetButton = new Button();
            settingsLabel1 = new Label();
            label2 = new Label();
            settingsLable0 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            others = new Button();
            othersPanel = new Panel();
            othersLabel0 = new Label();
            about = new Button();
            homePanel.SuspendLayout();
            settingsPanel.SuspendLayout();
            othersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // home
            // 
            home.Location = new Point(3, 10);
            home.Name = "home";
            home.Size = new Size(90, 30);
            home.TabIndex = 0;
            home.Text = "主页";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // homePanel
            // 
            homePanel.BackColor = Color.White;
            homePanel.Controls.Add(homeProcessLable);
            homePanel.Controls.Add(homeStatusLabel);
            homePanel.Controls.Add(homeProgressBar);
            homePanel.Controls.Add(homeLabel1);
            homePanel.Controls.Add(backupSelectedItemButton);
            homePanel.Controls.Add(backupAllFilesButton);
            homePanel.Controls.Add(deleteSelectedItemButton);
            homePanel.Controls.Add(addDirButton);
            homePanel.Controls.Add(addFileButton);
            homePanel.Controls.Add(backupFilesListBox);
            homePanel.Controls.Add(homeLabel0);
            homePanel.Location = new Point(100, 10);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(690, 430);
            homePanel.TabIndex = 1;
            // 
            // homeProcessLable
            // 
            homeProcessLable.AutoSize = true;
            homeProcessLable.Location = new Point(14, 407);
            homeProcessLable.Name = "homeProcessLable";
            homeProcessLable.Size = new Size(108, 17);
            homeProcessLable.TabIndex = 13;
            homeProcessLable.Text = "正在备份条目 ''......";
            // 
            // homeStatusLabel
            // 
            homeStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            homeStatusLabel.AutoSize = true;
            homeStatusLabel.Location = new Point(643, 405);
            homeStatusLabel.Name = "homeStatusLabel";
            homeStatusLabel.Size = new Size(32, 17);
            homeStatusLabel.TabIndex = 12;
            homeStatusLabel.Text = "完成";
            homeStatusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // homeProgressBar
            // 
            homeProgressBar.Location = new Point(15, 382);
            homeProgressBar.Name = "homeProgressBar";
            homeProgressBar.Size = new Size(660, 20);
            homeProgressBar.TabIndex = 11;
            // 
            // homeLabel1
            // 
            homeLabel1.AutoSize = true;
            homeLabel1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            homeLabel1.Location = new Point(15, 37);
            homeLabel1.Name = "homeLabel1";
            homeLabel1.Size = new Size(65, 20);
            homeLabel1.TabIndex = 10;
            homeLabel1.Text = "备份列表";
            // 
            // backupSelectedItemButton
            // 
            backupSelectedItemButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            backupSelectedItemButton.Location = new Point(124, 338);
            backupSelectedItemButton.Name = "backupSelectedItemButton";
            backupSelectedItemButton.Size = new Size(103, 38);
            backupSelectedItemButton.TabIndex = 9;
            backupSelectedItemButton.Text = "备份所选项";
            backupSelectedItemButton.UseVisualStyleBackColor = true;
            backupSelectedItemButton.Click += backupSelectedItemButton_Click;
            // 
            // backupAllFilesButton
            // 
            backupAllFilesButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            backupAllFilesButton.Location = new Point(15, 338);
            backupAllFilesButton.Name = "backupAllFilesButton";
            backupAllFilesButton.Size = new Size(103, 38);
            backupAllFilesButton.TabIndex = 8;
            backupAllFilesButton.Text = "全部备份";
            backupAllFilesButton.UseVisualStyleBackColor = true;
            backupAllFilesButton.Click += backupAllFilesButton_Click;
            // 
            // deleteSelectedItemButton
            // 
            deleteSelectedItemButton.Location = new Point(189, 309);
            deleteSelectedItemButton.Name = "deleteSelectedItemButton";
            deleteSelectedItemButton.Size = new Size(82, 23);
            deleteSelectedItemButton.TabIndex = 7;
            deleteSelectedItemButton.Text = "删除所选项";
            deleteSelectedItemButton.UseVisualStyleBackColor = true;
            deleteSelectedItemButton.Click += deleteSelectedItemButton_Click;
            // 
            // addDirButton
            // 
            addDirButton.Location = new Point(96, 309);
            addDirButton.Name = "addDirButton";
            addDirButton.Size = new Size(87, 23);
            addDirButton.TabIndex = 6;
            addDirButton.Text = "添加文件夹";
            addDirButton.UseVisualStyleBackColor = true;
            addDirButton.Click += addDirButton_Click;
            // 
            // addFileButton
            // 
            addFileButton.Location = new Point(15, 309);
            addFileButton.Name = "addFileButton";
            addFileButton.Size = new Size(75, 23);
            addFileButton.TabIndex = 5;
            addFileButton.Text = "添加文件";
            addFileButton.UseVisualStyleBackColor = true;
            addFileButton.Click += addFileButton_Click;
            // 
            // backupFilesListBox
            // 
            backupFilesListBox.FormattingEnabled = true;
            backupFilesListBox.ItemHeight = 17;
            backupFilesListBox.Location = new Point(15, 61);
            backupFilesListBox.Name = "backupFilesListBox";
            backupFilesListBox.Size = new Size(444, 242);
            backupFilesListBox.TabIndex = 4;
            backupFilesListBox.SelectedIndexChanged += backupFilesListBox_SelectedIndexChanged;
            // 
            // homeLabel0
            // 
            homeLabel0.AutoSize = true;
            homeLabel0.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            homeLabel0.Location = new Point(5, 5);
            homeLabel0.Name = "homeLabel0";
            homeLabel0.Size = new Size(50, 26);
            homeLabel0.TabIndex = 3;
            homeLabel0.Text = "主页";
            // 
            // settings
            // 
            settings.Location = new Point(3, 46);
            settings.Name = "settings";
            settings.Size = new Size(90, 30);
            settings.TabIndex = 2;
            settings.Text = "设置";
            settings.UseVisualStyleBackColor = true;
            settings.Click += settings_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.AutoScroll = true;
            settingsPanel.AutoSize = true;
            settingsPanel.BackColor = Color.White;
            settingsPanel.Controls.Add(settings_ResetButton);
            settingsPanel.Controls.Add(settingsLabel1);
            settingsPanel.Controls.Add(label2);
            settingsPanel.Controls.Add(settingsLable0);
            settingsPanel.Controls.Add(button3);
            settingsPanel.Controls.Add(textBox1);
            settingsPanel.Location = new Point(100, 10);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(690, 430);
            settingsPanel.TabIndex = 3;
            // 
            // settings_ResetButton
            // 
            settings_ResetButton.Location = new Point(53, 64);
            settings_ResetButton.Name = "settings_ResetButton";
            settings_ResetButton.Size = new Size(75, 23);
            settings_ResetButton.TabIndex = 5;
            settings_ResetButton.Text = "点击重置";
            settings_ResetButton.UseVisualStyleBackColor = true;
            settings_ResetButton.Click += settings_ResetButton_Click;
            // 
            // settingsLabel1
            // 
            settingsLabel1.AutoSize = true;
            settingsLabel1.Location = new Point(15, 67);
            settingsLabel1.Name = "settingsLabel1";
            settingsLabel1.Size = new Size(32, 17);
            settingsLabel1.TabIndex = 4;
            settingsLabel1.Text = "重置";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 37);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 3;
            label2.Text = "备份存储路径";
            // 
            // settingsLable0
            // 
            settingsLable0.AutoSize = true;
            settingsLable0.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            settingsLable0.Location = new Point(5, 5);
            settingsLable0.Name = "settingsLable0";
            settingsLable0.Size = new Size(50, 26);
            settingsLable0.TabIndex = 2;
            settingsLable0.Text = "设置";
            // 
            // button3
            // 
            button3.Location = new Point(571, 32);
            button3.Name = "button3";
            button3.Size = new Size(50, 27);
            button3.TabIndex = 1;
            button3.Text = "更改";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // others
            // 
            others.Location = new Point(3, 82);
            others.Name = "others";
            others.Size = new Size(90, 30);
            others.TabIndex = 4;
            others.Text = "其它";
            others.UseVisualStyleBackColor = true;
            others.Click += others_Click;
            // 
            // othersPanel
            // 
            othersPanel.BackColor = Color.White;
            othersPanel.Controls.Add(othersLabel0);
            othersPanel.Controls.Add(about);
            othersPanel.Location = new Point(100, 10);
            othersPanel.Name = "othersPanel";
            othersPanel.Size = new Size(690, 430);
            othersPanel.TabIndex = 4;
            // 
            // othersLabel0
            // 
            othersLabel0.AutoSize = true;
            othersLabel0.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            othersLabel0.Location = new Point(5, 5);
            othersLabel0.Name = "othersLabel0";
            othersLabel0.Size = new Size(50, 26);
            othersLabel0.TabIndex = 4;
            othersLabel0.Text = "其它";
            // 
            // about
            // 
            about.Location = new Point(47, 41);
            about.Name = "about";
            about.Size = new Size(75, 23);
            about.TabIndex = 0;
            about.Text = "关于";
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // MainPages
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(home);
            Controls.Add(settings);
            Controls.Add(homePanel);
            Controls.Add(others);
            Controls.Add(settingsPanel);
            Controls.Add(othersPanel);
            Name = "MainPages";
            Text = "EasyBackup";
            Load += EasyBackup_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            othersPanel.ResumeLayout(false);
            othersPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button home;
        private Panel homePanel;
        private Button settings;
        private Panel settingsPanel;
        private Label settingsLable0;
        private Button button3;
        private TextBox textBox1;
        private Label label2;
        private Button others;
        private Panel othersPanel;
        private Button about;
        private Label homeLabel0;
        private Label othersLabel0;
        private Button settings_ResetButton;
        private Label settingsLabel1;
        private ListBox backupFilesListBox;
        private Button addFileButton;
        private Button addDirButton;
        private Button deleteSelectedItemButton;
        private Button backupAllFilesButton;
        private Button backupSelectedItemButton;
        private Label homeLabel1;
        private ProgressBar homeProgressBar;
        private Label homeStatusLabel;
        private Label homeProcessLable;
    }
}