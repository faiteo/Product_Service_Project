using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Product_Service_Project
{
    [DataContract]
    public class CD:Product
    {
        private string artistName;
        private int numberOfTracks;

        [DataMember]
        public string ArtistName
        {
            get
            {
                return artistName;
            }

            set
            {
                artistName = value;
            }
        }

        [DataMember]
        public int NumberOfTracks
        {
            get
            {
                return numberOfTracks;
            }

            set
            {
                numberOfTracks = value;
            }
        }
    }
}
