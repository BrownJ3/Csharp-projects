using System;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using RoboApp.SYNTH;
using RoboApp.SYNTH.Models;

namespace Robot
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IPersonality personality;
            if (args.Length > 1 && args[0] == "Mean")
            {
                personality = new MeanPersonality();
            }
            else {
                personality = new Personality();
            }

            Speaker speaker = new Speaker(personality);

            speaker.SayText();
        }
    }
}


