using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker_Mizer1
{
    public partial class Form1 : Form
    {
        public void CalisiyormuMizer()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) Environment.Exit(0);
        }
    
   


        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        Keys MizerAc = new Keys();
        Keys MizerKapat = new Keys();
        Keys MizerEtkin = new Keys();
        string MizerMS = "";
        Boolean MizerArkaPlan = new Boolean();
        string MizerTik = "";

        public void AyarCek()
        {
            MizerAc = Properties.Settings.Default.D_Baslatma;
            MizerKapat = Properties.Settings.Default.D_Kapatma;
            MizerEtkin = Properties.Settings.Default.D_Etkin_Devre;
            MizerArkaPlan = Properties.Settings.Default.D_Arka_Plan;
            MizerTik = Properties.Settings.Default.D_Hangi_Tus;
            MizerMS = Properties.Settings.Default.D_MS;

            MizerAyarYansit();

        }

        public void MizerAyarYansit()
        {
            baslat_tusu_label.Text =MizerAc.ToString() +Environment.NewLine+"ile Başlatırsın";
            kapat_tusu_label.Text = MizerKapat.ToString() + Environment.NewLine + "ile Kapatırsın";
            etkin_Devredisi_label.Text= MizerEtkin.ToString() + Environment.NewLine + "ile Etkin-Devredışı yapabilirsin";
            hangi_tus.Text = MizerTik;
            mssuresi.Text = MizerMS;
        }



        public Form1()
        {
            InitializeComponent();
          
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
         
        }
        GlobalKeyboardHook gHook = new GlobalKeyboardHook();
        private void Form1_Load(object sender, EventArgs e)
        {
            CalisiyormuMizer();
            hangi_tus.SelectedIndex = 0;
            mssuresi.SelectedIndex = 0;
            AyarCek();
            gHook = new GlobalKeyboardHook(); 
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            // Add the keys you want to hook to the HookedKeys list
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
            gHook.hook();
        }
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (MizerEtkin == (e.KeyCode))
            {
               if(durum.Text == "Durum: Devre Dışı")
                {
                    durum.Text = "Durum: Beklemede";
                    Mizer_Saati.Enabled = false;
                }
               else
                {
                    durum.Text = "Durum: Devre Dışı";
                    Mizer_Saati.Enabled = false;
                }
                      
     
            }
            else if (durum.Text == "Durum: Devre Dışı")
            {
                Mizer_Saati.Enabled = false;
            }
           else  if (MizerAc == (e.KeyCode))
            {
                
                durum.Text = "Durum: Aktif";
                Mizer_Saati.Enabled = true;
            }
           else  if (MizerKapat == (e.KeyCode))
            {
                durum.Text = "Durum: Beklemede";
                Mizer_Saati.Enabled = false;
            }
        }
           
          
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
     
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mizer_Saati_Tick(object sender, EventArgs e)
        {
            DoMouseClick();
        }
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            if (hangi_tus.Text == "Sol Tık")
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }
            else if (hangi_tus.Text == "Sağ Tık")
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
            }
          
        
        }

        private void mssuresi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mizer_Saati.Interval = Convert.ToInt32(mssuresi.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Mizer_Saati.Enabled = false;
            using (Ayarlar_Mizer asd = new Ayarlar_Mizer())
            {
                asd.ShowDialog();
                AyarCek();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
               
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
           if (MizerArkaPlan)
            {
                Hide();
                notifyIcon1.Visible = true;
                e.Cancel = true;
                return;
            }
           else
            {
                notifyIcon1.Visible = false;
                gHook.unhook();
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Dispose();
            Application.Exit();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click_1(null, null);
        }
    }
}
