using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Model
{
    public class Car
    {


        public string City { get; set; }
        public string Marka { get; set; }
        public string  Model { get; set; }
        public DateTime Year { get; set; }
        public string BanType { get; set; }
        public string Color { get; set; }
        public float MotorVolume { get; set; }
        public int HoursePover { get; set; }
        public string FlueType { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public string GaerType { get; set; }
        public bool New { get; set; }
        public int Prise { get; set; }


        public Car(string city, string marka, string model, int year, string banType, string color, string moororVolume, int hoursePover, string flueType, int mileage, string transmission, string gaerType, bool @new, int prise)
        {
            City = city;
            Marka = marka;
            Model = model;
            Year =Convert.ToDateTime(year);
            BanType = banType;
            Color = color;
            MotorVolume =float.Parse( moororVolume);
            HoursePover = hoursePover;
            FlueType = flueType;
            Mileage = mileage;
            Transmission = transmission;
            GaerType = gaerType;
            New = Convert.ToBoolean(@new);
            Prise = prise;
        }


    }
}
