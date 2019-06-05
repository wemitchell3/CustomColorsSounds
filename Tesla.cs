using System;

namespace CustomeColorsSounds
{
    public class Tesla : Vehicle 
    {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }
        public override void Drive () {
        Console.WriteLine($"The {MainColor} Tesla blazes by you. MMmmmmmmm!");
        }
        public override void Turn () {
        Console.WriteLine($"The {MainColor} Tesla squeals around a right turn.");
        }
        public override void Stop () {
        Console.WriteLine($"The {MainColor} Tesla silently stops as if never moved.");
        }

    }
}