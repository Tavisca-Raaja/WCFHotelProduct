using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelsProduct
{
    [ServiceContract]
    interface IHotelService
    {
        [OperationContract]
        List<Hotel> GetAllHotels();

        [OperationContract]
        Hotel GetHotelById(int id);
    }
}
