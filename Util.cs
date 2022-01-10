using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    class Util
    {

       private static readonly Random _getRandom = new Random();

        public static int RandomNumber()
        {
            int num;
            lock (_getRandom) // synchronize
            {
                num = _getRandom.Next(int.MinValue, int.MaxValue);
            }
            return num;
        }

        public static string RandomString(int length)
        {
            //const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[_getRandom.Next(s.Length)]).ToArray());
        }
    }
}
