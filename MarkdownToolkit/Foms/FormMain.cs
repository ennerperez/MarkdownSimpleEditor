using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Pictograms;

namespace Toolkit.Forms
{
    public partial class FormMain : Form
    {
        public string FileName { get; set; } = string.Empty;
        public string FileContent { get; set; } = string.Empty;
        public string StyleSheet { get; set; } = string.Empty;

        public bool HasChanged()
        {
            return textBoxMarkDown.Text != FileContent;
        }

        public bool HasAutorefresh()
        {
            return toolStripMenuItemAutoRefresh.Checked;
        }

        public FormMain()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);

            // Icons
            toolStripButtonFile.SetImage(MaterialDesign.Instance, Program.Icon, 48, SystemColors.Control);

            newToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.insert_drive_file, 48, toolStripMenu.BackColor);
            openToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, toolStripMenu.BackColor);
            saveToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, toolStripMenu.BackColor);
            saveAsToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, toolStripMenu.BackColor);
            exportToolStripMenuItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.import_export, 48, toolStripMenu.BackColor);

            toolStripButtonPrint.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.print, 48, SystemColors.Control);
            toolStripButtonRefresh.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.refresh, 48, SystemColors.Control);
            toolStripButtonStyle.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.style, 48, SystemColors.Control);

            toolStripButtonUpdates.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.system_update_alt, 48, SystemColors.Control);

            toolStripMenuItemSwapDivider.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.linear_scale, 48, toolStripMenu.BackColor);
            toolStripMenuItemAutoRefresh.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.autorenew, 48, toolStripMenu.BackColor);

#if DEBUG
            FormHelper.ExtractResources(toolStripMenu);
