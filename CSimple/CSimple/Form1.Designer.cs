namespace CSimple
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
            this.GlowBox = new System.Windows.Forms.CheckBox();
            this.RadarBox = new System.Windows.Forms.CheckBox();
            this.GlowCombo = new System.Windows.Forms.ComboBox();
            this.NoFlashCheck = new System.Windows.Forms.CheckBox();
            this.Header = new System.Windows.Forms.Panel();
            this.HeaderClose = new System.Windows.Forms.Label();
            this.HeaderTitle = new System.Windows.Forms.Label();
            this.FovCheck = new System.Windows.Forms.CheckBox();
            this.TriggerCheck = new System.Windows.Forms.CheckBox();
            this.TriggerCombo = new System.Windows.Forms.ComboBox();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlowBox
            // 
            this.GlowBox.AutoSize = true;
            this.GlowBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GlowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GlowBox.ForeColor = System.Drawing.Color.White;
            this.GlowBox.Location = new System.Drawing.Point(12, 52);
            this.GlowBox.Name = "GlowBox";
            this.GlowBox.Size = new System.Drawing.Size(82, 20);
            this.GlowBox.TabIndex = 0;
            this.GlowBox.Text = "GlowESP";
            this.GlowBox.UseVisualStyleBackColor = true;
            this.GlowBox.CheckedChanged += new System.EventHandler(this.GlowBox_CheckedChanged);
            // 
            // RadarBox
            // 
            this.RadarBox.AutoSize = true;
            this.RadarBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.RadarBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RadarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RadarBox.ForeColor = System.Drawing.Color.White;
            this.RadarBox.Location = new System.Drawing.Point(12, 79);
            this.RadarBox.Name = "RadarBox";
            this.RadarBox.Size = new System.Drawing.Size(95, 20);
            this.RadarBox.TabIndex = 1;
            this.RadarBox.Text = "RadarHack";
            this.RadarBox.UseVisualStyleBackColor = false;
            this.RadarBox.CheckedChanged += new System.EventHandler(this.RadarBox_CheckedChanged);
            // 
            // GlowCombo
            // 
            this.GlowCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.GlowCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GlowCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GlowCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GlowCombo.ForeColor = System.Drawing.Color.White;
            this.GlowCombo.FormattingEnabled = true;
            this.GlowCombo.Items.AddRange(new object[] {
            "All",
            "Enemy Only",
            "Visible Only"});
            this.GlowCombo.Location = new System.Drawing.Point(109, 52);
            this.GlowCombo.Name = "GlowCombo";
            this.GlowCombo.Size = new System.Drawing.Size(121, 24);
            this.GlowCombo.TabIndex = 2;
            this.GlowCombo.SelectedIndexChanged += new System.EventHandler(this.GlowCombo_SelectedIndexChanged);
            // 
            // NoFlashCheck
            // 
            this.NoFlashCheck.AutoSize = true;
            this.NoFlashCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NoFlashCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NoFlashCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NoFlashCheck.ForeColor = System.Drawing.Color.White;
            this.NoFlashCheck.Location = new System.Drawing.Point(12, 106);
            this.NoFlashCheck.Name = "NoFlashCheck";
            this.NoFlashCheck.Size = new System.Drawing.Size(76, 20);
            this.NoFlashCheck.TabIndex = 3;
            this.NoFlashCheck.Text = "NoFlash";
            this.NoFlashCheck.UseVisualStyleBackColor = true;
            this.NoFlashCheck.CheckedChanged += new System.EventHandler(this.NoFlashCheck_CheckedChanged);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Header.Controls.Add(this.HeaderClose);
            this.Header.Controls.Add(this.HeaderTitle);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(242, 34);
            this.Header.TabIndex = 4;
            // 
            // HeaderClose
            // 
            this.HeaderClose.AutoSize = true;
            this.HeaderClose.BackColor = System.Drawing.Color.Transparent;
            this.HeaderClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HeaderClose.ForeColor = System.Drawing.Color.White;
            this.HeaderClose.Location = new System.Drawing.Point(219, 0);
            this.HeaderClose.Name = "HeaderClose";
            this.HeaderClose.Size = new System.Drawing.Size(22, 25);
            this.HeaderClose.TabIndex = 1;
            this.HeaderClose.Text = "x";
            this.HeaderClose.Click += new System.EventHandler(this.HeaderClose_Click);
            // 
            // HeaderTitle
            // 
            this.HeaderTitle.AutoSize = true;
            this.HeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.HeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HeaderTitle.ForeColor = System.Drawing.Color.White;
            this.HeaderTitle.Location = new System.Drawing.Point(73, 6);
            this.HeaderTitle.Name = "HeaderTitle";
            this.HeaderTitle.Size = new System.Drawing.Size(87, 25);
            this.HeaderTitle.TabIndex = 0;
            this.HeaderTitle.Text = "CSimple";
            // 
            // FovCheck
            // 
            this.FovCheck.AutoSize = true;
            this.FovCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FovCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FovCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FovCheck.ForeColor = System.Drawing.Color.White;
            this.FovCheck.Location = new System.Drawing.Point(12, 133);
            this.FovCheck.Name = "FovCheck";
            this.FovCheck.Size = new System.Drawing.Size(99, 20);
            this.FovCheck.TabIndex = 5;
            this.FovCheck.Text = "FovChanger";
            this.FovCheck.UseVisualStyleBackColor = true;
            this.FovCheck.CheckedChanged += new System.EventHandler(this.FovCheck_CheckedChanged);
            // 
            // TriggerCheck
            // 
            this.TriggerCheck.AutoSize = true;
            this.TriggerCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TriggerCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TriggerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TriggerCheck.ForeColor = System.Drawing.Color.White;
            this.TriggerCheck.Location = new System.Drawing.Point(12, 159);
            this.TriggerCheck.Name = "TriggerCheck";
            this.TriggerCheck.Size = new System.Drawing.Size(92, 20);
            this.TriggerCheck.TabIndex = 6;
            this.TriggerCheck.Text = "Trigger Bot";
            this.TriggerCheck.UseVisualStyleBackColor = true;
            this.TriggerCheck.CheckedChanged += new System.EventHandler(this.TriggerCheck_CheckedChanged);
            // 
            // TriggerCombo
            // 
            this.TriggerCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.TriggerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TriggerCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TriggerCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TriggerCombo.ForeColor = System.Drawing.Color.White;
            this.TriggerCombo.FormattingEnabled = true;
            this.TriggerCombo.ItemHeight = 16;
            this.TriggerCombo.Items.AddRange(new object[] {
            "none",
            "mouse1",
            "mouse2",
            "scroll",
            "mouse3",
            "mouse4",
            "mouse5",
            "none",
            "backspace",
            "tab",
            "none",
            "none",
            "clear",
            "enter",
            "none",
            "none",
            "shift",
            "control",
            "alt",
            "pause break",
            "caps lock",
            "none",
            "none",
            "none",
            "none",
            "none",
            "esc",
            "none",
            "none",
            "none",
            "none",
            "spacebar",
            "page up",
            "page down",
            "end",
            "home",
            "left arror",
            "up arror",
            "right arror",
            "down arror",
            "none",
            "none",
            "none",
            "print",
            "insert",
            "delete",
            "none",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "none",
            "none",
            "none",
            "none",
            "none",
            "none",
            "none",
            "none",
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
            "none",
            "none",
            "none",
            "none",
            "none",
            "numpad 0",
            "numpad 1",
            "numpad 2",
            "numpad 3",
            "numpad 4",
            "numpad 5",
            "numpad 6",
            "numpad 7",
            "numpad 8",
            "numpad 9",
            "multi",
            "add",
            "none",
            "subtract",
            "decimal",
            "divide",
            "f1",
            "f2",
            "f3",
            "f4",
            "f5",
            "f6",
            "f7",
            "f8",
            "f9",
            "f10",
            "f11",
            "f12"});
            this.TriggerCombo.Location = new System.Drawing.Point(109, 158);
            this.TriggerCombo.Name = "TriggerCombo";
            this.TriggerCombo.Size = new System.Drawing.Size(121, 24);
            this.TriggerCombo.TabIndex = 7;
            this.TriggerCombo.SelectedIndexChanged += new System.EventHandler(this.TriggerCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(242, 188);
            this.Controls.Add(this.TriggerCombo);
            this.Controls.Add(this.TriggerCheck);
            this.Controls.Add(this.FovCheck);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.NoFlashCheck);
            this.Controls.Add(this.GlowCombo);
            this.Controls.Add(this.RadarBox);
            this.Controls.Add(this.GlowBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSimple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox GlowBox;
        private System.Windows.Forms.CheckBox RadarBox;
        private System.Windows.Forms.ComboBox GlowCombo;
        private System.Windows.Forms.CheckBox NoFlashCheck;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label HeaderTitle;
        private System.Windows.Forms.Label HeaderClose;
        private System.Windows.Forms.CheckBox FovCheck;
        private System.Windows.Forms.CheckBox TriggerCheck;
        private System.Windows.Forms.ComboBox TriggerCombo;
    }
}

