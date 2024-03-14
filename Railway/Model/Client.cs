using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact_Phone { get; set; }
        public override string ToString()
        {
            return $"{ID}, {Name}, {Address}, {Contact_Phone}" + Environment.NewLine;
        }
    }
}
