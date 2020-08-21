using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lasp_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void bntForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void bntRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void bntGo_Click(object sender, EventArgs e)
        {
            string WebPage = txtUrl.Text.Trim();
            webBrowser.Navigate(WebPage);
        }
    }
}
