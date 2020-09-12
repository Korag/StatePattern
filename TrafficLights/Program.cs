using System;
using TrafficLights.ConcreteState;
using TrafficLights.Context;

namespace TrafficLights
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();

            light.State = new RedLight();
            light.PreviousState = new RedLight();

            light.SavePreviousState();
            for (int count = 0; count < 15; count++)
            {
                light.SavePreviousState();
                light.Change();
                light.ReportState();
            }
            Console.ReadLine();
        }
    }
}

