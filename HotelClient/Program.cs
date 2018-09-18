using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelClient.ServiceReference1;

namespace HotelClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelServiceClient serviceProvider = new HotelServiceClient("BasicHttpBinding_IHotelService");
            Console.WriteLine("Enter Your Choice:");
            Console.WriteLine("1. Get All Hotels");
            Console.WriteLine("2. Get Hotel By Id");
            Console.WriteLine("3. Exit");
            var userChoice = 0;
            int hotelId = 0;
            int.TryParse(Console.ReadLine(),out userChoice);
            switch(userChoice)
            {
                case 1:
                    List<Hotel> HotelsList = serviceProvider.GetAllHotels().ToList();
                    foreach(var hotel in HotelsList)
                    {
                        Console.WriteLine("HotelId:"+hotel.HotelId);
                        Console.WriteLine("HotelName:" + hotel.HotelName);
                        Console.WriteLine("HotelAddress"+hotel.Address);
                        Console.WriteLine("Rating:" + hotel.StarRating);
                        Console.WriteLine("Price:"+hotel.Price);
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the Hotel Id:");
                    hotelId = int.Parse(Console.ReadLine());
                    Hotel property = serviceProvider.GetHotelById(hotelId);
                    Console.WriteLine("HotelId:" + property.HotelId);
                    Console.WriteLine("HotelName:" + property.HotelName);
                    Console.WriteLine("HotelAddress" + property.Address);
                    Console.WriteLine("Rating:" + property.StarRating);
                    Console.WriteLine("Price:" + property.Price);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter a valid Input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
