using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override_Task.Models
{
    internal class Bicycle
    {
        public string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Bicycle(string type)
        {
            _type = type;
        }
        public override string ToString()
        {
            return $"Bicycle: Type = {Type}";
        }
    }
}
