using System;

namespace CustomeColorsSounds
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
        public override void Drive () {
        Console.WriteLine($"The {MainColor} Ram growls by you. Rrrrruuuummmmbbbble!");
        }
        // public void turn() {}
        // public void stop() {} 
    }
}