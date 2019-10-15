using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Mary : Driver
    {
        public Mary(RaceCar car) : base(car)
        {
            Name = "Mary";
            SkillLevel = 7;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
