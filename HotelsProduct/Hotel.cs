using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelsProduct
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public int HotelId;
        [DataMember]
        public string HotelName;
        [DataMember]
        public string Address;
        [DataMember]
        public int StarRating;
        [DataMember]
        public int Price;
    }
}
