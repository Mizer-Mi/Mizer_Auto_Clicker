namespace AutoClicker_Mizer1
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
            this.hangi_tus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baslat_tusu_label = new System.Windows.Forms.Label();
            this.kapat_tusu_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mssuresi = new System.Windows.Forms.ComboBox();
            this.Mizer_Saati = new System.Windows.Forms.Timer(this.components);
            this.Ayarlar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.durum = new System.Windows.Forms.Label();
            this.etkin_Devredisi_label = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hangi_tus
            // 
            this.hangi_tus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hangi_tus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.hangi_tus.FormattingEnabled = true;
            this.hangi_tus.Items.AddRange(new object[] {
            "Sol Tık",
            "Sağ Tık"});
            this.hangi_tus.Location = new System.Drawing.Point(174, 40);
            this.hangi_tus.Name = "hangi_tus";
            this.hangi_tus.Size = new System.Drawing.Size(165, 28);
            this.hangi_tus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hangi Tuş Tekrarlansın:";
            // 
            // baslat_tusu_label
            // 
            this.baslat_tusu_label.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslat_tusu_label.Location = new System.Drawing.Point(345, 9);
            this.baslat_tusu_label.Name = "baslat_tusu_label";
            this.baslat_tusu_label.Size = new System.Drawing.Size(162, 59);
            this.baslat_tusu_label.TabIndex = 3;
            this.baslat_tusu_label.Text = "F3 \r\nile Başlatırsın";
            this.baslat_tusu_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baslat_tusu_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // kapat_tusu_label
            // 
            this.kapat_tusu_label.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kapat_tusu_label.Location = new System.Drawing.Point(496, 9);
            this.kapat_tusu_label.Name = "kapat_tusu_label";
            this.kapat_tusu_label.Size = new System.Drawing.Size(156, 56);
            this.kapat_tusu_label.TabIndex = 4;
            this.kapat_tusu_label.Text = "F4 \r\nile Kapatırsın";
            this.kapat_tusu_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aralık Kaç MS Olsun:";
            // 
            // mssuresi
            // 
            this.mssuresi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mssuresi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.mssuresi.FormattingEnabled = true;
            this.mssuresi.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.mssuresi.Location = new System.Drawing.Point(174, 73);
            this.mssuresi.Name = "mssuresi";
            this.mssuresi.Size = new System.Drawing.Size(165, 28);
            this.mssuresi.TabIndex = 5;
            this.mssuresi.SelectedIndexChanged += new System.EventHandler(this.mssuresi_SelectedIndexChanged);
            // 
            // Mizer_Saati
            // 
            this.Mizer_Saati.Tick += new System.EventHandler(this.Mizer_Saati_Tick);
            // 
            // Ayarlar
            // 
            this.Ayarlar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Ayarlar.Location = new System.Drawing.Point(174, 107);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Size = new System.Drawing.Size(88, 31);
            this.Ayarlar.TabIndex = 7;
            this.Ayarlar.Text = "Ayarlar";
            this.Ayarlar.UseVisualStyleBackColor = true;
            this.Ayarlar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Copyright Mizer 2020";
            // 
            // durum
            // 
            this.durum.Font = new System.Drawing.Font("Minion Pro", 15.75F);
            this.durum.Location = new System.Drawing.Point(12, 9);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(360, 28);
            this.durum.TabIndex = 9;
            this.durum.Text = "Durum: Beklemede";
            this.durum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // etkin_Devredisi_label
            // 
            this.etkin_Devredisi_label.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etkin_Devredisi_label.Location = new System.Drawing.Point(345, 93);
            this.etkin_Devredisi_label.Name = "etkin_Devredisi_label";
            this.etkin_Devredisi_label.Size = new System.Drawing.Size(307, 58);
            this.etkin_Devredisi_label.TabIndex = 10;
            this.etkin_Devredisi_label.Text = "F4 \r\nile Etkin-Devredışı yapabilirsin";
            this.etkin_Devredisi_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Mizer Auto Clicker Arkada Çalışıyor";
            this.notifyIcon1.BalloonTipTitle = "Mizer Auto Clicker";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Mizer Auto Clicker";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(655, 163);
            this.Controls.Add(this.etkin_Devredisi_label);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ayarlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mssuresi);
            this.Controls.Add(this.kapat_tusu_label);
            this.Controls.Add(this.baslat_tusu_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hangi_tus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mizer Auto Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox hangi_tus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label baslat_tusu_label;
        private System.Windows.Forms.Label kapat_tusu_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mssuresi;
        private System.Windows.Forms.Timer Mizer_Saati;
        private System.Windows.Forms.Button Ayarlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label durum;
        private System.Windows.Forms.Label etkin_Devredisi_label;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
    }
}

