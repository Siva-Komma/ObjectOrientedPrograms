using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Jyothi\\Desktop\\New1\\.Net\\InventoryManagement\\InventoryManagement\\Iventory.json";
            FetchInventory fetchinventory = new FetchInventory();
            // InventoryDetail data = new InventoryDetail();
            InventoryDetail data = fetchinventory.Read(path);
            Console.WriteLine("Types of Rice");
            Console.WriteLine("*******************************");
            for (int i = 0; i < data.typeofRice.Count; i++)
            {
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].price);
                int price = data.typeofRice[i].weight * data.typeofRice[i].price;
                Console.WriteLine("The price of {0} for {1}kg is {2}",
                    data.typeofRice[i].name, data.typeofRice[i].weight,price);
            }
            Console.WriteLine("Types of Pulses");
            Console.WriteLine("*******************************");
            for (int i = 0; i < data.typeofPulses.Count; i++)
            {
                Console.WriteLine(data.typeofPulses[i].name);
                Console.WriteLine(data.typeofPulses[i].weight);
                Console.WriteLine(data.typeofPulses[i].price);
                int price1 = data.typeofPulses[i].weight * data.typeofPulses[i].price;
                Console.WriteLine("The price of {0} for {1}kg is {2}",
                    data.typeofPulses[i].name, data.typeofPulses[i].weight, price1);
            }
        
            Console.WriteLine("Types of Wheat");
            Console.WriteLine("*******************************");
            for (int i = 0; i < data.typeofWheat.Count; i++)
            {
                Console.WriteLine(data.typeofWheat[i].name);
                Console.WriteLine(data.typeofWheat[i].weight);
                Console.WriteLine(data.typeofWheat[i].price);
                int price2 = data.typeofWheat[i].weight * data.typeofWheat[i].price;
                Console.WriteLine("The price of {0} for {1}kg is {2}",
                    data.typeofWheat[i].name, data.typeofWheat[i].weight,price2);
            }
            Console.ReadLine();
        }
    }
}
