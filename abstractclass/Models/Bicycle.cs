using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass.Models
{
    internal class Bicycle:Vehicle
    {
        public string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Type: {Type}");
            base.GetInfo();
        }
        public void AverageSpeed()
        {
            Console.WriteLine(DrivePath / DriveTime);
        }
        public Bicycle(string type, string factoryname, string model, string color, int drivetime, int drivepath) : base(factoryname, model, color, drivetime, drivepath)
        {
         _type= type;

        }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("none");
        }
    }
}
