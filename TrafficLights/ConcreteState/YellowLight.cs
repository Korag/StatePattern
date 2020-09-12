using System;
using TrafficLights.AbstractState;
using TrafficLights.Context;

namespace TrafficLights.ConcreteState
{
    class YellowLight : TrafficLightState
    {
        public void Change(TrafficLight light)
        {
            var type = light.PreviousState.GetType();

            if (type.Name == "GreenLight")
            {
                light.State = new RedLight();
            }
            else
            {
                light.State = new GreenLight();
            }
        }

        public void SavePreviousState(TrafficLight light)
        {
        }


        public void ReportState()
        {
            Console.WriteLine("Żółte światło");
        }

    }
}

