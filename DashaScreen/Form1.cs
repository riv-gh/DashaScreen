using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace DashaScreen
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        IntPtr thisWindow;
        String folderPath;

        public enum fsModifiers
        {
            Alt = 0x0001,
            Control = 0x0002//,
            //Shift = 0x0004, //Changes!
            //Window = 0x0008
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes a fullscreen screenshot of the monitor and saves the specified file in a directory with custom name.
        /// It expects the Format of the file.
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        private void FullScreenshot(String filepath, String filename, ImageFormat format)
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                string fullpath = filepath + "\\" + filename;

                bitmap.Save(fullpath, format);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullScreenshot(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                String.Format("screen_{0:yyyy-MM-dd_HH-mm-ss}.png", DateTime.Now),
                ImageFormat.Png);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.hotKey == 0)
            {
                Properties.Settings.Default.hotKey = 84;
            }
            folderPath = lSavingPath.Text = Properties.Settings.Default.folderPath;
            if (folderPath == "")
            {
                Properties.Settings.Default.folderPath = 
                    folderPath = 
                    lSavingPath.Text = 
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Properties.Settings.Default.Save();

            }
            //thisWindow = FindWindow(null, "DashaScreen");
            thisWindow = this.Handle;
            RegisterHotKey(thisWindow, 1, (int)fsModifiers.Control, (int)Keys.T);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(thisWindow, 1);
        }

        protected override void WndProc(ref Message keyPressed)
        {
            if(keyPressed.Msg == 0x0312)
            {
                FullScreenshot(Properties.Settings.Default.folderPath,
                String.Format("screen_{0:yyyy-MM-dd_HH-mm-ss}.png", DateTime.Now),
                ImageFormat.Png);
            }
            base.WndProc(ref keyPressed);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            DialogResult dialogResult = MessageBox.Show("Close Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                this.TopMost = true;
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = ((int)Keys.D).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.folderPath = folderPath = lSavingPath.Text = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void tbChar_KeyDown(object sender, KeyEventArgs e)
        {
            tbChar.Text = e.KeyCode.ToString();
            UnregisterHotKey(thisWindow, 1);
            RegisterHotKey(thisWindow, 1, (int)fsModifiers.Control, (int)e.KeyCode);
        }

        private void niApp_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(folderPath);
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                showHideToolStripMenuItem.Text = "Hide";
            }
            else
            {
                showHideToolStripMenuItem.Text = "Show";
            }
        }
    }
}
