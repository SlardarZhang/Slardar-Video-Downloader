using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser;
using DotNetBrowser.WinForms;

namespace Slardar_Video_Downloader
{
    public partial class Slardar_Video_Downloader : Form
    {
        private WinFormsBrowserView browserView;
        private String current_url;
        public Slardar_Video_Downloader()
        {
            InitializeComponent();
        }

        private void Slardar_Video_Downloader_Load(object sender, EventArgs e)
        {
            browserView = new WinFormsBrowserView();
            mainLayoutPanel.Controls.Add((Control)browserView);
            browserView.Dock = DockStyle.Fill;
            browserView.Browser.AudioMuted = true;
            browserView.Browser.LoadURL(urlTextBox.Text);
            current_url = urlTextBox.Text;
            browserView.MouseDown += new System.Windows.Forms.MouseEventHandler(browserView_MouseDown);
            urlTextBox.Focus();
        }

        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Shift | Keys.Enter))//Clean cache
            {
                browserView.Browser.CookieStorage.DeleteAll();
                browserView.Browser.CacheStorage.ClearCache();
                browserView.Browser.LoadURL(urlTextBox.Text);
                current_url = urlTextBox.Text;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                browserView.Browser.LoadURL(urlTextBox.Text);
                current_url = urlTextBox.Text;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void muteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            browserView.Browser.AudioMuted = muteCheckBox.Checked;
        }

        private void browserView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.Write("W");
        }
    }
}
