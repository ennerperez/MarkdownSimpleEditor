﻿namespace Toolkit.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerMarkdown = new System.Windows.Forms.SplitContainer();
            this.textBoxMarkDown = new System.Windows.Forms.RichTextBox();
            this.webBrowserMarkdownPreview = new System.Windows.Forms.WebBrowser();
            this.openFileDialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSaveAs = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogCSS = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialogMain = new System.Windows.Forms.PrintDialog();
            this.printDocumentMain = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialogMain = new System.Windows.Forms.PageSetupDialog();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStyle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemSwapDivider = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAutoRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonUpdates = new System.Windows.Forms.ToolStripButton();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.helpProviderMain = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMarkdown)).BeginInit();
            this.splitContainerMarkdown.Panel1.SuspendLayout();
            this.splitContainerMarkdown.Panel2.SuspendLayout();
            this.splitContainerMarkdown.SuspendLayout();
            this.contextMenuStripEdit.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMarkdown
            // 
            this.splitContainerMarkdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.splitContainerMarkdown, "splitContainerMarkdown");
            this.splitContainerMarkdown.Name = "splitContainerMarkdown";
            // 
            // splitContainerMarkdown.Panel1
            // 
            this.splitContainerMarkdown.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainerMarkdown.Panel1.Controls.Add(this.textBoxMarkDown);
            resources.ApplyResources(this.splitContainerMarkdown.Panel1, "splitContainerMarkdown.Panel1");
            // 
            // splitContainerMarkdown.Panel2
            // 
            this.splitContainerMarkdown.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainerMarkdown.Panel2.Controls.Add(this.webBrowserMarkdownPreview);
            resources.ApplyResources(this.splitContainerMarkdown.Panel2, "splitContainerMarkdown.Panel2");
            // 
            // textBoxMarkDown
            // 
            this.textBoxMarkDown.AcceptsTab = true;
            this.textBoxMarkDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxMarkDown, "textBoxMarkDown");
            this.textBoxMarkDown.Name = "textBoxMarkDown";
            this.textBoxMarkDown.TextChanged += new System.EventHandler(this.TextBoxMarkDown_TextChanged);
            // 
            // webBrowserMarkdownPreview
            // 
            resources.ApplyResources(this.webBrowserMarkdownPreview, "webBrowserMarkdownPreview");
            this.webBrowserMarkdownPreview.Name = "webBrowserMarkdownPreview";
            // 
            // openFileDialogOpen
            // 
            this.openFileDialogOpen.DefaultExt = "md";
            resources.ApplyResources(this.openFileDialogOpen, "openFileDialogOpen");
            this.openFileDialogOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogOpen_FileOk);
            // 
            // saveFileDialogSaveAs
            // 
            this.saveFileDialogSaveAs.DefaultExt = "md";
            resources.ApplyResources(this.saveFileDialogSaveAs, "saveFileDialogSaveAs");
            this.saveFileDialogSaveAs.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialogSaveAs_FileOk);
            // 
            // openFileDialogCSS
            // 
            this.openFileDialogCSS.DefaultExt = "css";
            resources.ApplyResources(this.openFileDialogCSS, "openFileDialogCSS");
            this.openFileDialogCSS.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogCSS_FileOk);
            // 
            // contextMenuStripEdit
            // 
            this.contextMenuStripEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStripEdit.Name = "contextMenuStripEdit";
            resources.ApplyResources(this.contextMenuStripEdit, "contextMenuStripEdit");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItemCut_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItemPaste_Click);
            // 
            // printDialogMain
            // 
            this.printDialogMain.Document = this.printDocumentMain;
            this.printDialogMain.UseEXDialog = true;
            // 
            // printDocumentMain
            // 
            this.printDocumentMain.DocumentName = "";
            // 
            // pageSetupDialogMain
            // 
            this.pageSetupDialogMain.Document = this.printDocumentMain;
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.DefaultExt = "html";
            resources.ApplyResources(this.saveFileDialogExport, "saveFileDialogExport");
            this.saveFileDialogExport.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialogExport_FileOk);
            // 
            // toolStripMenu
            // 
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toolStripMenu.CanOverflow = false;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClose,
            this.toolStripButtonAbout,
            this.toolStripButtonFile,
            this.toolStripButtonPrint,
            this.toolStripSeparator8,
            this.toolStripButtonRefresh,
            this.toolStripSeparator9,
            this.toolStripButtonStyle,
            this.toolStripButtonSettings,
            this.toolStripButtonUpdates});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonClose, "toolStripButtonClose");
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Click += new System.EventHandler(this.ToolStripButtonExit_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAbout_Click);
            // 
            // toolStripButtonFile
            // 
            resources.ApplyResources(this.toolStripButtonFile, "toolStripButtonFile");
            this.toolStripButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem});
            this.toolStripButtonFile.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonFile.Name = "toolStripButtonFile";
            this.toolStripButtonFile.ShowDropDownArrow = false;
            // 
            // newToolStripMenuItem
            // 
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButtonNew_Click);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButtonPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButtonExport_Click);
            // 
            // toolStripButtonPrint
            // 
            resources.ApplyResources(this.toolStripButtonPrint, "toolStripButtonPrint");
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.ToolStripButtonPrint_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // toolStripButtonRefresh
            // 
            resources.ApplyResources(this.toolStripButtonRefresh, "toolStripButtonRefresh");
            this.toolStripButtonRefresh.Checked = true;
            this.toolStripButtonRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.ToolStripButtonRefresh_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // toolStripButtonStyle
            // 
            resources.ApplyResources(this.toolStripButtonStyle, "toolStripButtonStyle");
            this.toolStripButtonStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStyle.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonStyle.Name = "toolStripButtonStyle";
            this.toolStripButtonStyle.Click += new System.EventHandler(this.ToolStripButtonStyle_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonSettings, "toolStripButtonSettings");
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSwapDivider,
            this.toolStripMenuItemAutoRefresh});
            this.toolStripButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.ShowDropDownArrow = false;
            // 
            // toolStripMenuItemSwapDivider
            // 
            this.toolStripMenuItemSwapDivider.Checked = global::Toolkit.Properties.Settings.Default.SwapOrientation;
            this.toolStripMenuItemSwapDivider.CheckOnClick = true;
            this.toolStripMenuItemSwapDivider.Name = "toolStripMenuItemSwapDivider";
            resources.ApplyResources(this.toolStripMenuItemSwapDivider, "toolStripMenuItemSwapDivider");
            this.toolStripMenuItemSwapDivider.Click += new System.EventHandler(this.ToolStripMenuItemSwapDivider_Click);
            // 
            // toolStripMenuItemAutoRefresh
            // 
            this.toolStripMenuItemAutoRefresh.Checked = global::Toolkit.Properties.Settings.Default.AutoRefresh;
            this.toolStripMenuItemAutoRefresh.CheckOnClick = true;
            this.toolStripMenuItemAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemAutoRefresh.Name = "toolStripMenuItemAutoRefresh";
            resources.ApplyResources(this.toolStripMenuItemAutoRefresh, "toolStripMenuItemAutoRefresh");
            this.toolStripMenuItemAutoRefresh.Click += new System.EventHandler(this.ToolStripMenuItemAutoRefresh_Click);
            // 
            // toolStripButtonUpdates
            // 
            this.toolStripButtonUpdates.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonUpdates, "toolStripButtonUpdates");
            this.toolStripButtonUpdates.Checked = global::Toolkit.Properties.Settings.Default.CheckForUpdates;
            this.toolStripButtonUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonUpdates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdates.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonUpdates.Name = "toolStripButtonUpdates";
            this.toolStripButtonUpdates.Click += new System.EventHandler(this.ToolStripButtonUpdates_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainerMarkdown);
            this.Controls.Add(this.toolStripMenu);
            this.DoubleBuffered = true;
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainerMarkdown.Panel1.ResumeLayout(false);
            this.splitContainerMarkdown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMarkdown)).EndInit();
            this.splitContainerMarkdown.ResumeLayout(false);
            this.contextMenuStripEdit.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogOpen;
        private System.Windows.Forms.SplitContainer splitContainerMarkdown;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveAs;
        private System.Windows.Forms.RichTextBox textBoxMarkDown;
        private System.Windows.Forms.WebBrowser webBrowserMarkdownPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialogCSS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PrintDialog printDialogMain;
        private System.Drawing.Printing.PrintDocument printDocumentMain;
        private System.Windows.Forms.PageSetupDialog pageSetupDialogMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonStyle;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSwapDivider;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAutoRefresh;
        private System.Windows.Forms.HelpProvider helpProviderMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdates;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}

