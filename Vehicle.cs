using System;

namespace CustomeColorsSounds
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }  
        public virtual void Drive() {
            Console.WriteLine("Zoooooom!");
        }
        public virtual void Turn() {
            Console.WriteLine("The vehicle carefully turns right.");
        }
        public virtual void Stop() {
            Console.WriteLine("The vehicle gently rolls to a stop!");
        }
    }
}