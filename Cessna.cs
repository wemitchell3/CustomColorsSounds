using System;

namespace CustomeColorsSounds
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
        public override void Drive () {
        Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zzzzzoooommmm!");
        }
        public override void Stop() {
            Console.WriteLine("The white Cessna rolls down the runway for a mile and stops.");
        } 
    }
}