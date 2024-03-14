using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    public class Cargo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public string Dimensions { get; set; }
        public string Description { get; set; }
        public int Client_ID { get; set; }
        public override string ToString()
        {
            return $"{ID}, {Name}, {Weight}, {Dimensions}, {Description}, {Client_ID}" + Environment.NewLine;
        }
    }
}
