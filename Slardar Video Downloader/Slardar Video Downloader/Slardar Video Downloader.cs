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
        }

        private void urlTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                browserView.Browser.LoadURL(urlTextBox.Text);
            }
        }

        private void muteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            browserView.Browser.AudioMuted = muteCheckBox.Checked;
        }
    }
}
