using System;
using System.IO;
using System.Windows.Forms;

namespace Renamer
{
    public partial class RenamerForm : Form
    {
        private const string identityDensityKey = "identityDensity";
        private const string identityPrefixKey = "identityPrefix";
        private const string identityValueKey = "identityValue";
        private const string identityRandomizeKey = "identityRandomize";
        private const string identityDigitsKey = "identityDigits";
        private const string guidRemoveDashesKey = "guidRemoveDashes";
        private const string guidUppercaseKey = "guidUppercase";

        private Random random = new Random();

        private bool ready = false;

        public RenamerForm()
        {
            InitializeComponent();

            // Load settings
            try
            {
                identityDensityTrackBar.Value = Int32.Parse(Configuration.GetValue(identityDensityKey));
                identityPrefixTextBox.Text = Configuration.GetValue(identityPrefixKey);
                identityValueTextBox.Text = Configuration.GetValue(identityValueKey);
                identityRandomizeCheckBox.Checked = bool.Parse(Configuration.GetValue(identityRandomizeKey));
                identityDigitsNumericUpDown.Value = decimal.Parse(Configuration.GetValue(identityDigitsKey));

                guidRemoveDashesCheckBox.Checked = bool.Parse(Configuration.GetValue(guidRemoveDashesKey));
                guidUppercaseRadioButton.Checked = bool.Parse(Configuration.GetValue(guidUppercaseKey));
            }
            catch
            {
                identityDensityTrackBar.Value = (identityDensityTrackBar.Maximum - identityDensityTrackBar.Minimum) / 2 + 1;
                identityPrefixTextBox.Text = "";
                identityValueTextBox.Text = "";
                identityRandomizeCheckBox.Checked = false;
                identityDigitsNumericUpDown.Value = 1;

                guidRemoveDashesCheckBox.Checked = true;
                guidUppercaseRadioButton.Checked = false;
            }

            guidLowercaseRadioButton.Checked = !guidUppercaseRadioButton.Checked;

            ready = true;

            BuildExample();
        }

        private long GenerateIdentity(long value)
        {
            long identity = value;

            int density = identityDensityTrackBar.Value;

            if (identityRandomizeCheckBox.Checked)
            {
                int increment = 0;

                for (int i = 1; i <= density; i++)
                {
                    increment = increment + random.Next(random.Next(1, i + 1)) + random.Next(1);
                }

                identity = identity + Math.Max(1, increment) + random.Next(0, density + 1) + 1;
            }
            else
            {
                identity = identity + density;
            }

            return identity;
        }

        private string GenerateGuid()
        {
            return Guid.NewGuid().ToString();
        }

        private string FormatIdentity(long value)
        {
            return identityPrefixTextBox.Text.Trim() + value.ToString().PadLeft(decimal.ToInt32(identityDigitsNumericUpDown.Value), '0');
        }

        private string FormatGuid(string value)
        {
            string guid = value;

            if (guidRemoveDashesCheckBox.Checked)
            {
                guid = guid.Replace("-", "");
            }

            if (guidUppercaseRadioButton.Checked)
            {
                guid = guid.ToUpper();
            }

            return guid;
        }

        private string NewFileName()
        {
            string newFileName = "";

            switch (kindTabControl.SelectedIndex)
            {
                // Identity
                case 0:
                {
                    long identity = 0;
                    string identityValue = identityValueTextBox.Text.Trim();

                    if (identityValue.Length > 0)
                    {
                        identity = Int64.Parse(identityValue);
                    }

                    identity = GenerateIdentity(identity);

                    newFileName = FormatIdentity(identity);

                    if (ready)
                    {
                        identityValueTextBox.Text = identity.ToString();
                    }

                    break;
                }
                // GUID
                case 1:
                {
                    newFileName = FormatGuid(GenerateGuid());

                    break;
                }
            }
            return newFileName;
        }

        private void BuildExample()
        {
            if (ready)
            {
                ready = false;
                exampleTextBox.Text = NewFileName();
                ready = true;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    directoryTextBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            string path = directoryTextBox.Text.Trim();
            string mask = filterTextBox.Text.Trim();

            if (mask.Length == 0)
            {
                mask = "*";
            }

            if (path.Length > 0)
            {
                if (!path.EndsWith("\\"))
                {
                    path = path + "\\";
                }

                if (Directory.Exists(path))
                {
                    // Get list of files
                    string[] files = Directory.GetFiles(path, mask);

                    progressBar.Minimum = 0;
                    progressBar.Maximum = files.Length;

                    logRichTextBox.Clear();

                    try
                    {
                        int fileCount = 0;

                        // Iterate each file
                        foreach (string file in files)
                        {
                            string fileName = Path.GetFileName(file);
                            string fileExtension = Path.GetExtension(file);

                            string newFileName = NewFileName();
                            string newFileExtension = extentionTextBox.Text.Trim();

                            if (newFileExtension.Length > 0)
                            {
                                if (!newFileExtension.StartsWith("."))
                                {
                                    newFileExtension = "." + newFileExtension;
                                }
                                else
                                {
                                    if (newFileExtension.Equals("."))
                                    {
                                        newFileExtension = "";
                                    }
                                }
                            }
                            else
                            {
                                newFileExtension = fileExtension;
                            }

                            newFileName = newFileName + newFileExtension;

                            // Rename current file
                            string newFile = path + newFileName;
                            File.Move(file, newFile);

                            // Log
                            if (fileCount > 0)
                            {
                                logRichTextBox.AppendText("\n");
                            }
                            logRichTextBox.AppendText(fileName + " -> " + newFileName);

                            // Next file
                            fileCount++;
                            progressBar.PerformStep();
                        }

                        // Display summary
                        if (fileCount > 0)
                        {
                            MessageDialog.ShowInformation(fileCount.ToString() + " files has been processed successfully!");
                        }
                        else
                        {
                            MessageDialog.ShowInformation("No files found!");
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageDialog.ShowError(exception.Message);
                    }
                    finally
                    {
                        progressBar.Value = 0;
                    }
                }
                else
                {
                    MessageDialog.ShowError("Directory \"" + path + "\" does not exists!");
                }
            }
            else
            {
                MessageDialog.ShowError("Please provide directory!");
            }
        }

        private void RenamerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save settings
            try
            {
                Configuration.SetValue(identityDensityKey, identityDensityTrackBar.Value.ToString());
                Configuration.SetValue(identityPrefixKey, identityPrefixTextBox.Text);
                Configuration.SetValue(identityValueKey, identityValueTextBox.Text);
                Configuration.SetValue(identityRandomizeKey, identityRandomizeCheckBox.Checked.ToString());
                Configuration.SetValue(identityDigitsKey, identityDigitsNumericUpDown.Value.ToString());

                Configuration.SetValue(guidRemoveDashesKey, guidRemoveDashesCheckBox.Checked.ToString());
                Configuration.SetValue(guidUppercaseKey, guidUppercaseRadioButton.Checked.ToString());
            }
            catch
            {
                MessageDialog.ShowError("Can't write configuration!");
            }
        }

        private void identityPrefixTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildExample();
        }

        private void identityValueTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildExample();
        }

        private void identityRandomizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BuildExample();
        }

        private void identityDigitsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BuildExample();
        }

        private void guidRemoveDashesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BuildExample();
        }

        private void guidUppercaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BuildExample();
        }

        private void kindTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildExample();
        }
    }
}
