using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Model
{
    public class CarMarka
    {
        private static int count = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public CarMarka(string name)
        {
            Name = name;
            ID = count;
            count++;
        }
    }
}
