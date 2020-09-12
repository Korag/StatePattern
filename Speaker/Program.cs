using Speaker.ConcreteState;
using Speaker.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speaker
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileSpeaker speaker = new MobileSpeaker();

            speaker.State = new Ready();
            speaker.PreviousState = new Ready();

            speaker.Playlist = new List<MusicTrack>
            {
                new MusicTrack{Name = "1", Duration = 180, URL = "" },
                new MusicTrack{Name = "2", Duration = 220, URL = "" },
                new MusicTrack{Name = "3", Duration = 120, URL = "" },
            };
            speaker.CurrentTrack = speaker.Playlist.ElementAt(1);

            speaker.ClickPlay();
            speaker.ReportState();
            speaker.ClickNext();
            //speaker.ClickPrevious();
            speaker.ReportState();

            speaker.ClickLock();
            speaker.ReportState();
            speaker.ClickPlay();
            speaker.ReportState();

            speaker.ClickLock();
            speaker.ReportState();
            speaker.ClickPlay();
            speaker.ReportState();

            Console.ReadLine();
        }
    }
}