#endif

            textBoxMarkDown.ContextMenuStrip = contextMenuStripEdit;
        }

        private void openFileDialogOpen_FileOk(object sender, CancelEventArgs e)
        {
            var _FileName = openFileDialogOpen.FileName;
            var _FileContent = string.Empty;
            try
            {
                _FileContent = File.ReadAllText(_FileName);
                FileName = _FileName;
                FileContent = _FileContent;
                textBoxMarkDown.Text = FileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Cancel = true;
            }
        }

        private void SaveFileDialogSaveAs_FileOk(object sender, CancelEventArgs e)
        {
            var _FileName = saveFileDialogSaveAs.FileName;
            var _FileContent = textBoxMarkDown.Text;
            try
            {
                File.WriteAllText(_FileName, _FileContent);
                FileName = _FileName;
                FileContent = _FileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Cancel = true;
            }
        }

        private void SaveFileDialogExport_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialogExport.FileName, webBrowserMarkdownPreview.DocumentText);
        }

        private void OpenFileDialogCSS_FileOk(object sender, CancelEventArgs e)
        {
            StyleSheet = File.ReadAllText(openFileDialogCSS.FileName);
            ToolStripButtonRefresh_Click(sender, e);
        }

        private void ToolStripButtonNew_Click(object sender, EventArgs e)
        {
            var result = false;
            if (HasChanged())
            {
                var question = MessageBox.Show(Messages.ConfirmSave, Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (question)
                {
                    case DialogResult.None:
                    case DialogResult.Abort:
                    case DialogResult.Cancel:
                        return;

                    case DialogResult.OK:
                    case DialogResult.Yes:
                        if (string.IsNullOrEmpty(FileName))
                            ToolStripButtonSaveAs_Click(sender, e);
                        else
                            ToolStripButtonSave_Click(sender, e);
                        result = true;
                        break;

                    default:
                        result = true;
                        break;
                }
            }
            else
                result = true;

            if (result)
            {
                FileName = string.Empty;
                FileContent = string.Empty;
                textBoxMarkDown.Text = string.Empty;
                webBrowserMarkdownPreview.DocumentText = string.Empty;
            }
        }

        private void ToolStripButtonOpen_Click(object sender, EventArgs e)
        {
            if (HasChanged())
            {
                var question = MessageBox.Show(Messages.ConfirmSave, Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (question)
                {
                    case DialogResult.None:
                    case DialogResult.Abort:
                    case DialogResult.Cancel:
                        return;

                    case DialogResult.OK:
                    case DialogResult.Yes:
                        if (string.IsNullOrEmpty(FileName))
                            ToolStripButtonSaveAs_Click(sender, e);
                        else
                            ToolStripButtonSave_Click(sender, e);
                        break;

                    default:
                        break;
                }
            }
            openFileDialogOpen.ShowDialog();
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveAs.FileName = FileName;
            if (string.IsNullOrEmpty(FileName))
                ToolStripButtonSaveAs_Click(sender, e);
            else
                SaveFileDialogSaveAs_FileOk(sender, new CancelEventArgs());
        }

        private void ToolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveAs.ShowDialog();
        }

        private void ToolStripButtonExport_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.ShowDialog();
        }

        #region Printing

        private void ToolStripButtonPrint_Click(object sender, EventArgs e)
        {
            webBrowserMarkdownPreview.ShowPrintDialog();
        }

        private void ToolStripButtonPageSettings_Click(object sender, EventArgs e)
        {
            pageSetupDialogMain.ShowDialog();
        }

        #endregion Printing

        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            var body = Markdig.Markdown.ToHtml(textBoxMarkDown.Text);
            var style = $"<style>* {{ font-family: '{textBoxMarkDown.Font.FontFamily.Name}';}}</style>";
            if (!string.IsNullOrEmpty(StyleSheet))
                style = $"<style>{StyleSheet}</style>";

            var html = $"<!DOCTYPE html><html><head><title>{FileName}</title>{style}</head><body>{body}</body></html>";

            webBrowserMarkdownPreview.DocumentText = html.ToString();
        }

        private void ToolStripButtonStyle_Click(object sender, EventArgs e)
        {
            openFileDialogCSS.ShowDialog();
        }

        private void TextBoxMarkDown_TextChanged(object sender, EventArgs e)
        {
            if (HasAutorefresh())
                ToolStripButtonRefresh_Click(sender, e);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasChanged())
            {
                var question = MessageBox.Show(Messages.ConfirmExit, Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (question)
                {
                    case DialogResult.None:
                    case DialogResult.Abort:
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;

                    case DialogResult.No:
                        saveFileDialogSaveAs.FileName = FileName;
                        if (string.IsNullOrEmpty(FileName))
                            ToolStripButtonSaveAs_Click(sender, e);
                        else
                            ToolStripButtonSave_Click(sender, e);
                        break;

                    default:
                        break;
                }
            }
        }

        #region Clipboard

        private void ToolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            textBoxMarkDown.Cut();
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            textBoxMarkDown.Copy();
        }

        private void ToolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            textBoxMarkDown.Paste();
        }

        #endregion Clipboard

        private void ToolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }

        private void ToolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemSwapDivider_Click(object sender, EventArgs e)
        {
            splitContainerMarkdown.Orientation = toolStripMenuItemSwapDivider.Checked ? Orientation.Horizontal : Orientation.Vertical;
            if (splitContainerMarkdown.Orientation == Orientation.Vertical)
                splitContainerMarkdown.SplitterDistance = (splitContainerMarkdown.Width + splitContainerMarkdown.SplitterWidth) / 2;
            else
                splitContainerMarkdown.SplitterDistance = (splitContainerMarkdown.Height + splitContainerMarkdown.SplitterWidth) / 2;
            Properties.Settings.Default.Save();
        }

        private void ToolStripMenuItemAutoRefresh_Click(object sender, EventArgs e)
        {
            toolStripButtonRefresh.Enabled = !toolStripMenuItemAutoRefresh.Checked;
            toolStripButtonRefresh.Checked = toolStripMenuItemAutoRefresh.Checked;
            Properties.Settings.Default.Save();
        }

        private void ToolStripButtonUpdates_Click(object sender, EventArgs e)
        {
            var checkForUpdates = !toolStripButtonUpdates.Checked;
            toolStripButtonUpdates.Checked = checkForUpdates;
            Properties.Settings.Default.CheckForUpdates = checkForUpdates;
            Properties.Settings.Default.Save();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            toolStripButtonUpdates.Checked = Properties.Settings.Default.CheckForUpdates;

            if (Properties.Settings.Default.CheckForUpdates)
                await GitHubInfo.CheckForUpdateAsync();
        }
    }
}