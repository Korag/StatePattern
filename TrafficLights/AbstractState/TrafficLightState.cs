using TrafficLights.Context;

namespace TrafficLights.AbstractState
{
    public interface TrafficLightState
    {
        void Change(TrafficLight light);
        void SavePreviousState(TrafficLight light);
        void ReportState();

    }
}

