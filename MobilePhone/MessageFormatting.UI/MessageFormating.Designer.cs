namespace MessageFormatting.UI
{
    partial class FormMessageFormating
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
            this.comboBoxSelectFormatting = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerMessageReciecer = new System.ComponentModel.BackgroundWorker();
            this.richTextBoxMessageInfo = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxSelectMessageFormating = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectMessageFormating.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSelectFormatting
            // 
            this.comboBoxSelectFormatting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectFormatting.Items.AddRange(new object[] {
            "None",
            "DateAndTime",
            "Uppercase"});
            this.comboBoxSelectFormatting.Location = new System.Drawing.Point(6, 28);
            this.comboBoxSelectFormatting.Name = "comboBoxSelectFormatting";
            this.comboBoxSelectFormatting.Size = new System.Drawing.Size(243, 21);
            this.comboBoxSelectFormatting.TabIndex = 1;
            // 
            // backgroundWorkerMessageReciecer
            // 
            this.backgroundWorkerMessageReciecer.WorkerReportsProgress = true;
            this.backgroundWorkerMessageReciecer.WorkerSupportsCancellation = true;
            this.backgroundWorkerMessageReciecer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMessageReciecer_DoWork);
            // 
            // richTextBoxMessageInfo
            // 
            this.richTextBoxMessageInfo.Location = new System.Drawing.Point(12, 87);
            this.richTextBoxMessageInfo.Name = "richTextBoxMessageInfo";
            this.richTextBoxMessageInfo.Size = new System.Drawing.Size(458, 338);
            this.richTextBoxMessageInfo.TabIndex = 3;
            this.richTextBoxMessageInfo.Text = "";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(295, 51);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(175, 30);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(295, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(175, 33);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxSelectMessageFormating
            // 
            this.groupBoxSelectMessageFormating.Controls.Add(this.comboBoxSelectFormatting);
            this.groupBoxSelectMessageFormating.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelectMessageFormating.Name = "groupBoxSelectMessageFormating";
            this.groupBoxSelectMessageFormating.Size = new System.Drawing.Size(258, 69);
            this.groupBoxSelectMessageFormating.TabIndex = 6;
            this.groupBoxSelectMessageFormating.TabStop = false;
            this.groupBoxSelectMessageFormating.Text = "SelectMessageFormating";
            // 
            // FormMessageFormating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 437);
            this.Controls.Add(this.groupBoxSelectMessageFormating);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.richTextBoxMessageInfo);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MaximizeBox = false;
            this.Name = "FormMessageFormating";
            this.Text = "Message Formatting";
            this.groupBoxSelectMessageFormating.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSelectFormatting;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMessageReciecer;
        private System.Windows.Forms.RichTextBox richTextBoxMessageInfo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxSelectMessageFormating;
    }
}

