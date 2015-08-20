namespace Pokebot
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
            this.tab_MainView = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_Test = new System.Windows.Forms.Label();
            this.grp_Player = new System.Windows.Forms.GroupBox();
            this.txt_PlayerPositionY = new System.Windows.Forms.TextBox();
            this.txt_MapID = new System.Windows.Forms.TextBox();
            this.txt_PlayerPositionX = new System.Windows.Forms.TextBox();
            this.lbl_MapID = new System.Windows.Forms.Label();
            this.lbl_PlayerPosition = new System.Windows.Forms.Label();
            this.lbl_TalkingState = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_RemoveSame = new System.Windows.Forms.Button();
            this.btn_RemoveChanged = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tab_Log = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_Sprites = new System.Windows.Forms.GroupBox();
            this.list_Sprites = new RefreshingListBox();
            this.tab_MainView.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grp_Player.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grp_Sprites.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_MainView
            // 
            this.tab_MainView.Controls.Add(this.tabPage2);
            this.tab_MainView.Controls.Add(this.tabPage1);
            this.tab_MainView.Controls.Add(this.tab_Log);
            this.tab_MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_MainView.Location = new System.Drawing.Point(0, 24);
            this.tab_MainView.Name = "tab_MainView";
            this.tab_MainView.SelectedIndex = 0;
            this.tab_MainView.Size = new System.Drawing.Size(601, 772);
            this.tab_MainView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grp_Sprites);
            this.tabPage2.Controls.Add(this.lbl_Test);
            this.tabPage2.Controls.Add(this.grp_Player);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 746);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Test
            // 
            this.lbl_Test.AutoSize = true;
            this.lbl_Test.Location = new System.Drawing.Point(112, 384);
            this.lbl_Test.Name = "lbl_Test";
            this.lbl_Test.Size = new System.Drawing.Size(44, 13);
            this.lbl_Test.TabIndex = 7;
            this.lbl_Test.Text = "lbl_Test";
            // 
            // grp_Player
            // 
            this.grp_Player.Controls.Add(this.txt_PlayerPositionY);
            this.grp_Player.Controls.Add(this.txt_MapID);
            this.grp_Player.Controls.Add(this.txt_PlayerPositionX);
            this.grp_Player.Controls.Add(this.lbl_MapID);
            this.grp_Player.Controls.Add(this.lbl_PlayerPosition);
            this.grp_Player.Controls.Add(this.lbl_TalkingState);
            this.grp_Player.Location = new System.Drawing.Point(8, 6);
            this.grp_Player.Name = "grp_Player";
            this.grp_Player.Size = new System.Drawing.Size(238, 267);
            this.grp_Player.TabIndex = 6;
            this.grp_Player.TabStop = false;
            this.grp_Player.Text = "Player";
            // 
            // txt_PlayerPositionY
            // 
            this.txt_PlayerPositionY.Location = new System.Drawing.Point(101, 49);
            this.txt_PlayerPositionY.Name = "txt_PlayerPositionY";
            this.txt_PlayerPositionY.Size = new System.Drawing.Size(39, 20);
            this.txt_PlayerPositionY.TabIndex = 7;
            this.txt_PlayerPositionY.Text = "0";
            // 
            // txt_MapID
            // 
            this.txt_MapID.Location = new System.Drawing.Point(43, 23);
            this.txt_MapID.Name = "txt_MapID";
            this.txt_MapID.Size = new System.Drawing.Size(39, 20);
            this.txt_MapID.TabIndex = 7;
            this.txt_MapID.Text = "0";
            // 
            // txt_PlayerPositionX
            // 
            this.txt_PlayerPositionX.Location = new System.Drawing.Point(56, 49);
            this.txt_PlayerPositionX.Name = "txt_PlayerPositionX";
            this.txt_PlayerPositionX.Size = new System.Drawing.Size(39, 20);
            this.txt_PlayerPositionX.TabIndex = 7;
            this.txt_PlayerPositionX.Text = "0";
            // 
            // lbl_MapID
            // 
            this.lbl_MapID.AutoSize = true;
            this.lbl_MapID.Location = new System.Drawing.Point(6, 26);
            this.lbl_MapID.Name = "lbl_MapID";
            this.lbl_MapID.Size = new System.Drawing.Size(31, 13);
            this.lbl_MapID.TabIndex = 6;
            this.lbl_MapID.Text = "Map:";
            // 
            // lbl_PlayerPosition
            // 
            this.lbl_PlayerPosition.AutoSize = true;
            this.lbl_PlayerPosition.Location = new System.Drawing.Point(6, 52);
            this.lbl_PlayerPosition.Name = "lbl_PlayerPosition";
            this.lbl_PlayerPosition.Size = new System.Drawing.Size(47, 13);
            this.lbl_PlayerPosition.TabIndex = 6;
            this.lbl_PlayerPosition.Text = "Position:";
            // 
            // lbl_TalkingState
            // 
            this.lbl_TalkingState.AutoSize = true;
            this.lbl_TalkingState.Location = new System.Drawing.Point(60, 210);
            this.lbl_TalkingState.Name = "lbl_TalkingState";
            this.lbl_TalkingState.Size = new System.Drawing.Size(35, 13);
            this.lbl_TalkingState.TabIndex = 5;
            this.lbl_TalkingState.Text = "label1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_RemoveSame);
            this.tabPage1.Controls.Add(this.btn_RemoveChanged);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 746);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Memory Tools";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveSame
            // 
            this.btn_RemoveSame.Location = new System.Drawing.Point(6, 467);
            this.btn_RemoveSame.Name = "btn_RemoveSame";
            this.btn_RemoveSame.Size = new System.Drawing.Size(133, 23);
            this.btn_RemoveSame.TabIndex = 6;
            this.btn_RemoveSame.Text = "Remove Same";
            this.btn_RemoveSame.UseVisualStyleBackColor = true;
            this.btn_RemoveSame.Click += new System.EventHandler(this.btn_RemoveSame_Click);
            // 
            // btn_RemoveChanged
            // 
            this.btn_RemoveChanged.Location = new System.Drawing.Point(6, 438);
            this.btn_RemoveChanged.Name = "btn_RemoveChanged";
            this.btn_RemoveChanged.Size = new System.Drawing.Size(133, 23);
            this.btn_RemoveChanged.TabIndex = 6;
            this.btn_RemoveChanged.Text = "Remove Changed";
            this.btn_RemoveChanged.UseVisualStyleBackColor = true;
            this.btn_RemoveChanged.Click += new System.EventHandler(this.btn_RemoveChanged_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(145, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(317, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(268, 420);
            this.listBox2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(510, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Remove All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 420);
            this.listBox1.TabIndex = 0;
            // 
            // tab_Log
            // 
            this.tab_Log.Location = new System.Drawing.Point(4, 22);
            this.tab_Log.Name = "tab_Log";
            this.tab_Log.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Log.Size = new System.Drawing.Size(593, 746);
            this.tab_Log.TabIndex = 2;
            this.tab_Log.Text = "Log";
            this.tab_Log.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // grp_Sprites
            // 
            this.grp_Sprites.Controls.Add(this.list_Sprites);
            this.grp_Sprites.Location = new System.Drawing.Point(252, 6);
            this.grp_Sprites.Name = "grp_Sprites";
            this.grp_Sprites.Size = new System.Drawing.Size(333, 267);
            this.grp_Sprites.TabIndex = 8;
            this.grp_Sprites.TabStop = false;
            this.grp_Sprites.Text = "Sprites";
            // 
            // list_Sprites
            // 
            this.list_Sprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Sprites.FormattingEnabled = true;
            this.list_Sprites.Location = new System.Drawing.Point(3, 16);
            this.list_Sprites.Name = "list_Sprites";
            this.list_Sprites.Size = new System.Drawing.Size(327, 248);
            this.list_Sprites.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 796);
            this.Controls.Add(this.tab_MainView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pokemon Red Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_MainView.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grp_Player.ResumeLayout(false);
            this.grp_Player.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_Sprites.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_MainView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_RemoveChanged;
        private System.Windows.Forms.Button btn_RemoveSame;
        private System.Windows.Forms.Label lbl_TalkingState;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage tab_Log;
        private System.Windows.Forms.GroupBox grp_Player;
        private System.Windows.Forms.TextBox txt_PlayerPositionY;
        private System.Windows.Forms.TextBox txt_PlayerPositionX;
        private System.Windows.Forms.Label lbl_PlayerPosition;
        private System.Windows.Forms.TextBox txt_MapID;
        private System.Windows.Forms.Label lbl_MapID;
        private System.Windows.Forms.Label lbl_Test;
        private System.Windows.Forms.GroupBox grp_Sprites;
        private RefreshingListBox list_Sprites;
    }
}

