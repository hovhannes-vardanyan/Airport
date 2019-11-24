using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    
    
    class Airport 
    {
        //Small, Medium,  Large, Mega, SuperMega. 
        public string Name { get; private set; }
        public string CountryCode { get; private set; }
        public string Size { get; private set; }

        // def constructor
        public Airport(string name, string countryCode,string size)
        {
            this.Name = name;
            this.CountryCode = countryCode;
            this.Size = size;
        }
 
        public override string ToString()
        {
            return $"Name: {this.Name}, CountryCode: {this.CountryCode}, Size:{this.Size} ";
        }
    }
}
