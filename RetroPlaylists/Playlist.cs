using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroPlaylists
{
    class PlaylistItem
    {
        public string path;
        public string label;
        public string core_path;
        public string core_name;
        public string crc32;
        public string db_name;

    }

    class Playlist
    {
        public string version = "1.2";
        public string default_core_path = "";
        public string default_core_name = "";
        public int label_display_mode = 0;
        public int right_thumbnail_mode = 0;
        public int left_thumbnail_mode = 0;

        public PlaylistItem[] items;

        public Playlist(OldPlaylist oldPlaylist)
        {
            items = oldPlaylist.items.ToArray();
        }

        public void Export(string filename)
        {
            string output = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filename, output);
        }
    }

    class OldPlaylist
    {
        public List<PlaylistItem> items = new List<PlaylistItem>();

        public void Load(string filename)
        {
            items.Clear();

            string[] lplFile = File.ReadAllLines(filename);

            // For each item
            for (int i = 0; i < lplFile.Length / 6; i++)
            {
                int lineID = i * 6;

                items.Add(new PlaylistItem()
                {
                    path = lplFile[lineID],
                    label = lplFile[lineID + 1],
                    core_path = "DETECT",//lplFile[lineID + 2],
                    core_name = "DETECT",//lplFile[lineID + 3],
                    crc32 = lplFile[lineID + 4],
                    db_name = lplFile[lineID + 5]
                });
            }
        }
    }
}
