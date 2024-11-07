using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_3
{
    public class Car
    {
        public string ModelName;
        public string Manufacturer;
        public int YearOfProduction;
        public double EngineCapacity;
        public int SeatCount;
        public bool IsElectric;
        public double AverageFuelConsumption;

        public double GetFuelConsumptionPer100Km()
        {
            return AverageFuelConsumption;
        }

        public int GetCarAge()
        {
            return DateTime.Now.Year - YearOfProduction;
        }
    }
}
