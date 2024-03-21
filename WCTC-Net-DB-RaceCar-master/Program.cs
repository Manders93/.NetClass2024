using RaceTrack.RaceTrack.Cars;
using RaceTrack.RaceTrack.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var raceTrack = new RaceTrack.RaceTrack(5);

            HyundaiSonata HyundaiSonata = new HyundaiSonata();
            HyundaiSonata.StartEngine();
            HyundaiSonata.Brake();  

            raceTrack.PositionCars();
            raceTrack.DriversReady();
            raceTrack.StartRace();

            for (int i = 0; i < raceTrack.NumberOfLaps; i++)
            {
                raceTrack.AnnouncePositions();
            }

          

            raceTrack.EndRace();
            raceTrack.AnnounceWinners();

            Amanda Amanda = new Amanda(HyundaiSonata);
        }
    }
}
