using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        class Auto
        {
            private string name;
            private int price;
            private int volEngine;
            private string typeTrans;
            private int MaxSpeed;
            private double Acceleration_to_100;

            public Auto()
            {
                name = " ";
                price = 0;
                volEngine = 0;
                typeTrans = " ";
                MaxSpeed = 0;
                Acceleration_to_100 = 0;
            }
            public Auto(string name,int price, int volEngine, string typeTrans, int MaxSpeed, double Acceleration_to_100)
            {
                this.name = name;
                this.price = price;
                this.volEngine = volEngine;
                this.typeTrans = typeTrans;
                this.MaxSpeed = MaxSpeed;
                this.Acceleration_to_100 = Acceleration_to_100;
            }
            public void Input_TX()
            {
                Console.WriteLine("Введите название авто: ");
                name = Console.ReadLine();
                Console.WriteLine("Введите цену: ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите объём двигателя: ");
                volEngine = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите тип коробки передач: ");
                typeTrans = Console.ReadLine();
                Console.WriteLine("Введите максимальную скорость: ");
                MaxSpeed= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите время разгона до 100км/ч: ");
                Acceleration_to_100 = Convert.ToDouble(Console.ReadLine());

            }
            public void Print_TX()
            {
                Console.WriteLine($"Название автомобиля: {name}");
                Console.WriteLine($"Цена: {price} руб");
                Console.WriteLine($"Объём двигателя: {volEngine} л");
                Console.WriteLine($"Тип коробки передач: {typeTrans}");
                Console.WriteLine($"Максимальная скорость: {MaxSpeed} км/ч");
                Console.WriteLine($"Разгон до 100 км/ч: {Acceleration_to_100} с");
            }
            // struct Engine
            //{
            //    private double volume ;
            //    private string type;

            //    public double Volume { get { return volume; } set { volume = value; } }
            //    public string Type { get { return type; } set { type = value; } }

            //    public Engine(double volume,string type)
            //    {
            //        this.volume = volume;
            //        this.type = type;
            //    }
            //}
            //struct Transmission
            //{
            //    string type;
            //}
            //struct Drive_unit
            //{
            //    string type;
            //}
            //struct Consumption
            //{
            //    string cons;
            //}
            //struct Acceleration_to_100
            //{
            //    double acceler;
            //}
        }
        static void Main(string[] args)
        {
            Auto lycan = new Auto();
            lycan.Input_TX();
            lycan.Print_TX();
            
            
        }
    }
}
