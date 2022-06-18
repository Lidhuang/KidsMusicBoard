using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoGuysMusicApp.Model
{
    public static class MusicManager
    {
        private static List<Music> GetMusics()
        {
            var musics = new List<Music>();
            musics.Add(new Music("1 Brave Americans"));
            musics.Add(new Music("2 Accomplish"));
            musics.Add(new Music("3 Sleepy Hands"));
            musics.Add(new Music("4 Safe Behind The Wheel"));
            return musics;
        }

        public static void GetAllMucis(ObservableCollection<Music> musics)
        {
            var allMusics = GetMusics();
            musics.Clear();
            allMusics.ForEach(music => musics.Add(music));
        }
    }
}
