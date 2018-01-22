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
            this.SuspendLayout();
            // 
            // GlowBox
            // 
            this.GlowBox.AutoSize = true;
            this.GlowBox.Location = new System.Drawing.Point(12, 26);
            this.GlowBox.Name = "GlowBox";
            this.GlowBox.Size = new System.Drawing.Size(71, 17);
            this.GlowBox.TabIndex = 0;
            this.GlowBox.Text = "GlowESP";
            this.GlowBox.UseVisualStyleBackColor = true;
            this.GlowBox.CheckedChanged += new System.EventHandler(this.GlowBox_CheckedChanged);
            // 
            // RadarBox
            // 
            this.RadarBox.AutoSize = true;
            this.RadarBox.Location = new System.Drawing.Point(12, 56);
            this.RadarBox.Name = "RadarBox";
            this.RadarBox.Size = new System.Drawing.Size(81, 17);
            this.RadarBox.TabIndex = 1;
            this.RadarBox.Text = "RadarHack";
            this.RadarBox.UseVisualStyleBackColor = true;
            this.RadarBox.CheckedChanged += new System.EventHandler(this.RadarBox_CheckedChanged);
            // 
            // GlowCombo
            // 
            this.GlowCombo.FormattingEnabled = true;
            this.GlowCombo.Items.AddRange(new object[] {
            "All",
            "Enemy Only"});
            this.GlowCombo.Location = new System.Drawing.Point(89, 26);
            this.GlowCombo.Name = "GlowCombo";
            this.GlowCombo.Size = new System.Drawing.Size(121, 21);
            this.GlowCombo.TabIndex = 2;
            this.GlowCombo.SelectedIndexChanged += new System.EventHandler(this.GlowCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 85);
            this.Controls.Add(this.GlowCombo);
            this.Controls.Add(this.RadarBox);
            this.Controls.Add(this.GlowBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox GlowBox;
        private System.Windows.Forms.CheckBox RadarBox;
        private System.Windows.Forms.ComboBox GlowCombo;
    }
}

