namespace IMGProc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.duplikujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyrownajItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sredMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.losowaItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.neighItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ownItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeJednopunktoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImg = new System.Windows.Forms.OpenFileDialog();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.obrazItemMenu});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(618, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "menuStrip1";
            this.topMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.topMenu_ItemClicked);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Image = global::IMGProc.Properties.Resources.open_image;
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // obrazItemMenu
            // 
            this.obrazItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramItemMenu,
            this.duplikujToolStripMenuItem,
            this.wyrownajItemMenu,
            this.operacjeJednopunktoweToolStripMenuItem});
            this.obrazItemMenu.Name = "obrazItemMenu";
            this.obrazItemMenu.Size = new System.Drawing.Size(50, 20);
            this.obrazItemMenu.Text = "Obraz";
            // 
            // histogramItemMenu
            // 
            this.histogramItemMenu.Enabled = false;
            this.histogramItemMenu.Name = "histogramItemMenu";
            this.histogramItemMenu.Size = new System.Drawing.Size(207, 22);
            this.histogramItemMenu.Text = "Histogram";
            this.histogramItemMenu.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // duplikujToolStripMenuItem
            // 
            this.duplikujToolStripMenuItem.Name = "duplikujToolStripMenuItem";
            this.duplikujToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.duplikujToolStripMenuItem.Text = "Duplikuj";
            this.duplikujToolStripMenuItem.Click += new System.EventHandler(this.duplikujToolStripMenuItem_Click);
            // 
            // wyrownajItemMenu
            // 
            this.wyrownajItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sredMenuItem,
            this.losowaItemMenu,
            this.neighItemMenu,
            this.ownItemMenu});
            this.wyrownajItemMenu.Name = "wyrownajItemMenu";
            this.wyrownajItemMenu.Size = new System.Drawing.Size(207, 22);
            this.wyrownajItemMenu.Text = "Wyrównaj";
            // 
            // sredMenuItem
            // 
            this.sredMenuItem.Name = "sredMenuItem";
            this.sredMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sredMenuItem.Text = "Średnia";
            this.sredMenuItem.Click += new System.EventHandler(this.sredMenuItem_Click);
            // 
            // losowaItemMenu
            // 
            this.losowaItemMenu.Name = "losowaItemMenu";
            this.losowaItemMenu.Size = new System.Drawing.Size(131, 22);
            this.losowaItemMenu.Text = "Losowa";
            this.losowaItemMenu.Click += new System.EventHandler(this.losowaItemMenu_Click);
            // 
            // neighItemMenu
            // 
            this.neighItemMenu.Name = "neighItemMenu";
            this.neighItemMenu.Size = new System.Drawing.Size(131, 22);
            this.neighItemMenu.Text = "Sąsiedztwa";
            this.neighItemMenu.Click += new System.EventHandler(this.neighItemMenu_Click);
            // 
            // ownItemMenu
            // 
            this.ownItemMenu.Name = "ownItemMenu";
            this.ownItemMenu.Size = new System.Drawing.Size(131, 22);
            this.ownItemMenu.Text = "Własna";
            this.ownItemMenu.Click += new System.EventHandler(this.ownItemMenu_Click);
            // 
            // operacjeJednopunktoweToolStripMenuItem
            // 
            this.operacjeJednopunktoweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negacjaToolStripMenuItem,
            this.progowanieToolStripMenuItem});
            this.operacjeJednopunktoweToolStripMenuItem.Name = "operacjeJednopunktoweToolStripMenuItem";
            this.operacjeJednopunktoweToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.operacjeJednopunktoweToolStripMenuItem.Text = "Operacje jednopunktowe";
            // 
            // negacjaToolStripMenuItem
            // 
            this.negacjaToolStripMenuItem.Name = "negacjaToolStripMenuItem";
            this.negacjaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.negacjaToolStripMenuItem.Text = "Negacja";
            this.negacjaToolStripMenuItem.Click += new System.EventHandler(this.negacjaToolStripMenuItem_Click);
            // 
            // progowanieToolStripMenuItem
            // 
            this.progowanieToolStripMenuItem.Name = "progowanieToolStripMenuItem";
            this.progowanieToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.progowanieToolStripMenuItem.Text = "Progowanie";
            this.progowanieToolStripMenuItem.Click += new System.EventHandler(this.progowanieToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 321);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainForm";
            this.Text = "IMGProcessor";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImg;
        private System.Windows.Forms.ToolStripMenuItem obrazItemMenu;
        private System.Windows.Forms.ToolStripMenuItem histogramItemMenu;
        private System.Windows.Forms.ToolStripMenuItem wyrownajItemMenu;
        private System.Windows.Forms.ToolStripMenuItem sredMenuItem;
        private System.Windows.Forms.ToolStripMenuItem losowaItemMenu;
        private System.Windows.Forms.ToolStripMenuItem neighItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ownItemMenu;
        private System.Windows.Forms.ToolStripMenuItem operacjeJednopunktoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplikujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progowanieToolStripMenuItem;
    }
}

