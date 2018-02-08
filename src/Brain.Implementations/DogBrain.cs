using System;
using System.Linq;

namespace Brain.Implementations
{
    internal class DogBrain // TODO: Reference Brain.Interfaces and make DogBrain implement IThink
    {
        private readonly string Name;
        public DogBrain(string name)
        {
            Name = name;
        }

        public string Concentrate(int seconds)
        {
            if (seconds <= 1) return "zzz-woof-zzz";
            string thoughts = ".?.";
            for (int count = 1; count < seconds; count++)
            {
                thoughts += ".?.";
                if (count > 5)
                {
                    thoughts += ".! Squirrel !!";
                    break;
                }
            }
            return thoughts;
        }

        public string Listen(string sounds)
        {
            if (!string.IsNullOrEmpty(sounds))
                if (sounds.ToLower().Contains(Name.ToLower()))
                    return "Woof!";
                else if (sounds.ToLower().Contains("squirrel"))
                    return "grrr...";
                else
                    return ".?.";
            else
                return string.Empty;
        }
    }
}
