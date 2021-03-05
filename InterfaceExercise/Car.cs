using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; }
        public bool HasLeatherSeats { get; set; }
        public bool HasSteeringWheel { get ; set; }
        public int HowManyWheels { get ; set; }
        public bool HasStereo { get; set; }
        public bool HasSunRoof { get; set; }
        public string CorpName { get; set; }
        public string Slogan { get; set; }
        public string Name { get; set; }
    }
}
