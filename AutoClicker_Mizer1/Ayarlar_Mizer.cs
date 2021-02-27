using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker_Mizer1
{
    public partial class Ayarlar_Mizer : Form
    {
      

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;










        public Ayarlar_Mizer()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
         
        }
        GlobalKeyboardHook gHook = new GlobalKeyboardHook();
        private void Form1_Load(object sender, EventArgs e)
        {
            AyarCek();
        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gHook.unhook();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mizer_Saati_Tick(object sender, EventArgs e)
        {
        
        }
        private void kapatmatusubelirle(object sender, KeyEventArgs e)
        {

           
         
        }
        public void AyarCek()
        {
            mizer_Baslat.Text = Properties.Settings.Default.D_Baslatma.ToString();
            mizer_kapat.Text = Properties.Settings.Default.D_Kapatma.ToString();
            mizer_Etkin.Text = Properties.Settings.Default.D_Etkin_Devre.ToString();
            mizer_arkaplan.Checked = Properties.Settings.Default.D_Arka_Plan;
            mizer_Hangitus.Text = Properties.Settings.Default.D_Hangi_Tus;
            mizer_ms.Text = Properties.Settings.Default.D_MS;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {


            Properties.Settings.Default.D_Baslatma = (Keys)Enum.Parse(typeof(Keys), mizer_Baslat.Text, true);
            Properties.Settings.Default.D_Kapatma = (Keys)Enum.Parse(typeof(Keys), mizer_kapat.Text, true);
            Properties.Settings.Default.D_Etkin_Devre = (Keys)Enum.Parse(typeof(Keys), mizer_Etkin.Text, true);
            Properties.Settings.Default.D_Arka_Plan = mizer_arkaplan.Checked;
            Properties.Settings.Default.D_Hangi_Tus = mizer_Hangitus.Text;
            Properties.Settings.Default.D_MS = mizer_ms.Text;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            mizer_Etkin.Text = e.KeyCode.ToString();
        }
        private void Mizer_KeySwap(object sender, KeyEventArgs e)
        {
            (sender as TextBox).Text = e.KeyCode.ToString();
        }
    }
}
