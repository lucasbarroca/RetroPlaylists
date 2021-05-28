using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroPlaylists
{
    public partial class frmMain : Form
    {
        OldPlaylist playlist = new OldPlaylist();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtLoadFilename.Text))
                return;
        
            btLoad.Enabled = false;
            btLoad.Text = "loading...";

            playlist.Load(txtLoadFilename.Text);
            groupBox1.Text = "Playlist (" + playlist.items.Count +")";
            dgItems.Rows.Clear();

            int i = 0;
            foreach (PlaylistItem item in playlist.items)
            {
                i++;
                dgItems.Rows.Add(i, item.path, item.label, item.core_path, item.core_name, item.crc32, item.db_name);   
            }
            
            btLoad.Text = "LOAD";
            btLoad.Enabled = true;
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            btExport.Enabled = false;
            btExport.Text = "saving...";

            Playlist exportPlaylist = new Playlist(playlist);
            exportPlaylist.Export(txtExportFilename.Text);

            MessageBox.Show("Saved.", "Saved");

            btExport.Text = "SAVE";
            btExport.Enabled = true;
        }
    }
}
