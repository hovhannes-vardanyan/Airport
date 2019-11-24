using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    enum Sizes
    {
        Small,
        Medium,
        Large,
        Mega,
        SuperMega

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Airport> Airports = new List<Airport>()
            {
              new Airport(name: "Zvartnoc", countryCode: "+374", size: "Small"),
              new Airport(name: "Jacksonville International Airport", countryCode: "+1", size: "Medium"),
              new Airport(name: "Hong Kong International Airportrt", countryCode: "+852", size: "SuperMega"),
              new Airport(name: "Tampa International Airport", countryCode: "+1", size: "Large"),
              new Airport(name: "Frankfurt Airport", countryCode: "+49", size: "Mega")
            };
            Airports = SortWithSize(Airports);
            foreach (var airport in Airports)
            {
                Console.WriteLine(airport);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Dasavorum yst chaperi
        /// </summary>
        /// <param > List<Airport> Airports </param>
        /// <returns> List<Airport> sortedAirports </returns>
        static List<Airport> SortWithSize(List<Airport> Airports)
        {
            List<Airport> sortedAirports = Airports;

            // bubble sort
            for (int k = 0; k < sortedAirports.Count; k++)
            {
                for (int i = 0; i < sortedAirports.Count - 1; i++)
                {
                    if (Compare(sortedAirports[i].Size, sortedAirports[i + 1].Size) == 0) // Compare funkcian veradarcnum e 1 kam 0, 0 i depqum katarvum e texpoxum
                    {
                        var temp = sortedAirports[i];
                        sortedAirports[i] = sortedAirports[i + 1];
                        sortedAirports[i + 1] = temp;
                    }
                }
            }
            return sortedAirports;
        }

        /// <summary>
        /// Hamematum e stacvac string-nery
        /// </summary>
        /// <param name="size_1"> string </param>
        /// <param name="size_2"> string </param>
        /// <returns> 0 || 1 </returns>
        static int Compare(string size_1, string size_2)
        {
            //size_1 & size_2 i hamar stexcvum en hamapatasxan enum andamnery
            Sizes enum_size1;
            Enum.TryParse<Sizes>(size_1.ToString(), out enum_size1);
            Sizes enum_size2;
            Enum.TryParse<Sizes>(size_2.ToString(), out enum_size2);
            // hamematutyuny katarvum e enum andamnerov 
            if (enum_size1 > enum_size2)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }



}
