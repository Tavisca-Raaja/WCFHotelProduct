using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsProduct
{
    class HotelService:IHotelService
    {
        public List<Hotel> GetAllHotels()
        {
            using (StreamReader sReader = new StreamReader("C:\\Users\\rgouthaman\\source\\repos\\HotelsProduct\\HotelsProduct\\HotelData.json"))
            {
                string json = sReader.ReadToEnd();
                List<Hotel> items = JsonConvert.DeserializeObject<List<Hotel>>(json);
                return items;
            }

        }
        public Hotel GetHotelById(int hotelId)
        {

            List<Hotel> items;
            using (StreamReader sReader = new StreamReader("C:\\Users\\rgouthaman\\source\\repos\\HotelsProduct\\HotelsProduct\\HotelData.json"))
            {
                string json = sReader.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Hotel>>(json);
            }
                Hotel found= items.Find(extract => extract.HotelId==hotelId);
                if (found== null)
                    throw new Exception();
                return found;
            
        }
    }
}
