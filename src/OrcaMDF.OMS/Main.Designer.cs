using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace OrcaMDF.OMS
{
	partial class Main
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openDatabaseDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeview = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.gridStatus = new System.Windows.Forms.StatusStrip();
			this.gridStatusRows = new System.Windows.Forms.ToolStripStatusLabel();
			this.grid = new System.Windows.Forms.DataGridView();
			this.tableMenu = new System.Windows.Forms.ContextMenuStrip();
			this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.dmvMenu = new System.Windows.Forms.ContextMenuStrip();
			this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.baseTableMenu = new System.Windows.Forms.ContextMenuStrip();
			this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.procedureMenu = new System.Windows.Forms.ContextMenuStrip();
			this.menuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.viewMenu = new System.Windows.Forms.ContextMenuStrip();
			this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.gridStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(648, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.openToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem1
			// 
			this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
			this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
			this.openToolStripMenuItem1.Text = "Open Database...";
			this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// openDatabaseDialog
			// 
			this.openDatabaseDialog.AddExtension = false;
			this.openDatabaseDialog.FileName = "openFileDialog1";
			this.openDatabaseDialog.Filter = "SQL Server data files|*.mdf;*.ndf";
			this.openDatabaseDialog.Multiselect = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.treeview);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 453);
			this.panel1.TabIndex = 3;
			// 
			// treeview
			// 
			this.treeview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeview.Location = new System.Drawing.Point(0, 0);
			this.treeview.Name = "treeview";
			this.treeview.Size = new System.Drawing.Size(200, 453);
			this.treeview.TabIndex = 0;
			this.treeview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeview_MouseUp);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(200, 24);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 453);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtCode);
			this.panel2.Controls.Add(this.gridStatus);
			this.panel2.Controls.Add(this.grid);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(203, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(445, 453);
			this.panel2.TabIndex = 5;
			// 
			// txtCode
			// 
			this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCode.Location = new System.Drawing.Point(0, 0);
			this.txtCode.Multiline = true;
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(445, 431);
			this.txtCode.TabIndex = 2;
			// 
			// gridStatus
			// 
			this.gridStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridStatusRows});
			this.gridStatus.Location = new System.Drawing.Point(0, 431);
			this.gridStatus.Name = "gridStatus";
			this.gridStatus.Size = new System.Drawing.Size(445, 22);
			this.gridStatus.TabIndex = 1;
			this.gridStatus.Text = "statusStrip2";
			// 
			// gridStatusRows
			// 
			this.gridStatusRows.Name = "gridStatusRows";
			this.gridStatusRows.Size = new System.Drawing.Size(0, 17);
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.Size = new System.Drawing.Size(445, 453);
			this.grid.TabIndex = 0;
			// 
			// tableMenu
			// 
			this.tableMenu.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Text = "Select Top 1000 Rows";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// dmvMenu
			// 
			this.dmvMenu.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem2});
			// 
			// menuItem2
			// 
			this.menuItem2.Text = "Select All Rows";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// baseTableMenu
			// 
			this.baseTableMenu.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem3});
			// 
			// menuItem3
			// 
			this.menuItem3.Text = "Select All Rows";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// procedureMenu
			// 
			this.procedureMenu.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem4});
			// 
			// menuItem4
			// 
			this.menuItem4.Text = "View Code";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// viewMenu
			// 
			this.viewMenu.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem5});
			// 
			// menuItem5
			// 
			this.menuItem5.Text = "View Code";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 477);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "OrcaMDF Studio";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.gridStatus.ResumeLayout(false);
			this.gridStatus.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem1;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private OpenFileDialog openDatabaseDialog;
		private Panel panel1;
		private Splitter splitter1;
		private Panel panel2;
		private TreeView treeview;
		private DataGridView grid;
        private ContextMenuStrip tableMenu;
		private ToolStripMenuItem menuItem1;
		private ContextMenuStrip dmvMenu;
		private ToolStripMenuItem menuItem2;
		private ContextMenuStrip baseTableMenu;
		private ToolStripMenuItem menuItem3;
		private StatusStrip gridStatus;
		private ToolStripStatusLabel gridStatusRows;
		private ContextMenuStrip procedureMenu;
		private ToolStripMenuItem menuItem4;
		private TextBox txtCode;
		private ContextMenuStrip viewMenu;
		private ToolStripMenuItem menuItem5;
	}
}

