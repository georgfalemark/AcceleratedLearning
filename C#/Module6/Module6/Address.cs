using System;
using System.Collections.Generic;
using System.Text;

namespace Module6
{
    public class Address
    {

        private string _zipcode; // "123 45"

        //public int ZipCode { get; set; }

        public Address()
        {

        }

        public string GetZipCode()
        {
            return _zipcode;
        }

        public void SetZipCode(string z)
        {
            _zipcode = z;


            if (_zipcode == null)
            {
                return false;
            }

            if (_zipcode > 6)
            {
                return false;
            }

            if (_zipcode )
            {

            }


        }


        //public string Street { get; set; }
        //public string StreetNumber { get; set; }
        //public string City { get; set; }
        //public int ZipCode { get; set; }
        // public string FullStreet => Street + StreetNumber;

        //public string FullStreet
        //{
        //    get { return Street + StreetNumber; }
        //}

    }
}
