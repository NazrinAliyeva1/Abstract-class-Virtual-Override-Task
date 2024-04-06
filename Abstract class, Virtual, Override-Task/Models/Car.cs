using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override_Task.Models
{
    internal class Car
    {
        private int _doorCount;
        private bool _isElectric = true;

        public int DoorCount
        {
            get { return _doorCount; }
            set { _doorCount = value; }
        }
        public bool IsElectric
        {
            get { return _isElectric; }
            set
            {
                if (_isElectric)
                {
                    _isElectric = value;
                }
                else
                {
                    Console.WriteLine("Bu masin eletrikle islemir.");
                }
            }
        }
        public Car(int doorcount, bool isElectric)
        {
            _doorCount = doorcount;
            _isElectric = isElectric;
        }
        public override string ToString()
        {
            return $"Car: DoorCount = {DoorCount}, IsElectricCar = {_isElectric}";
        }
    }
}
