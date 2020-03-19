using System;
using WidgteClasses;


namespace WidgteClasses
{
    public class clsStock
    {
        public bool Active { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public DateTime DateArrived { get; set; }


        //Not sure if the line below belongs here or in tstStock.cs
        DateTime TestData = DateTime.Now.Date;


        //Where does this stuff go? I'm not sure.


    }

}