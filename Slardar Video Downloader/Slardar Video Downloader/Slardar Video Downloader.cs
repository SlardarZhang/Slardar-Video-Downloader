using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using DotNetBrowser;
using DotNetBrowser.WinForms;
using System.IO;
using System.Collections.Specialized;

namespace Slardar_Video_Downloader
{
    public enum FilterType
    {
        YOUTUBE = 0,
        M3U8 = 1,
        MEDIA = 2,
        UNIVERAL = 3
    }
        
    public partial class Slardar_Video_Downloader : Form
    {
        private WinFormsBrowserView browserView;
        private string current_url;
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
            browserView.Browser.Context.NetworkService.ResourceHandler = new SlardarResourceHandler( "test.txt", this);
            browserView.Browser.LoadHandler = new SlardarLoaderHandler();
            browserView.Browser.LoadURL(urlTextBox.Text);
            current_url = urlTextBox.Text;
            urlTextBox.GotFocus += URLTextBox_GotFocus;
            SniffComboBox.SelectedIndex = 0;
        }

        private void URLTextBox_GotFocus(object sender, EventArgs e)
        {
            urlTextBox.SelectAll();
        }

        private void URLTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Shift | Keys.Enter))//Clean cache
            {
                ((SlardarResourceHandler)browserView.Browser.Context.NetworkService.ResourceHandler).ResetFilter((FilterType)SniffComboBox.SelectedIndex);
                browserView.Browser.CookieStorage.DeleteAll();
                browserView.Browser.CacheStorage.ClearCache();
                browserView.Browser.LoadURL(urlTextBox.Text);
                current_url = urlTextBox.Text;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ((SlardarResourceHandler)browserView.Browser.Context.NetworkService.ResourceHandler).ResetFilter((FilterType)SniffComboBox.SelectedIndex);
                browserView.Browser.LoadURL(urlTextBox.Text);
                current_url = urlTextBox.Text;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void MuteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            browserView.Browser.AudioMuted = muteCheckBox.Checked;
        }

    }

    public class SlardarResourceHandler : ResourceHandler
    {
        private StreamWriter sw;
        private Form mainForm;
        private FilterType filter;
        private string videoURL;
        private string audioURL;
        private long duration;
        private string fexp;

        public SlardarResourceHandler(String filename, Form mainForm)
        {
            sw = new StreamWriter(File.OpenWrite(filename));
            this.mainForm = mainForm;
            filter = 0;
        }

        public bool CanLoadResource(ResourceParams resourceParams)
        {
            NameValueCollection collections = HttpUtility.ParseQueryString(resourceParams.URL.ToLower());

            switch (filter)
            {
                case FilterType.YOUTUBE:
                    if (resourceParams.URL.Contains("videoplayback?source=youtube"))
                    {
                        if (collections.GetValues("dur").Length == 1)
                        {
                            duration = Convert.ToInt64(Double.Parse(collections.GetValues("dur")[0]) * 1000.0);
                        }
                        if (collections.GetValues("mime").Length == 1)
                        {
                            if (collections.GetValues("mime")[0].Contains("video"))
                            {
                                videoURL = resourceParams.URL;
                            }

                            if (collections.GetValues("mime")[0].Contains("audio"))
                            {
                                audioURL = resourceParams.URL;
                            }
                        }
                    }

                    if(resourceParams.ResourceType == ResourceType.PING)
                    {
                        if (collections.GetKey(0).Contains("qoe"))
                        {
                            fexp = collections.GetValues("fexp")[0];
                        }
                    }

                    break;
                case FilterType.M3U8:
                    break;
                case FilterType.MEDIA:
                    break;
                case FilterType.UNIVERAL:
                    break;
                default:
                    break;
            }
            return true;
        }

        public void ResetFilter(FilterType filter)
        {
            this.filter = filter;
            videoURL = null;
            audioURL = null;
            duration = 0;
            fexp = null;
    }
    }

    public class SlardarLoaderHandler : DefaultLoadHandler
    {
        public override bool OnCertificateError(CertificateErrorParams errorParams)
        {
            DialogResult result = MessageBox.Show("SSL certification error code:" + errorParams.CertificateError + "\r\nDo you want to continue?", "SSL certification error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return false;
            else
                return true;
        }
    }


}
