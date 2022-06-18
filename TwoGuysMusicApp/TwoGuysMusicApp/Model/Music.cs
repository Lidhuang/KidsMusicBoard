using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoGuysMusicApp.Model
{
    public class Music
    {
        public string Name { get; set; }
        public string AudiosFile { get; set; }
        public string ImagesFile { get; set; }

        public Music(string name)
        {
            AudiosFile = $"Assets/Audios/{name}.mp3";
            ImagesFile = $"Assets/Images/{name}.jepg";
        }
    }

    
}
