using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Land
    {
        //Properties go here
        private ushort _PropertySize;
        public ushort Propertysize { get; set; }

        private bool _WaterRights;
        public bool WaterRights { get; set; }

        private bool _FarmLand;
        public bool FarmLand { get; set; }

        private bool _buildingLot;
        public bool Buildinglot { get; set; }


        //Methods Go Here

    }
}
