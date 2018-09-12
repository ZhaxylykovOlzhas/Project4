using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Aircraft
    {
        protected int currentID = 0;
        public int _ID { get; set; }
        public string _NameOfAircraft { get; set; }
        public int _AgeAircraft { get; set; }
        public string _NameOfTheAirport { get; set; }
        public int _TakeoffWeight { get; set; }
        public string _Country { get; set; }
        
        public Aircraft()
        {
            _ID = 0;
            _NameOfAircraft = "F-43";
            _AgeAircraft = 5;
            _NameOfTheAirport = "Nazarbaev";
            _TakeoffWeight = 35;
            _Country = "Kazakstan";
        }
        public Aircraft(string NameOfAircraft,int AgeAircraft,string NameOfTheAirport, int TakeoffWeight,string Country)
        {
            _ID = GetNextID();
            _NameOfAircraft = _NameOfAircraft;
            _AgeAircraft = AgeAircraft;
            _NameOfTheAirport = NameOfTheAirport;
            _TakeoffWeight = TakeoffWeight;
            _Country = Country;
        }
        public  int GetNextID()
        {
            return ++currentID;
        }

        public void Update(int AgeAircraft, string NameOfTheAirport, string Country)
        {
            _AgeAircraft = AgeAircraft;
            _NameOfTheAirport = NameOfTheAirport;
            _Country = Country;
        }
    }

  
    public class TakeoffAircraft : Aircraft
    {
        public  int _SpeedAirplane { get; set; }
        public string _DepartureCity { get; set; }
        public DateTime _DepartureTime { get; set; }
        public string _PlantingCity { get; set; }
        public DateTime _PlantingTime { get; set; }
        public DateTime DepartureTimeYear { get; set; }

        public TakeoffAircraft(string NameOfAircraft,int AgeAircraft, string NameOfTheAirport, int TakeoffWeight, string Country,int SpeedAirplane)
        {
            _ID = GetNextID();
            _NameOfAircraft = NameOfAircraft;
            _AgeAircraft = AgeAircraft;
            _NameOfTheAirport  = NameOfTheAirport;
            _TakeoffWeight = TakeoffWeight;
            _Country = Country;
            _SpeedAirplane = SpeedAirplane;
        }

        public void DepartureList(string DepartureCity, DateTime DepartureTime,string PlantingCity, DateTime PlantingTime)
        {
            _DepartureCity = DepartureCity;
            _DepartureTime = DepartureTime;
            _PlantingCity = PlantingCity;
            _PlantingTime = PlantingTime;


        }
    }

    class Program
    {
        static void Main()
        {
           // TakeoffAircraft change = new TakeoffAircraft("SU-54",15,"NAzarbaev",49,"Kazakstan",3000);
           // Console.WriteLine("Номерация самолета:" + change._ID + "\nНазвание самолета:" + change._NameOfAircraft + "\nВозрасть самолета:" + change._AgeAircraft + " год" + "\nАэропорт:" + change._NameOfTheAirport);
           // Console.WriteLine("Вес самолета:" + change._TakeoffWeight + " т" + "\nСтрана:" + change._Country + "\nСкорость самолета:" + change._SpeedAirplane + " м/с\n");
           //DateTime DepartureTime1 = new DateTime(2018, 9, 21, 8, 30, 00);
           // DateTime PlantingTime1 = new DateTime(2018, 9, 21, 10, 05, 00);
           // change.DepartureList("Астана", DepartureTime1, "Алматы", PlantingTime1);
           // Console.WriteLine("Город вылета:"+change._DepartureCity+"\tВремя вылета:"+DepartureTime1+"\nГород прилета:"+change._PlantingCity+ "\tВремя прилета" + PlantingTime1);
           // DateTime DepartureTime2 = new DateTime(2018, 9, 23, 18, 10, 00);
           // DateTime PlantingTime2 = new DateTime(2018, 9, 23, 20, 20, 00);
           // change.DepartureList("Алматы", DepartureTime2, "Шымкент", PlantingTime2);
           // Console.WriteLine("\n\nГород вылета:" + change._DepartureCity + "\tВремя вылета:" + DepartureTime2 + "\nГород прилета:" + change._PlantingCity + "\tВремя прилета" + PlantingTime2);

            Money money = new Money(1000, 5);
            money.showMoney();
            Console.WriteLine("Введите стоймость товара:");
            int product;
            bool parsed = int.TryParse(Console.ReadLine(), out product);
            money.SetProduct(product);
            money.Purchase();
            int count = money.CountProduct();
            Console.WriteLine($"Количество товара,который вы можете покупать:={count}");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
