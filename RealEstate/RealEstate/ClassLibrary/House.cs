﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class House
    {

        public House()
        {

        }
        //CTQR 
        public House(ushort housenumber, ushort zipcode, ulong askingprice, Single bathrooms, ushort bedrooms, float propertysize, string city, string state, int hoafees, string streetname)
        {
            _houseNumber = housenumber;
            _zipcode = zipcode;
            _askingprice = askingprice;
            _bathrooms = bathrooms;
            _bedrooms = bedrooms;
            _propertySize = propertysize;
            _city = city;
            _state = state;
            _hoafees = hoafees;
            _leaselength = leaselength;
            _pets = pets;
            _unitnumber = unitnumber;
            _smoking = smoking;
            _zonedtype = zonedtype;
            _pricepersqrfoot = pricepersqrfoot;
            _leaseorown = leaseorown;
            _streetName = streetname;

        }

        //Properties Go Here

        //all properties
        private string _streetName;
        public string streetName { get; set; }

        private ushort _houseNumber;
        public ushort houseNumber { get; set; }

        private int _zipcode;
        public int zipcode { get; set; }

        private ulong _askingprice;
        public ulong askingprice { get; set; }

        private double _bathrooms;
        public double bathrooms { get; set; }

        private ushort _bedrooms;
        public ushort bedrooms { get; set; }

        private float _propertySize;
        public float propertySize { get; set; }

        private string _city;
        public string city { get; set; }

        private string _state;
        public string state { get; set; }

        private int _hoafees;
        public int hoafees { get; set; }

        //Condo Properties
        private int _leaselength;
        public int leaselength { get; set; }

        private bool _pets;
        public bool pets { get; set; }

        private int _unitnumber;
        public int unitnumber { get; set; }

        private bool _smoking;
        public bool smoking { get; set; }

        //commercial properties
        private string _zonedtype;
        public string zonedtype { get; set; }

        private uint _pricepersqrfoot;
        public uint pricepersqrfoot { get; set; }

        private string _leaseorown;
        public string leaseorown { get; set; }

       
    }
}


