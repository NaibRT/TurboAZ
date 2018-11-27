using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Model
{
    public class Car
    {
        private static int count = 1;

        public int ID { get; private set; }
        public int UserID { get;set; }


        public string City { get; set; }
        public string Marka { get; set; }
        public string  Model { get; set; }
        public DateTime Year { get; set; }
        public string BanType { get; set; }
        public string Color { get; set; }
        public float MotorVolume { get; set; }
        public int HorsePover { get; set; }
        public string FuelType { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public string GearType { get; set; }
        public bool New { get; set; }
        public int Price { get; set; }


        public Car(string city, string marka, string model, string year, string banType, string color, string moororVolume, string hoursePover, string flueType, string mileage, string transmission, string gaerType, string @new, string prise,int id)
        {
            ID = count;

            UserID = id;
            City = city;
            Marka = marka;
            Model = model;
            Year =Convert.ToDateTime(year);
            BanType = banType;
            Color = color;
            MotorVolume =float.Parse( moororVolume);
            HorsePover =Convert.ToInt32( hoursePover);
            FuelType = flueType;
            Mileage = Convert.ToInt32(mileage);
            Transmission = transmission;
            GearType = gaerType;
            New = Convert.ToBoolean(@new);
            Price = Convert.ToInt32(prise);

            count++;
        }


    }
}
