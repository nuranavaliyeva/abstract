using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass.Models
{
    internal class Car:Vehicle
    {
        public int _doorCount;
        public bool _isElectricCar;
        public int DoorCount
        {
            get { return _doorCount; }
            set { _doorCount = value; }
        }
        public bool IsElectricCar
        {
            get { return _isElectricCar; }
            set { IsElectricCar = value; }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Door count: {DoorCount}, Is Electric car: {IsElectricCar}");
            base.GetInfo();
        }
        public void AverageSpeed()
        {
            Console.WriteLine(DrivePath / DriveTime);
        }
        public Car(int doorCount, bool isElectricCar, string factoryname, string model, string color, int drivetime, int drivepath):base(factoryname, model, color, drivetime, drivepath) 
        {
            _doorCount = doorCount;
            _isElectricCar = isElectricCar;
           
        }
        public override void DefineNatureHarmness()
        {
            if (IsElectricCar) {
                Console.WriteLine("low");
            }
            else
            {
                Console.WriteLine("high");
            }
            
        }
    }
}
