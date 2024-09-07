namespace SqlViewer.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            tsbSelect = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tvServer = new TreeView();
            tbContent = new TextBox();
            btnRunQuery = new Button();
            tbQuery = new TextBox();
            tabControl1 = new TabControl();
            tpResults = new TabPage();
            tpMessages = new TabPage();
            dgvResults = new DataGridView();
            tbMessages = new TextBox();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpResults.SuspendLayout();
            tpMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbSelect, tsbSave });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(1344, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbSelect
            // 
            tsbSelect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSelect.Image = (Image)resources.GetObject("tsbSelect.Image");
            tsbSelect.ImageTransparentColor = Color.Magenta;
            tsbSelect.Name = "tsbSelect";
            tsbSelect.Size = new Size(44, 44);
            tsbSelect.Text = "Select";
            tsbSelect.Click += TsbSelect_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(44, 44);
            tsbSave.Text = "Save";
            tsbSave.Click += TsbSave_Click;
            // 
            // tvServer
            // 
            tvServer.Location = new Point(22, 85);
            tvServer.Margin = new Padding(1);
            tvServer.Name = "tvServer";
            tvServer.Size = new Size(262, 553);
            tvServer.TabIndex = 1;
            tvServer.AfterCollapse += TvServer_AfterCollapse;
            tvServer.BeforeExpand += TvServer_BeforeExpand;
            // 
            // tbContent
            // 
            tbContent.Location = new Point(319, 85);
            tbContent.Margin = new Padding(1);
            tbContent.Multiline = true;
            tbContent.Name = "tbContent";
            tbContent.ScrollBars = ScrollBars.Vertical;
            tbContent.Size = new Size(425, 440);
            tbContent.TabIndex = 2;
            // 
            // btnRunQuery
            // 
            btnRunQuery.Location = new Point(1214, 496);
            btnRunQuery.Name = "btnRunQuery";
            btnRunQuery.Size = new Size(94, 29);
            btnRunQuery.TabIndex = 4;
            btnRunQuery.Text = "Run Query";
            btnRunQuery.UseVisualStyleBackColor = true;
            btnRunQuery.Click += btnRunQuery_Click;
            // 
            // tbQuery
            // 
            tbQuery.Location = new Point(792, 98);
            tbQuery.Multiline = true;
            tbQuery.Name = "tbQuery";
            tbQuery.ScrollBars = ScrollBars.Vertical;
            tbQuery.Size = new Size(516, 392);
            tbQuery.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpResults);
            tabControl1.Controls.Add(tpMessages);
            tabControl1.Location = new Point(792, 535);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(516, 202);
            tabControl1.TabIndex = 6;
            // 
            // tpResults
            // 
            tpResults.Controls.Add(dgvResults);
            tpResults.Location = new Point(4, 29);
            tpResults.Name = "tpResults";
            tpResults.Padding = new Padding(3);
            tpResults.Size = new Size(508, 169);
            tpResults.TabIndex = 0;
            tpResults.Text = "Results";
            tpResults.UseVisualStyleBackColor = true;
            // 
            // tpMessages
            // 
            tpMessages.Controls.Add(tbMessages);
            tpMessages.Location = new Point(4, 29);
            tpMessages.Name = "tpMessages";
            tpMessages.Padding = new Padding(3);
            tpMessages.Size = new Size(508, 169);
            tpMessages.TabIndex = 1;
            tpMessages.Text = "Messages";
            tpMessages.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(3, 3);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.RowTemplate.Height = 29;
            dgvResults.Size = new Size(502, 163);
            dgvResults.TabIndex = 0;
            // 
            // tbMessages
            // 
            tbMessages.Location = new Point(3, 6);
            tbMessages.Multiline = true;
            tbMessages.Name = "tbMessages";
            tbMessages.Size = new Size(499, 163);
            tbMessages.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 740);
            Controls.Add(tabControl1);
            Controls.Add(tbQuery);
            Controls.Add(btnRunQuery);
            Controls.Add(tbContent);
            Controls.Add(tvServer);
            Controls.Add(toolStrip1);
            Margin = new Padding(1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSMS";
            FormClosed += MainForm_FormClosed;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpResults.ResumeLayout(false);
            tpMessages.ResumeLayout(false);
            tpMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbSelect;
        private ToolStripButton tsbSave;
        private TreeView tvServer;
        private TextBox tbContent;
        private Button btnRunQuery;
        private TextBox tbQuery;
        private TabControl tabControl1;
        private TabPage tpResults;
        private DataGridView dgvResults;
        private TabPage tpMessages;
        private TextBox tbMessages;
    }
}