using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Model
{
    public class CarModel
    {
        private static int count = 1;
        public int ID { get; private set; }
        public int MarkID { get; set; }
        public string Name { get; set; }

        public CarModel(string name,int markaid)
        {
            ID = count;
            Name = name;
            MarkID = markaid;
            count++;
        }

    }
}
