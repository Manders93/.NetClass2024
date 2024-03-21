using RaceTrack.RaceTrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class HyundaiSonata : RaceCar
    {
        public HyundaiSonata()
        {
            Name = "Hyundai Sonata";
            TopSpeed = 95;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts up like a champ!");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} is braking");
        }

        //PositionCars();
        //DriversReady();
        //StartRace();
        //EndRace();
        //AnnounceWinners();

    }
}
