using System;

namespace Program
{
    abstract class Planet
    {
        public abstract void ReportAboutMovement();
        public abstract void ReportAboutLife();
    }

    class Earh : Planet
    {
        public override void ReportAboutMovement()
        {
            Console.WriteLine("Planet Earth moves around the Sun.");
        }

        public override void ReportAboutLife()
        {
            Console.WriteLine("There is life on planet Earth.");
        }
    }

    class Moon : Planet
    {
        public override void ReportAboutMovement()
        {
            Console.WriteLine("The moon moves around the earth.");
        }
        public override void ReportAboutLife()
        {
            Console.WriteLine("There is no life on the moon.");
        }
    }
    class Program
    {
        static void Main()
        {
            Planet[] planets = {new Earh(), new Moon(),};

            foreach (Planet planet in planets)
            {
                planet.ReportAboutMovement();
                planet.ReportAboutLife();
            }
        }
    }
}