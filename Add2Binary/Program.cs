using System;

namespace Add2Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = AddBinary("1010","1011");
            Console.Write(result);
        }


        static public string AddBinary(string a, string b)
        {
            var one= Convert.ToInt32(a, 2);
            var two= Convert.ToInt32(b, 2);

            var result = Convert.ToString(one + two, 2);
            return result;
        }
    }
}
