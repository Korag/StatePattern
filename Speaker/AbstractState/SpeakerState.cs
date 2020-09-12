using Speaker.Context;

namespace Speaker.AbstractState
{
    public interface SpeakerState
    {
        void ClickPlay(MobileSpeaker speaker);
        void ClickLock(MobileSpeaker speaker);
        void ClickNext(MobileSpeaker speaker);
        void ClickPrevious(MobileSpeaker speaker);
        void ReportState();

    }
}

