using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using System.Net;

namespace PS4_Trainer_by_TylerMods
{
    public partial class Changelog : UserControl
    {
        public Changelog()
        {
            InitializeComponent();
        }

        private void Changelog_Load(object sender, EventArgs e)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            try
            {
                //richTextBox1.Text = (changeLog.Changelog);
                string webData = wc.DownloadString("https://pastebin.com/raw/9vECK948");
                richTextBox1.Text = webData.ToString();
            }
            catch
            {
                MessageBox.Show("Unable to reach changelog from internet. Check firewall, country restrictions, and make sure you have an internet connection.");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
public struct ChangeLog
{
    public string Version { get; set; }
    public string Changelog { get; set; }
}

public static class ChangelogData
{
    static List<ChangeLog> _changeLogList = null;
    static ChangelogData()
    {
        string dataAsJson = new WebClient().DownloadString("https://pastebin.com/raw/vwmxeTt8");

        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

        List<ChangeLog> changeLogs = javaScriptSerializer.Deserialize<List<ChangeLog>>(dataAsJson);

        _changeLogList = changeLogs;

    }
    public static List<ChangeLog> GetAll()
    {
        if (_changeLogList == null)
            return new List<ChangeLog>();

        return _changeLogList;
    }

    public static ChangeLog Get(string version)
    {
        if (_changeLogList == null)
            return default(ChangeLog);

        return _changeLogList.Find(x => x.Version == version);
    }
}