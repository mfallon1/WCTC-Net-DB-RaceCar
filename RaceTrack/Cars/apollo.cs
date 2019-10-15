using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Apollo : RaceCar
    {
        public Apollo()
        {
            Name = "Buick Apollo";
            TopSpeed = 120;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is trying, trying again and finally roars to life!");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} is in trouble - the brakes look to be smoking - wait, wait there she goes, now she is stopping!");
            base.Brake();
        }
    }
}

