namespace BlogProjesi
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniBlogGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMain = new System.Windows.Forms.ToolStrip();
            this.btnBlogKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnBlogKapat = new System.Windows.Forms.ToolStripButton();
            this.btnYeniBlog = new System.Windows.Forms.ToolStripButton();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblAktifBlogTarihi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAktifBlogSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrSaniye = new System.Windows.Forms.Timer(this.components);
            this.menuMain.SuspendLayout();
            this.toolbarMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yeniBlogGirişiToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(836, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blogKaydetToolStripMenuItem,
            this.blogKapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // blogKaydetToolStripMenuItem
            // 
            this.blogKaydetToolStripMenuItem.Name = "blogKaydetToolStripMenuItem";
            this.blogKaydetToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.blogKaydetToolStripMenuItem.Text = "Blog Kaydet";
            this.blogKaydetToolStripMenuItem.Click += new System.EventHandler(this.BlogKaydet_Click);
            // 
            // blogKapatToolStripMenuItem
            // 
            this.blogKapatToolStripMenuItem.Name = "blogKapatToolStripMenuItem";
            this.blogKapatToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.blogKapatToolStripMenuItem.Text = "Blog Kapat";
            this.blogKapatToolStripMenuItem.Click += new System.EventHandler(this.BlogKapat_Click);
            // 
            // yeniBlogGirişiToolStripMenuItem
            // 
            this.yeniBlogGirişiToolStripMenuItem.Name = "yeniBlogGirişiToolStripMenuItem";
            this.yeniBlogGirişiToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.yeniBlogGirişiToolStripMenuItem.Text = "Yeni Blog Girişi";
            this.yeniBlogGirişiToolStripMenuItem.Click += new System.EventHandler(this.YeniBlog_Click);
            // 
            // toolbarMain
            // 
            this.toolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBlogKaydet,
            this.btnBlogKapat,
            this.btnYeniBlog});
            this.toolbarMain.Location = new System.Drawing.Point(0, 24);
            this.toolbarMain.Name = "toolbarMain";
            this.toolbarMain.Size = new System.Drawing.Size(836, 25);
            this.toolbarMain.TabIndex = 2;
            this.toolbarMain.Text = "toolStrip1";
            // 
            // btnBlogKaydet
            // 
            this.btnBlogKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnBlogKaydet.Image")));
            this.btnBlogKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlogKaydet.Name = "btnBlogKaydet";
            this.btnBlogKaydet.Size = new System.Drawing.Size(90, 22);
            this.btnBlogKaydet.Text = "Blog Kaydet";
            this.btnBlogKaydet.Click += new System.EventHandler(this.BlogKaydet_Click);
            // 
            // btnBlogKapat
            // 
            this.btnBlogKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnBlogKapat.Image")));
            this.btnBlogKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlogKapat.Name = "btnBlogKapat";
            this.btnBlogKapat.Size = new System.Drawing.Size(84, 22);
            this.btnBlogKapat.Text = "Blog Kapat";
            this.btnBlogKapat.Click += new System.EventHandler(this.BlogKapat_Click);
            // 
            // btnYeniBlog
            // 
            this.btnYeniBlog.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniBlog.Image")));
            this.btnYeniBlog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniBlog.Name = "btnYeniBlog";
            this.btnYeniBlog.Size = new System.Drawing.Size(132, 22);
            this.btnYeniBlog.Text = "Yeni Blog Sayfası Aç";
            this.btnYeniBlog.Click += new System.EventHandler(this.YeniBlog_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAktifBlogTarihi,
            this.lblAktifBlogSayisi,
            this.lblSaat});
            this.statusMain.Location = new System.Drawing.Point(0, 543);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(836, 22);
            this.statusMain.TabIndex = 3;
            this.statusMain.Text = "statusStrip1";
            // 
            // lblAktifBlogTarihi
            // 
            this.lblAktifBlogTarihi.Name = "lblAktifBlogTarihi";
            this.lblAktifBlogTarihi.Size = new System.Drawing.Size(0, 17);
            // 
            // lblAktifBlogSayisi
            // 
            this.lblAktifBlogSayisi.Name = "lblAktifBlogSayisi";
            this.lblAktifBlogSayisi.Size = new System.Drawing.Size(0, 17);
            // 
            // lblSaat
            // 
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrSaniye
            // 
            this.tmrSaniye.Interval = 1000;
            this.tmrSaniye.Tick += new System.EventHandler(this.tmrSaniye_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 565);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolbarMain);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = " Blog Projesi";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolbarMain.ResumeLayout(false);
            this.toolbarMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStrip toolbarMain;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnBlogKaydet;
        private System.Windows.Forms.ToolStripButton btnBlogKapat;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel lblAktifBlogTarihi;
        private System.Windows.Forms.ToolStripMenuItem yeniBlogGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnYeniBlog;
        private System.Windows.Forms.ToolStripStatusLabel lblAktifBlogSayisi;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.Timer tmrSaniye;
    }
}

