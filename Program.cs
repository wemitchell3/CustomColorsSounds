using System;

namespace CustomeColorsSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero ();
            fxs.MainColor = "Midnight Blue";
            
            Tesla modelS = new Tesla ();
            modelS.MainColor = "Ron Burgundy";
            
            Cessna mx410 = new Cessna ();
            mx410.MainColor = "White Knight";

            Ram hemi = new Ram ();
            hemi.MainColor = "Silver Bullet";

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            hemi.Drive();
            hemi.Turn();
            hemi.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();  
        }
    }
}
