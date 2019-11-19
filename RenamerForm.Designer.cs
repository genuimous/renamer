namespace Renamer
{
    partial class RenamerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenamerForm));
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.logLabel = new System.Windows.Forms.Label();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.guidTabPage = new System.Windows.Forms.TabPage();
            this.guidRemoveDashesCheckBox = new System.Windows.Forms.CheckBox();
            this.guidCaseGroupBox = new System.Windows.Forms.GroupBox();
            this.guidUppercaseRadioButton = new System.Windows.Forms.RadioButton();
            this.guidLowercaseRadioButton = new System.Windows.Forms.RadioButton();
            this.identityTabPage = new System.Windows.Forms.TabPage();
            this.identityDensityTrackBar = new System.Windows.Forms.TrackBar();
            this.identityDensityLabel = new System.Windows.Forms.Label();
            this.identityRandomizeCheckBox = new System.Windows.Forms.CheckBox();
            this.identityDigitsLabel = new System.Windows.Forms.Label();
            this.identityValueTextBox = new System.Windows.Forms.TextBox();
            this.identityPrefixTextBox = new System.Windows.Forms.TextBox();
            this.identityDigitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.identityPrefixlabel = new System.Windows.Forms.Label();
            this.identityValueLabel = new System.Windows.Forms.Label();
            this.kindTabControl = new System.Windows.Forms.TabControl();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.exampleTextBox = new System.Windows.Forms.TextBox();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.extentionTextBox = new System.Windows.Forms.TextBox();
            this.extentionLabel = new System.Windows.Forms.Label();
            this.guidTabPage.SuspendLayout();
            this.guidCaseGroupBox.SuspendLayout();
            this.identityTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.identityDensityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identityDigitsNumericUpDown)).BeginInit();
            this.kindTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logRichTextBox.Location = new System.Drawing.Point(12, 240);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.logRichTextBox.Size = new System.Drawing.Size(464, 122);
            this.logRichTextBox.TabIndex = 8;
            this.logRichTextBox.Text = "";
            this.logRichTextBox.WordWrap = false;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(12, 368);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 23);
            this.renameButton.TabIndex = 9;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 368);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(383, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(9, 224);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(25, 13);
            this.logLabel.TabIndex = 0;
            this.logLabel.Text = "Log";
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(12, 25);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(304, 20);
            this.directoryTextBox.TabIndex = 1;
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(9, 9);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(49, 13);
            this.directoryLabel.TabIndex = 0;
            this.directoryLabel.Text = "Directory";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(401, 23);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // guidTabPage
            // 
            this.guidTabPage.Controls.Add(this.guidRemoveDashesCheckBox);
            this.guidTabPage.Controls.Add(this.guidCaseGroupBox);
            this.guidTabPage.Location = new System.Drawing.Point(4, 22);
            this.guidTabPage.Name = "guidTabPage";
            this.guidTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.guidTabPage.Size = new System.Drawing.Size(456, 105);
            this.guidTabPage.TabIndex = 1;
            this.guidTabPage.Text = "GUID";
            this.guidTabPage.UseVisualStyleBackColor = true;
            // 
            // guidRemoveDashesCheckBox
            // 
            this.guidRemoveDashesCheckBox.AutoSize = true;
            this.guidRemoveDashesCheckBox.Location = new System.Drawing.Point(6, 6);
            this.guidRemoveDashesCheckBox.Name = "guidRemoveDashesCheckBox";
            this.guidRemoveDashesCheckBox.Size = new System.Drawing.Size(103, 17);
            this.guidRemoveDashesCheckBox.TabIndex = 1;
            this.guidRemoveDashesCheckBox.Text = "Remove dashes";
            this.guidRemoveDashesCheckBox.UseVisualStyleBackColor = true;
            this.guidRemoveDashesCheckBox.CheckedChanged += new System.EventHandler(this.guidRemoveDashesCheckBox_CheckedChanged);
            // 
            // guidCaseGroupBox
            // 
            this.guidCaseGroupBox.Controls.Add(this.guidUppercaseRadioButton);
            this.guidCaseGroupBox.Controls.Add(this.guidLowercaseRadioButton);
            this.guidCaseGroupBox.Location = new System.Drawing.Point(6, 29);
            this.guidCaseGroupBox.Name = "guidCaseGroupBox";
            this.guidCaseGroupBox.Size = new System.Drawing.Size(444, 70);
            this.guidCaseGroupBox.TabIndex = 2;
            this.guidCaseGroupBox.TabStop = false;
            this.guidCaseGroupBox.Text = "Generate as";
            // 
            // guidUppercaseRadioButton
            // 
            this.guidUppercaseRadioButton.AutoSize = true;
            this.guidUppercaseRadioButton.Location = new System.Drawing.Point(15, 42);
            this.guidUppercaseRadioButton.Name = "guidUppercaseRadioButton";
            this.guidUppercaseRadioButton.Size = new System.Drawing.Size(77, 17);
            this.guidUppercaseRadioButton.TabIndex = 2;
            this.guidUppercaseRadioButton.Text = "Uppercase";
            this.guidUppercaseRadioButton.UseVisualStyleBackColor = true;
            this.guidUppercaseRadioButton.CheckedChanged += new System.EventHandler(this.guidUppercaseRadioButton_CheckedChanged);
            // 
            // guidLowercaseRadioButton
            // 
            this.guidLowercaseRadioButton.AutoSize = true;
            this.guidLowercaseRadioButton.Checked = true;
            this.guidLowercaseRadioButton.Location = new System.Drawing.Point(15, 19);
            this.guidLowercaseRadioButton.Name = "guidLowercaseRadioButton";
            this.guidLowercaseRadioButton.Size = new System.Drawing.Size(77, 17);
            this.guidLowercaseRadioButton.TabIndex = 1;
            this.guidLowercaseRadioButton.TabStop = true;
            this.guidLowercaseRadioButton.Text = "Lowercase";
            this.guidLowercaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // identityTabPage
            // 
            this.identityTabPage.Controls.Add(this.identityDensityTrackBar);
            this.identityTabPage.Controls.Add(this.identityDensityLabel);
            this.identityTabPage.Controls.Add(this.identityRandomizeCheckBox);
            this.identityTabPage.Controls.Add(this.identityDigitsLabel);
            this.identityTabPage.Controls.Add(this.identityValueTextBox);
            this.identityTabPage.Controls.Add(this.identityPrefixTextBox);
            this.identityTabPage.Controls.Add(this.identityDigitsNumericUpDown);
            this.identityTabPage.Controls.Add(this.identityPrefixlabel);
            this.identityTabPage.Controls.Add(this.identityValueLabel);
            this.identityTabPage.Location = new System.Drawing.Point(4, 22);
            this.identityTabPage.Name = "identityTabPage";
            this.identityTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.identityTabPage.Size = new System.Drawing.Size(456, 105);
            this.identityTabPage.TabIndex = 0;
            this.identityTabPage.Text = "Identity";
            this.identityTabPage.UseVisualStyleBackColor = true;
            // 
            // identityDensityTrackBar
            // 
            this.identityDensityTrackBar.AutoSize = false;
            this.identityDensityTrackBar.Location = new System.Drawing.Point(6, 19);
            this.identityDensityTrackBar.Maximum = 9;
            this.identityDensityTrackBar.Minimum = 1;
            this.identityDensityTrackBar.Name = "identityDensityTrackBar";
            this.identityDensityTrackBar.Size = new System.Drawing.Size(444, 41);
            this.identityDensityTrackBar.TabIndex = 1;
            this.identityDensityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.identityDensityTrackBar.Value = 1;
            this.identityDensityTrackBar.ValueChanged += new System.EventHandler(this.identityDensityTrackBar_ValueChanged);
            // 
            // identityDensityLabel
            // 
            this.identityDensityLabel.Location = new System.Drawing.Point(3, 3);
            this.identityDensityLabel.Name = "identityDensityLabel";
            this.identityDensityLabel.Size = new System.Drawing.Size(450, 13);
            this.identityDensityLabel.TabIndex = 0;
            this.identityDensityLabel.Text = "Density";
            this.identityDensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // identityRandomizeCheckBox
            // 
            this.identityRandomizeCheckBox.AutoSize = true;
            this.identityRandomizeCheckBox.Location = new System.Drawing.Point(306, 81);
            this.identityRandomizeCheckBox.Name = "identityRandomizeCheckBox";
            this.identityRandomizeCheckBox.Size = new System.Drawing.Size(79, 17);
            this.identityRandomizeCheckBox.TabIndex = 4;
            this.identityRandomizeCheckBox.Text = "Randomize";
            this.identityRandomizeCheckBox.UseVisualStyleBackColor = true;
            this.identityRandomizeCheckBox.CheckedChanged += new System.EventHandler(this.identityRandomizeCheckBox_CheckedChanged);
            // 
            // identityDigitsLabel
            // 
            this.identityDigitsLabel.AutoSize = true;
            this.identityDigitsLabel.Location = new System.Drawing.Point(404, 63);
            this.identityDigitsLabel.Name = "identityDigitsLabel";
            this.identityDigitsLabel.Size = new System.Drawing.Size(33, 13);
            this.identityDigitsLabel.TabIndex = 0;
            this.identityDigitsLabel.Text = "Digits";
            // 
            // identityValueTextBox
            // 
            this.identityValueTextBox.Location = new System.Drawing.Point(156, 79);
            this.identityValueTextBox.Name = "identityValueTextBox";
            this.identityValueTextBox.Size = new System.Drawing.Size(144, 20);
            this.identityValueTextBox.TabIndex = 3;
            this.identityValueTextBox.TextChanged += new System.EventHandler(this.identityValueTextBox_TextChanged);
            // 
            // identityPrefixTextBox
            // 
            this.identityPrefixTextBox.Location = new System.Drawing.Point(6, 79);
            this.identityPrefixTextBox.Name = "identityPrefixTextBox";
            this.identityPrefixTextBox.Size = new System.Drawing.Size(144, 20);
            this.identityPrefixTextBox.TabIndex = 2;
            this.identityPrefixTextBox.TextChanged += new System.EventHandler(this.identityPrefixTextBox_TextChanged);
            // 
            // identityDigitsNumericUpDown
            // 
            this.identityDigitsNumericUpDown.Location = new System.Drawing.Point(407, 79);
            this.identityDigitsNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.identityDigitsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.identityDigitsNumericUpDown.Name = "identityDigitsNumericUpDown";
            this.identityDigitsNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.identityDigitsNumericUpDown.TabIndex = 5;
            this.identityDigitsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.identityDigitsNumericUpDown.ValueChanged += new System.EventHandler(this.identityDigitsNumericUpDown_ValueChanged);
            // 
            // identityPrefixlabel
            // 
            this.identityPrefixlabel.AutoSize = true;
            this.identityPrefixlabel.Location = new System.Drawing.Point(3, 63);
            this.identityPrefixlabel.Name = "identityPrefixlabel";
            this.identityPrefixlabel.Size = new System.Drawing.Size(33, 13);
            this.identityPrefixlabel.TabIndex = 0;
            this.identityPrefixlabel.Text = "Prefix";
            // 
            // identityValueLabel
            // 
            this.identityValueLabel.AutoSize = true;
            this.identityValueLabel.Location = new System.Drawing.Point(153, 63);
            this.identityValueLabel.Name = "identityValueLabel";
            this.identityValueLabel.Size = new System.Drawing.Size(56, 13);
            this.identityValueLabel.TabIndex = 0;
            this.identityValueLabel.Text = "Last value";
            // 
            // kindTabControl
            // 
            this.kindTabControl.Controls.Add(this.identityTabPage);
            this.kindTabControl.Controls.Add(this.guidTabPage);
            this.kindTabControl.Location = new System.Drawing.Point(12, 51);
            this.kindTabControl.Name = "kindTabControl";
            this.kindTabControl.SelectedIndex = 0;
            this.kindTabControl.Size = new System.Drawing.Size(464, 131);
            this.kindTabControl.TabIndex = 5;
            this.kindTabControl.SelectedIndexChanged += new System.EventHandler(this.kindTabControl_SelectedIndexChanged);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(322, 25);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(73, 20);
            this.filterTextBox.TabIndex = 2;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(319, 9);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(29, 13);
            this.filterLabel.TabIndex = 0;
            this.filterLabel.Text = "Filter";
            // 
            // exampleTextBox
            // 
            this.exampleTextBox.Location = new System.Drawing.Point(12, 201);
            this.exampleTextBox.Name = "exampleTextBox";
            this.exampleTextBox.ReadOnly = true;
            this.exampleTextBox.Size = new System.Drawing.Size(383, 20);
            this.exampleTextBox.TabIndex = 6;
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Location = new System.Drawing.Point(9, 185);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(83, 13);
            this.exampleLabel.TabIndex = 0;
            this.exampleLabel.Text = "Name (example)";
            // 
            // extentionTextBox
            // 
            this.extentionTextBox.Location = new System.Drawing.Point(401, 201);
            this.extentionTextBox.Name = "extentionTextBox";
            this.extentionTextBox.Size = new System.Drawing.Size(75, 20);
            this.extentionTextBox.TabIndex = 7;
            // 
            // extentionLabel
            // 
            this.extentionLabel.AutoSize = true;
            this.extentionLabel.Location = new System.Drawing.Point(398, 185);
            this.extentionLabel.Name = "extentionLabel";
            this.extentionLabel.Size = new System.Drawing.Size(51, 13);
            this.extentionLabel.TabIndex = 0;
            this.extentionLabel.Text = "Extention";
            // 
            // RenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 403);
            this.Controls.Add(this.extentionLabel);
            this.Controls.Add(this.extentionTextBox);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.exampleTextBox);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.kindTabControl);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.directoryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RenamerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unique Key Renamer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenamerForm_FormClosed);
            this.guidTabPage.ResumeLayout(false);
            this.guidTabPage.PerformLayout();
            this.guidCaseGroupBox.ResumeLayout(false);
            this.guidCaseGroupBox.PerformLayout();
            this.identityTabPage.ResumeLayout(false);
            this.identityTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.identityDensityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identityDigitsNumericUpDown)).EndInit();
            this.kindTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TabPage guidTabPage;
        private System.Windows.Forms.CheckBox guidRemoveDashesCheckBox;
        private System.Windows.Forms.GroupBox guidCaseGroupBox;
        private System.Windows.Forms.RadioButton guidUppercaseRadioButton;
        private System.Windows.Forms.RadioButton guidLowercaseRadioButton;
        private System.Windows.Forms.TabPage identityTabPage;
        private System.Windows.Forms.TrackBar identityDensityTrackBar;
        private System.Windows.Forms.Label identityDensityLabel;
        private System.Windows.Forms.CheckBox identityRandomizeCheckBox;
        private System.Windows.Forms.Label identityDigitsLabel;
        private System.Windows.Forms.TextBox identityValueTextBox;
        private System.Windows.Forms.TextBox identityPrefixTextBox;
        private System.Windows.Forms.NumericUpDown identityDigitsNumericUpDown;
        private System.Windows.Forms.Label identityPrefixlabel;
        private System.Windows.Forms.Label identityValueLabel;
        private System.Windows.Forms.TabControl kindTabControl;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox exampleTextBox;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.TextBox extentionTextBox;
        private System.Windows.Forms.Label extentionLabel;
    }
}

