using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass.Models
{
    internal abstract class Vehicle
    {
        public string _factoryName;
        public string _model;
        public string _color;
        public int _driveTime;
        public int _drivePath;

        public string FactoryName
        {
            get
            {
                return _factoryName;
            }
            set { _factoryName = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }
        public int DrivePath
        {
            get { return _drivePath; }
            set { _drivePath = value; }
        }
        public Vehicle(string factoryname, string model, string color, int drivetime, int drivepath)
        {
            _color = color;
            _factoryName = factoryname;
            _model = model;
            _driveTime = drivetime;
            _drivePath = drivepath;

        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory name: {FactoryName}, Model: {Model}, Color: {Color}, Drive time: {DriveTime}, Drive path: {DrivePath}");
        }
        public abstract void DefineNatureHarmness();
        public override string ToString()
        {
            return $"{FactoryName} {Model}";
        }
    }
}

