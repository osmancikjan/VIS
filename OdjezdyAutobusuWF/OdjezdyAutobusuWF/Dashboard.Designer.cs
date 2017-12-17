namespace OdjezdyAutobusuWF
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zastávkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatZpožděníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováZastávkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitZastávkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uživateléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odebratToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zálohovatDoXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zastávkyToolStripMenuItem,
            this.uživateléToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zastávkyToolStripMenuItem
            // 
            this.zastávkyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatZpožděníToolStripMenuItem,
            this.nováZastávkaToolStripMenuItem,
            this.upravitZastávkuToolStripMenuItem});
            this.zastávkyToolStripMenuItem.Name = "zastávkyToolStripMenuItem";
            this.zastávkyToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.zastávkyToolStripMenuItem.Text = "Zastávky";
            // 
            // přidatZpožděníToolStripMenuItem
            // 
            this.přidatZpožděníToolStripMenuItem.Name = "přidatZpožděníToolStripMenuItem";
            this.přidatZpožděníToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.přidatZpožděníToolStripMenuItem.Text = "Zpoždění";
            this.přidatZpožděníToolStripMenuItem.Click += new System.EventHandler(this.přidatZpožděníToolStripMenuItem_Click);
            // 
            // nováZastávkaToolStripMenuItem
            // 
            this.nováZastávkaToolStripMenuItem.Name = "nováZastávkaToolStripMenuItem";
            this.nováZastávkaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nováZastávkaToolStripMenuItem.Text = "Nová zastávka";
            this.nováZastávkaToolStripMenuItem.Click += new System.EventHandler(this.nováZastávkaToolStripMenuItem_Click);
            // 
            // upravitZastávkuToolStripMenuItem
            // 
            this.upravitZastávkuToolStripMenuItem.Name = "upravitZastávkuToolStripMenuItem";
            this.upravitZastávkuToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.upravitZastávkuToolStripMenuItem.Text = "Upravit zastávku";
            this.upravitZastávkuToolStripMenuItem.Click += new System.EventHandler(this.upravitZastávkuToolStripMenuItem_Click);
            // 
            // uživateléToolStripMenuItem
            // 
            this.uživateléToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatToolStripMenuItem1,
            this.upravitToolStripMenuItem1,
            this.odebratToolStripMenuItem1});
            this.uživateléToolStripMenuItem.Name = "uživateléToolStripMenuItem";
            this.uživateléToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.uživateléToolStripMenuItem.Text = "Uživatelé";
            // 
            // přidatToolStripMenuItem1
            // 
            this.přidatToolStripMenuItem1.Name = "přidatToolStripMenuItem1";
            this.přidatToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.přidatToolStripMenuItem1.Text = "Přidat";
            this.přidatToolStripMenuItem1.Click += new System.EventHandler(this.přidatToolStripMenuItem1_Click);
            // 
            // upravitToolStripMenuItem1
            // 
            this.upravitToolStripMenuItem1.Name = "upravitToolStripMenuItem1";
            this.upravitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.upravitToolStripMenuItem1.Text = "Upravit";
            this.upravitToolStripMenuItem1.Click += new System.EventHandler(this.upravitToolStripMenuItem1_Click);
            // 
            // odebratToolStripMenuItem1
            // 
            this.odebratToolStripMenuItem1.Name = "odebratToolStripMenuItem1";
            this.odebratToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.odebratToolStripMenuItem1.Text = "Odebrat";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zálohovatDoXMLToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Záloha";
            // 
            // zálohovatDoXMLToolStripMenuItem
            // 
            this.zálohovatDoXMLToolStripMenuItem.Name = "zálohovatDoXMLToolStripMenuItem";
            this.zálohovatDoXMLToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zálohovatDoXMLToolStripMenuItem.Text = "Zálohovat do XML";
            this.zálohovatDoXMLToolStripMenuItem.Click += new System.EventHandler(this.zálohovatDoXMLToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(824, 437);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(748, 1);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Obnovit";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 463);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zastávkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatZpožděníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nováZastávkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravitZastávkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uživateléToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem upravitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odebratToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zálohovatDoXMLToolStripMenuItem;
        private System.Windows.Forms.Button refresh;
    }
}