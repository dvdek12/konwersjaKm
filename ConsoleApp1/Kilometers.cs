namespace ConsoleApp1
{
    public class Kilometers
    {
        public int Value;
        public Kilometers(int value)
        {
            Value = value;
        }
           
        public void SaveValueToFile(string path, int value)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(value.ToString());
            sw.Close();
        }

        public int ConvertToMeters()
        {
            return Value * 1000;
        }
    }
}
