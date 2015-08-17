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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_AutoUpdate = new System.Windows.Forms.CheckBox();
            this.btn_RemoveChanged = new System.Windows.Forms.Button();
            this.btn_RemoveSame = new System.Windows.Forms.Button();
            this.tab_MainView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_MainView
            // 
            this.tab_MainView.Controls.Add(this.tabPage1);
            this.tab_MainView.Controls.Add(this.tabPage2);
            this.tab_MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_MainView.Location = new System.Drawing.Point(0, 0);
            this.tab_MainView.Name = "tab_MainView";
            this.tab_MainView.SelectedIndex = 0;
            this.tab_MainView.Size = new System.Drawing.Size(601, 920);
            this.tab_MainView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_RemoveSame);
            this.tabPage1.Controls.Add(this.btn_RemoveChanged);
            this.tabPage1.Controls.Add(this.chk_AutoUpdate);
            this.tabPage1.Controls.Add(this.label1);
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
            this.tabPage1.Size = new System.Drawing.Size(593, 894);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 894);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 760);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // chk_AutoUpdate
            // 
            this.chk_AutoUpdate.AutoSize = true;
            this.chk_AutoUpdate.Location = new System.Drawing.Point(90, 680);
            this.chk_AutoUpdate.Name = "chk_AutoUpdate";
            this.chk_AutoUpdate.Size = new System.Drawing.Size(86, 17);
            this.chk_AutoUpdate.TabIndex = 5;
            this.chk_AutoUpdate.Text = "Auto Update";
            this.chk_AutoUpdate.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 920);
            this.Controls.Add(this.tab_MainView);
            this.Name = "Form1";
            this.Text = "Pokemon Red Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_MainView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_AutoUpdate;
        private System.Windows.Forms.Button btn_RemoveChanged;
        private System.Windows.Forms.Button btn_RemoveSame;
    }
}

