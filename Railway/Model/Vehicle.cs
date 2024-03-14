using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Year_of_Manufacture { get; set; }
        public string Registration_Number { get; set; }
        public override string ToString()
        {
            return $"{ID}, {Type}, {Year_of_Manufacture}, {Registration_Number}" + Environment.NewLine;
        }
    }
}
