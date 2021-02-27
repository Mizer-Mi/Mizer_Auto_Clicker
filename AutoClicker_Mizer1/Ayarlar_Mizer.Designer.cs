namespace AutoClicker_Mizer1
{
    partial class Ayarlar_Mizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar_Mizer));
            this.mizer_Hangitus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mizer_ms = new System.Windows.Forms.ComboBox();
            this.Mizer_Saati = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.mizer_arkaplan = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mizer_Etkin = new System.Windows.Forms.TextBox();
            this.mizer_kapat = new System.Windows.Forms.TextBox();
            this.mizer_Baslat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mizer_Hangitus
            // 
            this.mizer_Hangitus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mizer_Hangitus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.mizer_Hangitus.FormattingEnabled = true;
            this.mizer_Hangitus.Items.AddRange(new object[] {
            "Sol Tık",
            "Sağ Tık"});
            this.mizer_Hangitus.Location = new System.Drawing.Point(183, 44);
            this.mizer_Hangitus.Name = "mizer_Hangitus";
            this.mizer_Hangitus.Size = new System.Drawing.Size(165, 28);
            this.mizer_Hangitus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hangi Tuş Tekrarlansın:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kaç MS Olsun:";
            // 
            // mizer_ms
            // 
            this.mizer_ms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mizer_ms.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.mizer_ms.FormattingEnabled = true;
            this.mizer_ms.Items.AddRange(new object[] {
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
            this.mizer_ms.Location = new System.Drawing.Point(183, 78);
            this.mizer_ms.Name = "mizer_ms";
            this.mizer_ms.Size = new System.Drawing.Size(165, 28);
            this.mizer_ms.TabIndex = 5;
            // 
            // Mizer_Saati
            // 
            this.Mizer_Saati.Tick += new System.EventHandler(this.Mizer_Saati_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Varsayılan Ayarlar";
            // 
            // mizer_arkaplan
            // 
            this.mizer_arkaplan.AutoSize = true;
            this.mizer_arkaplan.Location = new System.Drawing.Point(226, 223);
            this.mizer_arkaplan.Name = "mizer_arkaplan";
            this.mizer_arkaplan.Size = new System.Drawing.Size(122, 17);
            this.mizer_arkaplan.TabIndex = 8;
            this.mizer_arkaplan.Text = "Arka Planda Çalışsın";
            this.mizer_arkaplan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kapatma Tuşu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Başlatma Tuşu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Etkin-Devre Dışı Tuşu:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(129, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mizer_Etkin
            // 
            this.mizer_Etkin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.mizer_Etkin.Location = new System.Drawing.Point(183, 191);
            this.mizer_Etkin.Name = "mizer_Etkin";
            this.mizer_Etkin.ShortcutsEnabled = false;
            this.mizer_Etkin.Size = new System.Drawing.Size(165, 26);
            this.mizer_Etkin.TabIndex = 16;
            this.mizer_Etkin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mizer_Etkin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.mizer_Etkin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.mizer_Etkin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.mizer_Etkin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Mizer_KeySwap);
            // 
            // mizer_kapat
            // 
            this.mizer_kapat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.mizer_kapat.Location = new System.Drawing.Point(183, 155);
            this.mizer_kapat.Name = "mizer_kapat";
            this.mizer_kapat.ShortcutsEnabled = false;
            this.mizer_kapat.Size = new System.Drawing.Size(165, 26);
            this.mizer_kapat.TabIndex = 17;
            this.mizer_kapat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mizer_kapat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Mizer_KeySwap);
            // 
            // mizer_Baslat
            // 
            this.mizer_Baslat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.mizer_Baslat.Location = new System.Drawing.Point(183, 119);
            this.mizer_Baslat.Name = "mizer_Baslat";
            this.mizer_Baslat.ShortcutsEnabled = false;
            this.mizer_Baslat.Size = new System.Drawing.Size(165, 26);
            this.mizer_Baslat.TabIndex = 18;
            this.mizer_Baslat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mizer_Baslat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Mizer_KeySwap);
            // 
            // Ayarlar_Mizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 302);
            this.Controls.Add(this.mizer_Baslat);
            this.Controls.Add(this.mizer_kapat);
            this.Controls.Add(this.mizer_Etkin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mizer_arkaplan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mizer_ms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mizer_Hangitus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ayarlar_Mizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mizer Auto Clicker - Ayarlar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox mizer_Hangitus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mizer_ms;
        private System.Windows.Forms.Timer Mizer_Saati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox mizer_arkaplan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mizer_Etkin;
        private System.Windows.Forms.TextBox mizer_kapat;
        private System.Windows.Forms.TextBox mizer_Baslat;
    }
}

