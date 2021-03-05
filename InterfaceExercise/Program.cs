using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany-DONE

            //Create 3 classes called Car , Truck , & SUV-DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.-DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.-DONE
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class-DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.-DONE
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var vehicles = new List<IVehicle>();


            var sedan1 = new Car();
            sedan1.Name = "Dodge Charger";
            sedan1.CorpName = "Daimler Chrysler";
            sedan1.Slogan = "Best 4 Door Class";
            sedan1.HowManyWheels = 4;
            sedan1.HasLeatherSeats = true;
            sedan1.HasSteeringWheel = true;
            sedan1.HasStereo = true;
            vehicles.Add(sedan1);

            var pickup1 = new Truck();
            pickup1.Name = "Ford F-150";
            pickup1.CorpName = "Ford Motor Company";
            pickup1.Slogan = "Best Rated Truck";
            pickup1.HowManyWheels = 4;
            pickup1.HasSteeringWheel = true;
            pickup1.HasStereo = false;
            pickup1.HasTruckBed = true;
            vehicles.Add(pickup1);

            var suv1 = new SUV();
            suv1.Name = "Jeep Wrangler";
            suv1.HasSteeringWheel = true;
            suv1.HowManyWheels = 4;
            suv1.FourWheelDrive = true;
            suv1.HasStereo = true;
            vehicles.Add(suv1);

            foreach(var x in vehicles)
            {
                Console.WriteLine($"Vehicle {x.Name} has {x.HowManyWheels} wheels. It is {x.HasStereo} it has a stereo.");
                Console.WriteLine();
            }
        }
    }
}
