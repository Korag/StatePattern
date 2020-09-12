using System.Collections.Generic;
using System.Threading;
using Speaker.AbstractState;

namespace Speaker.Context
{
    public class MobileSpeaker
    {
        public SpeakerState State { get; set; }
        public SpeakerState PreviousState { get; set; }

        public List<MusicTrack> Playlist;
        public MusicTrack CurrentTrack;

        public void ClickLock()
        {
            State.ClickLock(this);
        }

        public void ClickNext()
        {
            State.ClickNext(this);
        }

        public void ClickPlay()
        {
            State.ClickPlay(this);
        }

        public void ClickPrevious()
        {
            State.ClickPrevious(this);
        }

        public void ReportState()
        {
            State.ReportState();
        }

    }
}

