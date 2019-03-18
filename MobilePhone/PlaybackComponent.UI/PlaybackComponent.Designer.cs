namespace PlaybackComponent.UI
{
    partial class formPlaybackComponent
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPlaybackCompInfo = new System.Windows.Forms.TextBox();
            this.comboBoxSelectPlaybackComp = new System.Windows.Forms.ComboBox();
            this.buttonApplyPlaybackComps = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonApplyPlaybackComps);
            this.groupBox2.Controls.Add(this.textBoxPlaybackCompInfo);
            this.groupBox2.Controls.Add(this.comboBoxSelectPlaybackComp);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 216);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select playback components:";
            // 
            // textBoxPlaybackCompInfo
            // 
            this.textBoxPlaybackCompInfo.Location = new System.Drawing.Point(12, 53);
            this.textBoxPlaybackCompInfo.Multiline = true;
            this.textBoxPlaybackCompInfo.Name = "textBoxPlaybackCompInfo";
            this.textBoxPlaybackCompInfo.Size = new System.Drawing.Size(382, 138);
            this.textBoxPlaybackCompInfo.TabIndex = 1;
            // 
            // comboBoxSelectPlaybackComp
            // 
            this.comboBoxSelectPlaybackComp.FormattingEnabled = true;
            this.comboBoxSelectPlaybackComp.Items.AddRange(new object[] {
            "PhoneHeadset",
            "PhoneSpeaker"});
            this.comboBoxSelectPlaybackComp.Location = new System.Drawing.Point(12, 26);
            this.comboBoxSelectPlaybackComp.Name = "comboBoxSelectPlaybackComp";
            this.comboBoxSelectPlaybackComp.Size = new System.Drawing.Size(167, 21);
            this.comboBoxSelectPlaybackComp.TabIndex = 0;
            this.comboBoxSelectPlaybackComp.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectPlaybackComp_SelectedIndexChanged);
            // 
            // buttonApplyPlaybackComps
            // 
            this.buttonApplyPlaybackComps.AllowDrop = true;
            this.buttonApplyPlaybackComps.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonApplyPlaybackComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyPlaybackComps.Location = new System.Drawing.Point(409, 53);
            this.buttonApplyPlaybackComps.Name = "buttonApplyPlaybackComps";
            this.buttonApplyPlaybackComps.Size = new System.Drawing.Size(186, 44);
            this.buttonApplyPlaybackComps.TabIndex = 3;
            this.buttonApplyPlaybackComps.Text = "ApplyPlaybackComponent";
            this.buttonApplyPlaybackComps.UseVisualStyleBackColor = false;
            this.buttonApplyPlaybackComps.Click += new System.EventHandler(this.buttonApplyPlaybackComp_Click);
            // 
            // formPlaybackComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 239);
            this.Controls.Add(this.groupBox2);
            this.Name = "formPlaybackComponent";
            this.Text = "PlaybackComponent";
            this.Load += new System.EventHandler(this.MobilePhone_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPlaybackCompInfo;
        private System.Windows.Forms.ComboBox comboBoxSelectPlaybackComp;
        private System.Windows.Forms.Button buttonApplyPlaybackComps;
    }
}

