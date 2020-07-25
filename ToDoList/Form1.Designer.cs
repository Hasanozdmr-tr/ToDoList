namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.btnDuzelt = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYardim = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuzelt = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHakkımda = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUygulamaHakkımda = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.txtYeniGorev = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbYapilacaklarListesi = new System.Windows.Forms.CheckedListBox();
            this.lblYapilacaklarListesi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpYeniGorev = new System.Windows.Forms.GroupBox();
            this.lstTamamlananlarListesi = new System.Windows.Forms.ListBox();
            this.lblTamamlananlarListesi = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpYeniGorev.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.btnDuzelt,
            this.btnSil,
            this.toolStripSeparator,
            this.btnKes,
            this.btnKopyala,
            this.btnYapistir,
            this.toolStripSeparator1,
            this.btnYardim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(996, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnYeni
            // 
            this.btnYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeni.Image = global::ToDoList.Properties.Resources.iconfinder_plus_circle_1608431;
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(29, 24);
            this.btnYeni.Text = "Yeni Görev";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuzelt.Image = global::ToDoList.Properties.Resources.new_message_128;
            this.btnDuzelt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(29, 24);
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = global::ToDoList.Properties.Resources.iconfinder_cross_24_103181;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(29, 24);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = ((System.Drawing.Image)(resources.GetObject("btnKes.Image")));
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(29, 24);
            this.btnKes.Text = "Kes";
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(29, 24);
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapistir.Image = ((System.Drawing.Image)(resources.GetObject("btnYapistir.Image")));
            this.btnYapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(29, 24);
            this.btnYapistir.Text = "Yapıştır";
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnYardim
            // 
            this.btnYardim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYardim.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.Image")));
            this.btnYardim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(29, 24);
            this.btnYardim.Text = "Yardım";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuToDo,
            this.mnuHakkımda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(64, 24);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuCikis
            // 
            this.mnuCikis.Image = global::ToDoList.Properties.Resources.iconfinder_22_171495;
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(122, 26);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // mnuToDo
            // 
            this.mnuToDo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeni,
            this.mnuDuzelt,
            this.MnuSil});
            this.mnuToDo.Name = "mnuToDo";
            this.mnuToDo.Size = new System.Drawing.Size(59, 24);
            this.mnuToDo.Text = "ToDo";
            // 
            // mnuYeni
            // 
            this.mnuYeni.Image = global::ToDoList.Properties.Resources.iconfinder_plus_circle_1608431;
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuYeni.Size = new System.Drawing.Size(185, 26);
            this.mnuYeni.Text = "Yeni";
            this.mnuYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // mnuDuzelt
            // 
            this.mnuDuzelt.Image = global::ToDoList.Properties.Resources.new_message_128;
            this.mnuDuzelt.Name = "mnuDuzelt";
            this.mnuDuzelt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuDuzelt.Size = new System.Drawing.Size(185, 26);
            this.mnuDuzelt.Text = "Düzelt";
            this.mnuDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // MnuSil
            // 
            this.MnuSil.Image = global::ToDoList.Properties.Resources.iconfinder_cross_24_103181;
            this.MnuSil.Name = "MnuSil";
            this.MnuSil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MnuSil.Size = new System.Drawing.Size(185, 26);
            this.MnuSil.Text = "Sil";
            this.MnuSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // mnuHakkımda
            // 
            this.mnuHakkımda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUygulamaHakkımda,
            this.MnuYardım});
            this.mnuHakkımda.Name = "mnuHakkımda";
            this.mnuHakkımda.Size = new System.Drawing.Size(90, 24);
            this.mnuHakkımda.Text = "Hakkımda";
            // 
            // MnuUygulamaHakkımda
            // 
            this.MnuUygulamaHakkımda.Image = global::ToDoList.Properties.Resources.iconfinder_circle_more_detail_glyph_763454;
            this.MnuUygulamaHakkımda.Name = "MnuUygulamaHakkımda";
            this.MnuUygulamaHakkımda.Size = new System.Drawing.Size(225, 26);
            this.MnuUygulamaHakkımda.Text = "Uygulama Hakkında";
            this.MnuUygulamaHakkımda.Click += new System.EventHandler(this.MnuUygulamaHakkımda_Click);
            // 
            // MnuYardım
            // 
            this.MnuYardım.Image = global::ToDoList.Properties.Resources.iconfinder_175_Information_183524;
            this.MnuYardım.Name = "MnuYardım";
            this.MnuYardım.Size = new System.Drawing.Size(225, 26);
            this.MnuYardım.Text = "Yardım";
            // 
            // txtYeniGorev
            // 
            this.txtYeniGorev.Location = new System.Drawing.Point(91, 43);
            this.txtYeniGorev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYeniGorev.MaxLength = 120;
            this.txtYeniGorev.Multiline = true;
            this.txtYeniGorev.Name = "txtYeniGorev";
            this.txtYeniGorev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtYeniGorev.Size = new System.Drawing.Size(184, 42);
            this.txtYeniGorev.TabIndex = 2;
            this.txtYeniGorev.Text = "sdadfasfdasgsdgdfhfghfgjhgjghjkfasdfsdgfsdghf";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 80);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.grpYeniGorev);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstTamamlananlarListesi);
            this.splitContainer1.Panel2.Controls.Add(this.lblTamamlananlarListesi);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.splitContainer1.Size = new System.Drawing.Size(972, 554);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.TabIndex = 3;
            // 
            // clbYapilacaklarListesi
            // 
            this.clbYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbYapilacaklarListesi.FormattingEnabled = true;
            this.clbYapilacaklarListesi.Location = new System.Drawing.Point(4, 164);
            this.clbYapilacaklarListesi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clbYapilacaklarListesi.Name = "clbYapilacaklarListesi";
            this.clbYapilacaklarListesi.Size = new System.Drawing.Size(458, 384);
            this.clbYapilacaklarListesi.TabIndex = 4;
            this.clbYapilacaklarListesi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbYapilacaklarListesi_ItemCheck);
            this.clbYapilacaklarListesi.SelectedIndexChanged += new System.EventHandler(this.clbYapilacaklarListesi_SelectedIndexChanged);
            this.clbYapilacaklarListesi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clbYapilacaklarListesi_MouseUp);
            // 
            // lblYapilacaklarListesi
            // 
            this.lblYapilacaklarListesi.AutoSize = true;
            this.lblYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYapilacaklarListesi.Location = new System.Drawing.Point(4, 134);
            this.lblYapilacaklarListesi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYapilacaklarListesi.Name = "lblYapilacaklarListesi";
            this.lblYapilacaklarListesi.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblYapilacaklarListesi.Size = new System.Drawing.Size(134, 30);
            this.lblYapilacaklarListesi.TabIndex = 1;
            this.lblYapilacaklarListesi.Text = "Yapılacaklar Listesi";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 16);
            this.panel1.TabIndex = 1;
            // 
            // grpYeniGorev
            // 
            this.grpYeniGorev.Controls.Add(this.txtYeniGorev);
            this.grpYeniGorev.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpYeniGorev.Location = new System.Drawing.Point(4, 6);
            this.grpYeniGorev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpYeniGorev.Name = "grpYeniGorev";
            this.grpYeniGorev.Padding = new System.Windows.Forms.Padding(12);
            this.grpYeniGorev.Size = new System.Drawing.Size(458, 112);
            this.grpYeniGorev.TabIndex = 0;
            this.grpYeniGorev.TabStop = false;
            this.grpYeniGorev.Text = "Yeni Görev";
            // 
            // lstTamamlananlarListesi
            // 
            this.lstTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTamamlananlarListesi.FormattingEnabled = true;
            this.lstTamamlananlarListesi.ItemHeight = 18;
            this.lstTamamlananlarListesi.Location = new System.Drawing.Point(4, 36);
            this.lstTamamlananlarListesi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstTamamlananlarListesi.Name = "lstTamamlananlarListesi";
            this.lstTamamlananlarListesi.Size = new System.Drawing.Size(494, 512);
            this.lstTamamlananlarListesi.TabIndex = 3;
            this.lstTamamlananlarListesi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTamamlananlarListesi_MouseDoubleClick);
            this.lstTamamlananlarListesi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstTamamlananlarListesi_MouseUp);
            // 
            // lblTamamlananlarListesi
            // 
            this.lblTamamlananlarListesi.AutoSize = true;
            this.lblTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTamamlananlarListesi.Location = new System.Drawing.Point(4, 6);
            this.lblTamamlananlarListesi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamamlananlarListesi.Name = "lblTamamlananlarListesi";
            this.lblTamamlananlarListesi.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblTamamlananlarListesi.Size = new System.Drawing.Size(160, 30);
            this.lblTamamlananlarListesi.TabIndex = 2;
            this.lblTamamlananlarListesi.Text = "Tamamlananlar Listesi";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Bilgilendirme";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ToDoList";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 647);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpYeniGorev.ResumeLayout(false);
            this.grpYeniGorev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStripButton btnDuzelt;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnYardim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.ToolStripMenuItem mnuToDo;
        private System.Windows.Forms.ToolStripMenuItem mnuYeni;
        private System.Windows.Forms.ToolStripMenuItem mnuDuzelt;
        private System.Windows.Forms.ToolStripMenuItem MnuSil;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkımda;
        private System.Windows.Forms.ToolStripMenuItem MnuUygulamaHakkımda;
        private System.Windows.Forms.ToolStripMenuItem MnuYardım;
        private System.Windows.Forms.TextBox txtYeniGorev;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox clbYapilacaklarListesi;
        private System.Windows.Forms.Label lblYapilacaklarListesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpYeniGorev;
        private System.Windows.Forms.ListBox lstTamamlananlarListesi;
        private System.Windows.Forms.Label lblTamamlananlarListesi;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

