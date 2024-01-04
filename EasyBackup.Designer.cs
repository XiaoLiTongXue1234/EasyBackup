namespace EasyBackup
{
    partial class EasyBackup
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
            homeLabel0 = new Label();
            settings = new Button();
            settingsPanel = new Panel();
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
            home.Location = new Point(21, 22);
            home.Name = "home";
            home.Size = new Size(75, 23);
            home.TabIndex = 0;
            home.Text = "主页";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // homePanel
            // 
            homePanel.Controls.Add(homeLabel0);
            homePanel.Location = new Point(100, 10);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(650, 400);
            homePanel.TabIndex = 1;
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
            settings.Location = new Point(21, 79);
            settings.Name = "settings";
            settings.Size = new Size(75, 23);
            settings.TabIndex = 2;
            settings.Text = "设置";
            settings.UseVisualStyleBackColor = true;
            settings.Click += settings_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.Controls.Add(label2);
            settingsPanel.Controls.Add(settingsLable0);
            settingsPanel.Controls.Add(button3);
            settingsPanel.Controls.Add(textBox1);
            settingsPanel.Location = new Point(100, 10);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(650, 400);
            settingsPanel.TabIndex = 3;
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
            // 
            // others
            // 
            others.Location = new Point(21, 143);
            others.Name = "others";
            others.Size = new Size(75, 23);
            others.TabIndex = 4;
            others.Text = "其它";
            others.UseVisualStyleBackColor = true;
            others.Click += others_Click;
            // 
            // othersPanel
            // 
            othersPanel.Controls.Add(othersLabel0);
            othersPanel.Controls.Add(about);
            othersPanel.Location = new Point(100, 10);
            othersPanel.Name = "othersPanel";
            othersPanel.Size = new Size(650, 400);
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
            // EasyBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(homePanel);
            Controls.Add(others);
            Controls.Add(settingsPanel);
            Controls.Add(settings);
            Controls.Add(home);
            Controls.Add(othersPanel);
            Name = "EasyBackup";
            Text = "EasyBackup";
            Load += EasyBackup_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            othersPanel.ResumeLayout(false);
            othersPanel.PerformLayout();
            ResumeLayout(false);
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
    }
}