using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override_Task.Models
{
    internal abstract class Vehicle
    {
        string _factoryName;
        string _model;
        string _color;
        double _driveTime;
        double _drivePath;

        public string FactoryName
        {
            get { return _factoryName; }
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
        public double DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }
        public double DivePath
        {
            get { return _drivePath; }
            set { _drivePath = value; }
        }

        public double AverageSpeed()
        {
            if (DriveTime <= 0 || DivePath <= 0)
            {
                throw new Exception("DriveTime ve DivePath musbet olmalidir.");
            }
            return DivePath / DriveTime;
        } 

        public virtual void GetInfo()
        {
            Console.WriteLine($"{FactoryName}, {Model}, {Color}, {DriveTime}, {DivePath}");
        }

        protected Vehicle(string factoryname, string model, string color, double drivetime, double drivepath)
        {
            _factoryName = factoryname;
            _model = model;  
            _color = color;
            _driveTime = drivetime;
            _drivePath = drivepath;


        }
        public abstract void DefineNatureHarmness();

        public override string ToString() => "{FactoryName} {Model}";

        //benzinle isleyen masin
        public class GasolineVehicle : Vehicle
        {
            public GasolineVehicle(string factoryname, string model, string color, double drivetime, double drivepath) : base(factoryname, model, color, drivetime, drivepath) { }
            public override void DefineNatureHarmness()
            {
                Console.WriteLine("Harmness level: High (Benzinle isleyen))");
            }
        }

        //Elektrikle isleyen masin

        public class ElectricVehicle : Vehicle
        {
            public ElectricVehicle(string factoryname, string model, string color, double drivetime, double drivepath) : base(factoryname, model, color, drivetime, drivepath) { }
            public override void DefineNatureHarmness()
            {
                Console.WriteLine("Harmness level: Low(Elektrikle isleyen)");
            }
        }

        //Motorsuz isleyen masin
        public class MotorlessVehicle : Vehicle
        {
            public MotorlessVehicle(string factoryname, string model, string color, double drivetime, double drivepath) : base(factoryname, model, color, drivetime, drivepath) { }

            public override void DefineNatureHarmness()
            {
                Console.WriteLine("Harmness level: None (Motorsuz ishleyen)");
            }
        }


    }
}
