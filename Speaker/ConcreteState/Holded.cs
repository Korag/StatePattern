using System;
using Speaker.AbstractState;
using Speaker.Context;

namespace Speaker.ConcreteState
{
    class Holded : SpeakerState
    {
        public void ClickLock(MobileSpeaker speaker)
        {
            var type = speaker.PreviousState.GetType();

            if (type.Name == "Ready")
            {
                speaker.State = new Ready();
            }
            else
            {
                speaker.State = new Playing();
            }
            speaker.PreviousState = new Holded();
        }

        public void ClickNext(MobileSpeaker speaker)
        {
        }

        public void ClickPlay(MobileSpeaker speaker)
        {
        }

        public void ClickPrevious(MobileSpeaker speaker)
        {
        }

        public void ReportState()
        {
            Console.WriteLine("Stan Hold");
        }

    }
}
