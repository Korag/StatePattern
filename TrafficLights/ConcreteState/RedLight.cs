using System;
using TrafficLights.AbstractState;
using TrafficLights.Context;

namespace TrafficLights.ConcreteState
{
    class RedLight : TrafficLightState
    {
        public void Change(TrafficLight light)
        {
            light.State = new YellowLight();
        }

        public void SavePreviousState(TrafficLight light)
        {
            light.PreviousState = light.State;
        }

        public void ReportState()
        {
            Console.WriteLine("Czerwone światło");
        }

    }
}
