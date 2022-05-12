
namespace Diary
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.dataGridViewDates = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.buttonToLeftPanel = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDates)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.dataGridViewDates);
            this.panelLeft.Controls.Add(this.monthCalendarMain);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(166, 388);
            this.panelLeft.TabIndex = 0;
            // 
            // dataGridViewDates
            // 
            this.dataGridViewDates.AllowUserToAddRows = false;
            this.dataGridViewDates.AllowUserToDeleteRows = false;
            this.dataGridViewDates.AllowUserToResizeColumns = false;
            this.dataGridViewDates.AllowUserToResizeRows = false;
            this.dataGridViewDates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDates.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDates.ColumnHeadersVisible = false;
            this.dataGridViewDates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate});
            this.dataGridViewDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDates.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDates.Name = "dataGridViewDates";
            this.dataGridViewDates.ReadOnly = true;
            this.dataGridViewDates.RowHeadersVisible = false;
            this.dataGridViewDates.RowTemplate.Height = 25;
            this.dataGridViewDates.Size = new System.Drawing.Size(164, 224);
            this.dataGridViewDates.TabIndex = 2;
            this.dataGridViewDates.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridViewDates_CellStateChanged);
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // monthCalendarMain
            // 
            this.monthCalendarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.monthCalendarMain.Location = new System.Drawing.Point(0, 224);
            this.monthCalendarMain.MaximumSize = new System.Drawing.Size(164, 162);
            this.monthCalendarMain.MaxSelectionCount = 1;
            this.monthCalendarMain.MinimumSize = new System.Drawing.Size(164, 162);
            this.monthCalendarMain.Name = "monthCalendarMain";
            this.monthCalendarMain.TabIndex = 0;
            this.monthCalendarMain.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMain_DateChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripButtonSave,
            this.toolStripSeparator2,
            this.toolStripButtonInfo});
            this.toolStrip1.Location = new System.Drawing.Point(178, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(622, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "Add date";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfo.Image")));
            this.toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfo.Name = "toolStripButtonInfo";
            this.toolStripButtonInfo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInfo.Text = "Info";
            // 
            // textBoxMain
            // 
            this.textBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMain.Location = new System.Drawing.Point(178, 25);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(622, 363);
            this.textBoxMain.TabIndex = 1;
            // 
            // buttonToLeftPanel
            // 
            this.buttonToLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonToLeftPanel.Location = new System.Drawing.Point(166, 0);
            this.buttonToLeftPanel.Name = "buttonToLeftPanel";
            this.buttonToLeftPanel.Size = new System.Drawing.Size(12, 388);
            this.buttonToLeftPanel.TabIndex = 2;
            this.buttonToLeftPanel.Text = "<";
            this.buttonToLeftPanel.UseVisualStyleBackColor = true;
            this.buttonToLeftPanel.Click += new System.EventHandler(this.buttonToLeftPanel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonToLeftPanel);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Personal Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDates)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.MonthCalendar monthCalendarMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button buttonToLeftPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
    }
}

