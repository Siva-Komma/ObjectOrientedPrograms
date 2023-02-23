using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InventoryDetail
    {
        // public TypeOfRice typeofRice;
        public List<TypeOfRice> typeofRice;
        public List<TypeOfPulses> typeofPulses;
        public List<TypeOfWheat> typeofWheat;
    }
    public class TypeOfRice
    {
        public String name;
        public int weight;
        public int price;
    }
    public class TypeOfPulses
    {
        public String name;
        public int weight;
        public int price;
    }
    public class TypeOfWheat
    {
        public String name;
        public int weight;
        public int price;
    }
}
