using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Ship> ships = new List <Ship> ();
            
            int Degree;
            float Minutes;
            string SerialNo;
            char Direction;

            while (true)
            {
                
                Console.WriteLine("1. Add Ship");
                Console.WriteLine("2. View Ship Position");
                Console.WriteLine("3. View Ship Serial Number");
                Console.WriteLine("4. Change Ship Position");
                Console.WriteLine("5. Exit");
                int Option = int.Parse(Console.ReadLine());
                if (Option == 1)
                {
                    Console.WriteLine("Enter Ship Number");
                    SerialNo = Console.ReadLine();
                    Console.WriteLine("Enter Longitude");
                    Console.WriteLine("Enter Degree");
                    Degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Minutes");
                    Minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Direction");
                    Direction = Console.ReadLine()[0];
                    Angle Longitude = new Angle(Degree, Minutes, Direction);
                    Console.WriteLine("Enter Latitude");
                    Console.WriteLine("Enter Degree");
                    Degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Minutes");
                    Minutes = float.Parse(Console.ReadLine()); ;
                    Console.WriteLine("Enter Direction");
                    Direction = Console.ReadLine()[0];
                    Angle Latitude = new Angle(Degree, Minutes, Direction);
                    Ship ship = new Ship(SerialNo, Latitude, Longitude);
                    ships.Add(ship);
                    
                }
                if (Option == 2)
                {
                    Console.WriteLine("enter serial No");
                    string Number = Console.ReadLine();
                    foreach(Ship data in ships)
                    {
                        if (Number == data.SHip_No)
                        {
                            Console.WriteLine($"Ship is at {data.Latitude.Degree}°{data.Latitude.Minutes}'{data.Latitude.Direction} Latitude and {data.Longitude.Degree}°{data.Longitude.Minutes}'{data.Longitude.Direction} Logitude");
                        }
                    }
                }
                if (Option == 3)
                {
                    string deg,deg1;
                    string min,min1;
                    string dir,dir1;
                    string Latitude ,Longitude;
                    //for taking input of latitude
                    Console.WriteLine("Enter Latitude");
                    Console.WriteLine("Enter Degree");
                    deg = Console.ReadLine();
                    Console.WriteLine("Enter Minutes");
                    min = Console.ReadLine();
                    Console.WriteLine("Enter Direction");
                    dir = Console.ReadLine();
                    Latitude = deg+"°"+min+"'"+dir;

                    //input logitude
                    Console.WriteLine("Enter Longitude");
                    Console.WriteLine("Enter Degree");
                    deg1 = Console.ReadLine();
                    Console.WriteLine("Enter Minutes");
                    min1 = Console.ReadLine();
                    Console.WriteLine("Enter Direction");
                    dir1 = Console.ReadLine();
                    Longitude = deg1+"°"+min1+"'"+dir1;
                    foreach (Ship data1 in ships)
                    {
                        if (data1.Latitude.Display() == Latitude && data1.Longitude.Display() == Longitude )
                        {
                            Console.WriteLine($"Serial Number of ship is: {data1.SHip_No}");
                        }
                        else { Console.WriteLine("not found"); }
                    }
                 
                }
                if (Option == 4)
                {
                    string ShipNo;
                    Console.WriteLine("Enter Ship Number");
                    ShipNo = Console.ReadLine();
                    foreach (Ship data1 in ships)
                    {
                        if (data1.SHip_No == ShipNo)
                        {
                            Console.WriteLine("Enter Ship Longitude");
                            Console.WriteLine("Enter Degree");
                            data1.Longitude.Degree = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Minutes");
                            data1.Longitude.Minutes = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Direction");
                            data1.Longitude.Direction = Console.ReadLine()[0];
                            Console.WriteLine("Enter Latitude");
                            Console.WriteLine("Enter Degree");
                            data1.Latitude.Degree = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Minutes");
                            data1.Latitude.Minutes = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Direction");
                            data1.Latitude.Direction = Console.ReadLine()[0];
                            Console.WriteLine("Ship's Location has been changed");

                        }
                        if (Option == 5)
                        {
                            break;
                        }
                    }
                }    
            }
        }
    }
}
