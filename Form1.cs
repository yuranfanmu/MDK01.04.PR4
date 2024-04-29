using System.Runtime.InteropServices;
using System.Globalization;

namespace MDK01._04.PR4
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "SwapMouseButton")]
        internal extern static int SwapMouseButton(int bSwap);
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const int VK_NUMLOCK = 0x90;
        private const int VK_SCROLL = 0x91;
        private const int VK_CAPITAL = 0x14;
        private const int KEYEVENTF_EXTENDEDKEY = 0x1;
        private const int KEYEVENTF_KEYUP = 0x2;

        public Form1()
        {
            InitializeComponent();
            checkLocks();
        }

        private void checkLocks()
        {
            cbxNum.Checked = Control.IsKeyLocked(Keys.NumLock);
            cbxCaps.Checked = Control.IsKeyLocked(Keys.CapsLock);
            cbxScroll.Checked = Control.IsKeyLocked(Keys.Scroll);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (btnSwap.Text == "Поменять кнопки мыши местами")
            {
                btnSwap.Text = "Восстановить настройки кнопок мыши";
                SwapMouseButton(1);
            }
            else
            {
                btnSwap.Text = "Поменять кнопки мыши местами";
                SwapMouseButton(0);
            }
        }

        private void rbRU_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRU.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
            }
            if (rbENG.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
            }
        }

        private void cbx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbx = (CheckBox)sender;
            switch (cbx.Text)
            {
                case "NumLock":
                    keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                    keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
                    cbx.Checked = Control.IsKeyLocked(Keys.NumLock);
                    break;
                case "CapsLock":
                    keybd_event(VK_CAPITAL, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                    keybd_event(VK_CAPITAL, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
                    cbx.Checked = Control.IsKeyLocked(Keys.CapsLock);
                    break;
                case "ScrollLock":
                    keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                    keybd_event(VK_SCROLL, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
                    cbx.Checked = Control.IsKeyLocked(Keys.Scroll);
                    break;
            }
        }
    }
}
