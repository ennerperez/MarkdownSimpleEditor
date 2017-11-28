using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);

            // Icons
            toolStripButtonNew.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.create, 48, Color.White);
            toolStripButtonOpen.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, Color.White);
            toolStripButtonSave.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, Color.White);
            toolStripButtonPrint.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.print, 48, Color.White);
            toolStripButtonRefresh.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.refresh, 48, Color.White);
            toolStripButtonStyle.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.style, 48, Color.White);

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
        private void saveFileDialogSaveAs_FileOk(object sender, CancelEventArgs e)
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
        private void saveFileDialogExport_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialogExport.FileName, webBrowserMarkdownPreview.DocumentText);
        }
        private void openFileDialogCSS_FileOk(object sender, CancelEventArgs e)
        {
            StyleSheet = File.ReadAllText(openFileDialogCSS.FileName);
            toolStripButtonRefresh_Click(sender, e);
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
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
                            toolStripButtonSaveAs_Click(sender, e);
                        else
                            toolStripButtonSave_Click(sender, e);
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
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
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
                            toolStripButtonSaveAs_Click(sender, e);
                        else
                            toolStripButtonSave_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
            openFileDialogOpen.ShowDialog();
        }
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveAs.FileName = FileName;
            if (string.IsNullOrEmpty(FileName))
                toolStripButtonSaveAs_Click(sender, e);
            else
                saveFileDialogSaveAs_FileOk(sender, new CancelEventArgs());
        }
        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveAs.ShowDialog();
        }
        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.ShowDialog();
        }

        #region Printing

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            webBrowserMarkdownPreview.ShowPrintDialog();
        }
        private void toolStripButtonPageSettings_Click(object sender, EventArgs e)
        {
            pageSetupDialogMain.ShowDialog();
        }

        #endregion

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            var body = Markdig.Markdown.ToHtml(textBoxMarkDown.Text);
            var style = $"<style>* {{ font-family: '{textBoxMarkDown.Font.FontFamily.Name}';}}</style>";
            if (!string.IsNullOrEmpty(StyleSheet))
                style = $"<style>{StyleSheet}</style>";

            var html = $"<!DOCTYPE html><html><head><title>{FileName}</title>{style}</head><body>{body}</body></html>";

            webBrowserMarkdownPreview.DocumentText = html.ToString();
        }
        private void toolStripButtonStyle_Click(object sender, EventArgs e)
        {
            openFileDialogCSS.ShowDialog();
        }

        private void textBoxMarkDown_TextChanged(object sender, EventArgs e)
        {
            if (HasAutorefresh())
                toolStripButtonRefresh_Click(sender, e);
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
                            toolStripButtonSaveAs_Click(sender, e);
                        else
                            toolStripButtonSave_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
        }

        #region Clipboard

        private void toolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            textBoxMarkDown.Cut();
        }
        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            textBoxMarkDown.Copy();
        }
        private void toolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            textBoxMarkDown.Paste();
        }

        #endregion

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }
        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemSwapDivider_Click(object sender, EventArgs e)
        {
            splitContainerMarkdown.Orientation = toolStripMenuItemSwapDivider.Checked ? Orientation.Horizontal : Orientation.Vertical;
            if (splitContainerMarkdown.Orientation == Orientation.Vertical)
                splitContainerMarkdown.SplitterDistance = (splitContainerMarkdown.Width + splitContainerMarkdown.SplitterWidth) / 2;
            else
                splitContainerMarkdown.SplitterDistance = (splitContainerMarkdown.Height + splitContainerMarkdown.SplitterWidth) / 2;
            Properties.Settings.Default.Save();
        }
        private void toolStripMenuItemAutoRefresh_Click(object sender, EventArgs e)
        {
            toolStripButtonRefresh.Enabled = !toolStripMenuItemAutoRefresh.Checked;
            toolStripButtonRefresh.Checked = toolStripMenuItemAutoRefresh.Checked;
            Properties.Settings.Default.Save();
        }

    }
}
