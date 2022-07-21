using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kilometers
    {
        public int value;
        public Kilometers(int value)
        {
            this.value = value;
        }
           
        public void SaveValueToFile(string path, int value)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(value.ToString());
            sw.Close();
        }

        public int ConvertToMeters()
        {
            return this.value * 1000;
        }
    }
}
