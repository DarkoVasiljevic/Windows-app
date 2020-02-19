using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class Territories : Region
    {
        private int territoryId;
        private string territoryDescription;
        private int regionId;

        public Territories(int territoryId, string territoryDescription, int regionId)
            : base(regionId, territoryDescription)
        {
            this.territoryId = territoryId;
        }

        public int TerritoryId
        {
            get { return territoryId; }
            set { territoryId = value; }
        }

        public string TerritoryDescription
        {
            get { return territoryDescription; }
            set { territoryDescription = value; }
        }

        public int RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        
    }
}
