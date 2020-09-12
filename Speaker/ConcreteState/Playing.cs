using System;
using System.Linq;
using Speaker.AbstractState;
using Speaker.Context;

namespace Speaker.ConcreteState
{
    class Playing : SpeakerState
    {
        public void ClickLock(MobileSpeaker speaker)
        {
            speaker.PreviousState = speaker.State;
            speaker.State = new Holded();
        }

        public void ClickNext(MobileSpeaker speaker)
        {
            var index = speaker.Playlist.FindIndex(x => x.Name == speaker.CurrentTrack.Name);
            speaker.CurrentTrack = speaker.Playlist.ElementAt((index + 1) % speaker.Playlist.Count);
        }

        public void ClickPlay(MobileSpeaker speaker)
        {
            speaker.PreviousState = speaker.State;
            speaker.State = new Ready();
        }

        public void ClickPrevious(MobileSpeaker speaker)
        {
            var index = speaker.Playlist.FindIndex(x => x.Name == speaker.CurrentTrack.Name);
            if (index == 0)
            {
                speaker.CurrentTrack = speaker.Playlist.ElementAt(speaker.Playlist.Count-1);
            }
            else
            {
                speaker.CurrentTrack = speaker.Playlist.ElementAt((index - 1));
            }
        }

        public void ReportState()
        {
            Console.WriteLine("Stan odtwarzania");
        }

    }
}

