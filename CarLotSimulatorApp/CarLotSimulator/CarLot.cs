using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot() 
        {
        
        }
        public static int numberOfCars;

        public List<car> Cars{ get; set; } = new List<car>();
    }

}
