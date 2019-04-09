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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxSelectMessageFormating = new System.Windows.Forms.GroupBox();
            this.richTextBoxMessageInfo = new System.Windows.Forms.RichTextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.listViewShow = new System.Windows.Forms.ListView();
            this.columnHeaderReceivers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFilteringLogic = new System.Windows.Forms.ComboBox();
            this.groupBoxSelectMessageFormating.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // richTextBoxMessageInfo
            // 
            this.richTextBoxMessageInfo.Location = new System.Drawing.Point(12, 87);
            this.richTextBoxMessageInfo.Name = "richTextBoxMessageInfo";
            this.richTextBoxMessageInfo.Size = new System.Drawing.Size(458, 103);
            this.richTextBoxMessageInfo.TabIndex = 3;
            this.richTextBoxMessageInfo.Text = "";
            // 
            // buttonShow
            // 
            this.buttonShow.Enabled = false;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(295, 202);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(170, 30);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "ShowReceived";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // listViewShow
            // 
            this.listViewShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderReceivers,
            this.columnHeaderText,
            this.columnHeaderTime});
            this.listViewShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewShow.FullRowSelect = true;
            this.listViewShow.GridLines = true;
            this.listViewShow.Location = new System.Drawing.Point(12, 365);
            this.listViewShow.Name = "listViewShow";
            this.listViewShow.Size = new System.Drawing.Size(458, 297);
            this.listViewShow.TabIndex = 10;
            this.listViewShow.UseCompatibleStateImageBehavior = false;
            this.listViewShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderReceivers
            // 
            this.columnHeaderReceivers.Text = "Receivers";
            this.columnHeaderReceivers.Width = 160;
            // 
            // columnHeaderText
            // 
            this.columnHeaderText.Text = "Text";
            this.columnHeaderText.Width = 200;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 100;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.Location = new System.Drawing.Point(6, 37);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(243, 21);
            this.comboBoxUsers.TabIndex = 11;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFilteringLogic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 158);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Receivers";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(6, 81);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(243, 20);
            this.textBoxText.TabIndex = 13;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filtering logic";
            // 
            // comboBoxFilteringLogic
            // 
            this.comboBoxFilteringLogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilteringLogic.FormattingEnabled = true;
            this.comboBoxFilteringLogic.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.comboBoxFilteringLogic.Location = new System.Drawing.Point(6, 125);
            this.comboBoxFilteringLogic.Name = "comboBoxFilteringLogic";
            this.comboBoxFilteringLogic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilteringLogic.TabIndex = 18;
            this.comboBoxFilteringLogic.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilteringLogic_SelectedIndexChanged);
            // 
            // FormMessageFormating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewShow);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.groupBoxSelectMessageFormating);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.richTextBoxMessageInfo);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MaximizeBox = false;
            this.Name = "FormMessageFormating";
            this.Text = "Message Formatting";
            this.groupBoxSelectMessageFormating.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSelectFormatting;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMessageReciecer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxSelectMessageFormating;
        private System.Windows.Forms.RichTextBox richTextBoxMessageInfo;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ListView listViewShow;
        private System.Windows.Forms.ColumnHeader columnHeaderReceivers;
        private System.Windows.Forms.ColumnHeader columnHeaderText;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFilteringLogic;
    }
}

