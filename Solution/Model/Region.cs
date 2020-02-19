using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Region
    {
        private int regionId;
        private string regionDescription;

        public Region(int regionId, string regionDescription)
        {
            this.regionId = regionId;
            this.regionDescription = regionDescription;
        }

        public int RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public string RegionDescription
        {
            get { return regionDescription; }
            set { regionDescription = value; }
        }

    }
}
