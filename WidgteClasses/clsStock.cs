using System;

namespace WidgteClasses
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateArrived { get; set; }
        public static int Address { get; set; }

        //Not sure if the line below belongs here or in tstStock.cs
        DateTime TestData = DateTime.Now.Date;
    }
}