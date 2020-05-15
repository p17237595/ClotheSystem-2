using System;
using WidgteClasses;


namespace WidgteClasses
{
  
    public class clsStock
    {

        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //private data member for Gender
        private string mGender;
        //public property for Gender
        public string Gender
        {
            get
            {
                //return private data
                return mGender;
            }
            set
            {
                //set the private data
                mGender = value;
            }
        }

        //private data member for Size
        private string mSize;
        //public property for Size
        public string Size
        {
            get
            {
                //return private data
                return mSize;
            }
            set
            {
                //set the private data
                mSize = value;
            }
        }

        //private data member for Description
        private string mDescription;
        //public property for Description
        public string Description
        {
            get
            {
                //return private data
                return mDescription;
            }
            set
            {
                //set the private data
                mDescription = value;
            }
        }




        //private data member for Price
        private Double mPrice;
        //public property for Price
        public Double Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the value of the private data member
                mPrice = value;
            }
        }

        //private data member for InStock
        private Boolean mInStock;
        //public property for InStock
        public bool InStock
        {
            get
            {
                //return the private data
                return mInStock;
            }
            set
            {
                //set the private data
                mInStock = value;
            }
        }

        //private date arrived data member
        private DateTime mDateArrived;
        //public property for date arrived
        public DateTime DateArrived
        {
            get
            {
                //return the private data
                return mDateArrived;
            }
            set
            {
                //set the private data
                mDateArrived = value;
            }
        }



        public bool Find(int Price)
        {
            //set the private data members to the test data value
            mGender = "Male";
            mSize = "Medium";
            mDescription = "A lovely t-shirt";
            mPrice = 21.89;
            mInStock = true;
            mDateArrived = Convert.ToDateTime("16/9/2015");
            mActive = true;
            //always return true
            return true;
        }

        public string Valid(string Gender, string DateArrived, string Description, string Price, string Size)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Gender is blank
            if (Gender.Length == 0)
            {
                //record the error
                Error = Error + "The gender may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (Gender.Length > 6)
            {
                //record the error
                Error = Error + "The gender no must be less than 6 characters, please use 'Male' or 'Female' : ";
            }
            try
            {
                //copy the DateArrived value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateArrived);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the Description blank
            if (Description.Length == 0)
            {
                //record the error
                Error = Error + "The Description may not be blank : ";
            }
            //if the Description is too long
            if (Description.Length > 256)
            {
                //record the error
                Error = Error + "The Description must be less than 256 characters : ";
            }
            //is the Price blank
            if (Price.Length == 0)
            {
                //record the error
                Error = Error + "The Price may not be blank : ";
            }
            //if the street is too long
            if (Price.Length > 15)
            {
                //record the error
                Error = Error + "The Price must be less than 15 characters : ";
            }
            //is the Size blank
            if (Size.Length == 0)
            {
                //record the error
                Error = Error + "The Size may not be blank : ";
            }
            //if the Size is too long
            if (Size.Length > 5)
            {
                //record the error
                Error = Error + "The Size must be less than 5 characters : ";
            }
            //return any error messages
            return Error;
        }
    }

}