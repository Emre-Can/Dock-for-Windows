using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;
using UygulamaBar.Properties;
using System.Windows.Automation;

namespace UygulamaBar
{
    public partial class Form1 : Form
    {
        string ProgramAdi = "UygulamaBar";
        string Diger1 = "";
        string Diger2 = "";
        string Diger1kontrol = "";
        string Diger2kontrol = "";
        string visualYol = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\devenv.exe";
        public Form1()
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(100, 0, 0, 0);
        }





        private void Form1_Load(object sender, EventArgs e)
        {           
            Taskbar.Gizle();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
            int ekran_x= Screen.GetBounds(new Point(0, 0)).Width;
            int ekran_y = Screen.GetBounds(new Point(0, 0)).Height;
            this.Height = ((ekran_y / 100) * 8);
            this.Width = ((ekran_x / 100) * 50);
            this.Location = new Point(((ekran_x / 2) - (this.Width / 2)),(ekran_y - this.Height));
            buttonBupc.Height = this.Height +10;
            buttonBupc.Width = buttonBupc.Height;
            buttonChrome.Height = buttonBupc.Height;
            buttonChrome.Width = buttonBupc.Width;
            buttonChrome.Location = new Point(buttonBupc.Width + 8,buttonBupc.Location.Y);
            buttonGmail.Height = buttonBupc.Height;
            buttonGmail.Width = buttonBupc.Width;
            buttonGmail.Location = new Point(buttonBupc.Width + buttonChrome.Width + 12, buttonBupc.Location.Y);
            buttonClose.Height = buttonBupc.Height;
            buttonClose.Width = buttonBupc.Width;
            buttonClose.Location = new Point((this.Width-(buttonClose.Width+button1.Width+8)),buttonBupc.Location.Y);
            buttonDiger1.Height = buttonBupc.Height;
            buttonDiger1.Width = buttonBupc.Width;
            buttonDiger1.Location = new Point(buttonBupc.Width + buttonChrome.Width + buttonGmail.Width+16, buttonBupc.Location.Y);
            buttonDiger2.Height = buttonBupc.Height;
            buttonDiger2.Width = buttonBupc.Width;
            buttonDiger2.Location = new Point(buttonBupc.Width + buttonChrome.Width + buttonGmail.Width +buttonDiger1.Width+ 20, buttonBupc.Location.Y);


        }
        private void buttonBupc_Click(object sender, EventArgs e)
        {
            Process.Start(@"explorer.exe");
        }
        
        private void buttonChrome_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com.tr/");

        }
        
        private void buttonGmail_Click(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Taskbar.Goster();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.DeleteValue(ProgramAdi);
            Application.Exit();
        }
        private void buttonDiger1_Click(object sender, EventArgs e)
        {
            if (Diger1kontrol == "visual")
                visual();
            else if (Diger1kontrol == "epicgames")
                epicgames();
        }
        private void buttonDiger2_Click(object sender, EventArgs e)
        {
            if (Diger2kontrol == "visual")
                visual();
            else if (Diger2kontrol == "epicgames")
                epicgames();
        }



        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);


        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        private enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        };
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(int hwnd);

        public void visual()
        {
            //uygulama ekrandayken (simge durumunda değilken) uygulamaya odaklama
            Process bProcess = Process.GetProcessesByName("devenv").FirstOrDefault();
            //bProcess. = ProcessWindowStyle.Maximized;
            ShowWindow(bProcess.Handle, ShowWindowEnum.Restore);
            AutomationElement element = AutomationElement.FromHandle(bProcess.MainWindowHandle);
                element.SetFocus();
                
            
        }
        public void epicgames()
        {
            Process.Start("C:\\Program Files (x86)\\Epic Games\\Launcher\\Portal\\Binaries\\Win32\\EpicGamesLauncher.exe");
        }

        public class Taskbar
        {
            [DllImport("user32.dll")]
            private static extern int FindWindow(string className, string windowText);

            [DllImport("user32.dll")]
            private static extern int ShowWindow(int hwnd, int command);

            [DllImport("user32.dll")]
            public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

            [DllImport("user32.dll")]
            private static extern int GetDesktopWindow();

            private const int SW_HIDE = 0;
            private const int SW_SHOW = 1;

            protected static int Handle
            {
                get
                {
                    return FindWindow("Shell_TrayWnd", "");
                }
            }

            protected static int HandleOfStartButton
            {
                get
                {
                    int handleOfDesktop = GetDesktopWindow();
                    int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0);
                    return handleOfStartButton;
                }
            }

            public static void Goster()
            {
                ShowWindow(Handle, SW_SHOW);
                ShowWindow(HandleOfStartButton, SW_SHOW);
            }

            public static void Gizle()
            {
                ShowWindow(Handle, SW_HIDE);
                ShowWindow(HandleOfStartButton, SW_HIDE);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Taskbar.Goster();
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\shutdown.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            Process[] Memory = Process.GetProcesses();

            foreach (Process prc in Memory)
            {
                //listBox1.Items.Add(prc.ProcessName);
                if (prc.ProcessName == "devenv")
                {
                    
                    if (Diger1=="")
                    {
                        if (Diger2 == "visual") buttonDiger2.Hide();
                        buttonDiger1.Show();
                        buttonDiger1.BackgroundImage = Resources.icons8_visual_studio_64px;
                        Diger1 = "visual";
                    }
                    else if (Diger2 == "")
                    {
                        buttonDiger2.Show();
                        buttonDiger2.BackgroundImage = Resources.icons8_visual_studio_64px;
                        Diger2 = "visual";
                    }

                }
                else if (prc.ProcessName== "EpicGamesLauncher")
                {
                    if (Diger1=="")
                    {
                        if (Diger2 == "epicgames") buttonDiger2.Hide();
                        buttonDiger1.Show();
                        buttonDiger1.BackgroundImage = Resources._31a462f5c4e0136a296cdfe4cafcd275_removebg_preview;
                        Diger1 = "epicgames";
                    }
                    else if (Diger2 == "")
                    {
                        buttonDiger2.Show();
                        buttonDiger2.BackgroundImage = Resources._31a462f5c4e0136a296cdfe4cafcd275_removebg_preview;
                        Diger2 = "epicgames";
                    }
                }

            }
            if (Diger1 != "visual" && Diger1 != "epicgames") 
            {
                buttonDiger1.Hide(); 
            }
            if (Diger2 != "visual" && Diger2 != "epicgames")
            {
                buttonDiger2.Hide();
            }
            Diger1kontrol = Diger1;
            Diger2kontrol = Diger2;
            Diger1 = "";
            Diger2 = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ayar = new Form2();
            ayar.Show();
            ayar.Location = new Point(this.Location.X + button2.Left, this.Location.Y - ayar.Height);
        }
    }
}
