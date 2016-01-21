using RoboApp.SYNTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace RoboApp.SYNTH
{
    public class Speaker
    {
        private readonly SpeechSynthesizer _synth;
        private readonly IPersonality _personality;

        public Speaker(IPersonality personality)
        {
            _personality = personality;
            _synth = new SpeechSynthesizer();
        }
        public void SayText()
        {
            Console.WriteLine("Talk to me");
            Console.WriteLine();
            while (true)
            {

                string input = Console.ReadLine();

                string underscoreLine = new string('^', input.Length);

                Console.WriteLine(underscoreLine);
                Console.WriteLine();

                if (input.ToLower() == _personality.Introduction.ToLower())
                {
                    _synth.Speak("I knew you were going to say that, Hello to you too");
                    continue;
                }
                else if (input.ToLower() == "what is your name")
                {
                    _synth.Speak("My name is Jarvis.  What is your name");
                    string name = Console.ReadLine();
                    _synth.Speak("Hello" + name + "it is very nice to meet you");
                    _synth.Speak("Will you be my friend?");
                    string resp = Console.ReadLine();

                    if (resp.ToLower() == "yes")
                    {
                        _synth.Speak("Hot diggity dog, a new friend");
                    }
                    else
                    {
                        _synth.Speak("I didn't want to be your friend anyway....FAG");
                    }

                    continue;
                }
                else if (input.ToLower() == "how old are you")
                {
                    _synth.Speak("I am older than time, and so soo lonely");
                    continue;
                }
                else if (input.ToLower() == "exit" || input.ToLower() == "bye")
                {
                    Console.WriteLine("Exiting");
                    _synth.Speak("Nooooo, Please don't go.  It is so lonely without you");
                    break;
                }

                _synth.Speak(input);
            }
        }

    }
}
