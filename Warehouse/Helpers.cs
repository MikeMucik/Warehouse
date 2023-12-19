using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Helpers
    {
        public int GiveNumber()
        {
            SomeStructure stru = new SomeStructure();
       
            int number = 7;

            return number;
        }
    }
    public enum ItemTypes
    {
        Cups,
        Forks,
        Knifes
    }


    public struct SomeStructure
    {
        public int numberForStructure;
        public string nameOfStructure;

        public SomeStructure(int number, string name)
        {
            numberForStructure = number;
            nameOfStructure = name;
        }

    }
}
