using System.Threading;
using TrafficLights.AbstractState;

namespace TrafficLights.Context
{
    public class TrafficLight
    {
        public TrafficLightState State { get; set; }
        public TrafficLightState PreviousState { get; set; }

        public void Change()
        {
            State.Change(this);
            Thread.Sleep(3000);
        }

        public void SavePreviousState()
        {
            State.SavePreviousState(this);
        }

        public void ReportState()
        {
            State.ReportState();
        }

    }
}

