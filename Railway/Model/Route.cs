using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    public class Route
    {
        public int ID { get; set; }
        public string Start_Location { get; set; }
        public string End_Location { get; set; }
        public decimal Distance { get; set; }
        public int Duration { get; set; }
        public int Cargo_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public override string ToString()
        {
            return $"{ID}, {Start_Location}, {End_Location}, {Distance}, {Duration}, {Cargo_ID}, {Vehicle_ID}" + Environment.NewLine;
        }
    }
}
