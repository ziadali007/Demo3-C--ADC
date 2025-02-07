using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Youtupe
{
    internal class Channel
    {
        public string Title { get; set; }

        public List<Videos> videos { get; set; } = new List<Videos>();

        public void AddVideo(Videos video)
        {
            videos.Add(video);
            if(UploadVideo is not null)
            {
                UploadVideo(this, video);
            }
        }

        public Action<Channel, Videos> UploadVideo;
    }
}
