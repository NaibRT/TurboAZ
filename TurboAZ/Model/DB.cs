using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Model
{
    public class DB
    {
        public static List<User> Users = new List<User>() { new User("Naib", "naib@gmail.com", "1234567", "+9947894556") };
        public static List<Car> Cars = new List<Car>();

        public static List<CarMarka> CarM = new List<CarMarka>() {
          new CarMarka("Audi"),
          new CarMarka("Bently"),
          new CarMarka("BMW"),
          new CarMarka("Ford"),
          new CarMarka("Kia"),
          new CarMarka("Lada"),
          new CarMarka("Lexus"),
          new CarMarka("Mercedes"),

          };

        public static List<CarModel> CarModels = new List<CarModel>() {
            new CarModel("A3",1),
            new CarModel("A4",1),
            new CarModel("A5",1),
            new CarModel("A6",1),
            new CarModel("A7",1),
            new CarModel("A8",1),
            new CarModel("Q3",1),
            new CarModel("Q5",1),
            new CarModel("Q7",1),
            new CarModel("Q8",1),

            new CarModel("Bentayga",2),
            new CarModel("Continental",2),
            new CarModel("Flying Spur",2),
            new CarModel("Mulsanne",2),

            

            new CarModel("M3",3),
            new CarModel("M5",3),
            new CarModel("M6",3),
            new CarModel("X5 M",3),
            new CarModel("X6 M",3),
            new CarModel("X1",3),
            new CarModel("X5",3),
            new CarModel("X6",3),



            new CarModel("Capri",4),
            new CarModel("Cargo",4),
            new CarModel("Contour",4),
            new CarModel("Cougar",4),
            new CarModel("Escort",4),
            new CarModel("Focus",4),
            new CarModel("Mustang",4),



            new CarModel("Avella",5),
            new CarModel("Bongo",5),
            new CarModel("Cadenza",5),
            new CarModel("Credos",5),
            new CarModel("Joice",5),
            new CarModel("Optima",5),
            new CarModel("Rio",5),


            new CarModel("Granta",6),
            new CarModel("Kalina",6),
            new CarModel("Largus",6),
            new CarModel("Niva",6),
            new CarModel("Oka",6),
            new CarModel("Priora",6),
            new CarModel("Vesta",6),


            new CarModel("--- ES 250",7),
            new CarModel("--- ES 300",7),
            new CarModel("--- ES 350",7),
            new CarModel("--- GS 250",7),
            new CarModel("--- GS 300",7),
            new CarModel("--- GS 350",7),
            new CarModel("--- GX 460",7),



            new CarModel("--- C 180",8),
            new CarModel("--- C 200",8),
            new CarModel("--- C 220",8),
            new CarModel("--- C 63 AMG",8),
            new CarModel("--- CL 550",8),
            new CarModel("--- CLA 250",8),
            new CarModel("--- CLS 55 AMG",8),


        };
    }
}
