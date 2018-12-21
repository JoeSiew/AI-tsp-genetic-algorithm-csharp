using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    // City is the gene of chromosome, gene is basically the City.
    // [Kuala Lumpur] = [0] , [Kota Bahru] = [1] and so on.
    public class City
    {
        private string[] cityNameData = new string[8] 
        {"Kuala Lumpur" , "Kota Bahru","Kuantan","Alor Setar","Seremban","Melaka","Ipoh","Georgetown" };

        //instance variable
        private int city_ID;
        private string city_Name;

        // properties
        public int City_ID
        { get { return city_ID; } set { city_ID = value; } }

        public string City_Name
        {   get { return city_Name; }   set { city_Name = value; }  }

        //constructor
        public City(int theCity_ID)
        {
            this.city_ID = theCity_ID;
            this.city_Name = cityNameData[theCity_ID];
        }
    }

}
