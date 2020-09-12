using System;
using Speaker.AbstractState;
using Speaker.Context;

namespace Speaker.ConcreteState
{
    class Ready : SpeakerState
    {
        public void ClickLock(MobileSpeaker speaker)
        {
            speaker.PreviousState = speaker.State;
            speaker.State = new Holded();
        }

        public void ClickNext(MobileSpeaker speaker)
        {
        }

        public void ClickPlay(MobileSpeaker speaker)
        {
            speaker.PreviousState = speaker.State;
            speaker.State = new Playing();
        }

        public void ClickPrevious(MobileSpeaker speaker)
        {
        }

        public void ReportState()
        {
            Console.WriteLine("Stan gotowości");
        }

    }
}


