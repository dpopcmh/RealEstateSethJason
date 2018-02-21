using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_new_
{
    class realtor
    {
        //CTQR

        public Realtor(string firstname, string lastname, string officestreetname, ushort officenumber, ushort officezipcode)
        {
            _firstname = firstname;
            _lastname = lastname;
            _officestreetname = officestreetname;
            _officenumber = officenumber;
            _officezipcode = officezipcode;
        }

        //Properties Go Here
        private string _firstname;
        public string firstname { get; set; }

        private string _lastname;
        public string lastname { get; set; }

        private string _officestreetname;
        public string officestreetname { get; set; }

        private ushort _officenumber;
        public ushort officenumber { get; set; }

        private ushort _officezipcode;
        public ushort officezipcode { get; set; }


        //Methods Go Here

    }
}
