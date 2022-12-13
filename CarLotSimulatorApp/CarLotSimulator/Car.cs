using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car(int year, string make, string model, string enginenoise, string honknoise,bool isdrivable)
        {
            CarLot.numberOfCars++;
            
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;

        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }
        public bool isDrivable { get; set; }
        public void MakeEngineNoise(string sound)
        {
            Console.WriteLine($"Engine: {sound}");
        }
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"Horn: {noise}");
        }

    }

}
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property
