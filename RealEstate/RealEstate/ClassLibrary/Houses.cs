using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Houses
    {

        //Properties Go Here
        private string _StreetName;
        public string StreetName { get; set; }

        private ushort _HouseNumber;
        public ushort HouseNumber { get; set; }

        private ushort _Zipcode;
        public ushort Zipcode { get; set; }

        private ulong _AskingPrice;
        public ulong AskingPrice { get; set; }

        private Single _Bathrooms;
        public Single Bathrooms { get; set; }

        private ushort _Bedrooms;
        public ushort Bedrooms { get; set; }

        private bool _Basement;
        public bool Basement { get; set; }

        private ushort _PropertySize;
        public ushort PropertySize { get; set; }

        private string _City;
        public string City { get; set; }

        private string _State;
        public string State { get; set; }

        private bool _Gasheating;
        public bool GasHeating { get; set; }

        private bool _ElectricHeating;
        public bool ElectricHeating { get; set; }

        private string _AirConditioning;
        public string AirConditioning { get; set; }

        private bool _WaterRights;
        public bool WaterRights { get; set; }

        private ushort _stories;
        public ushort Stories { get; set; }

        private ushort _PreviousOwners;
        public ushort PreviousOwners { get; set; }


        //Methods Go Here 
    }
}
