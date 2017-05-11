using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    class Binary_to_Text__ASCII__Conversion
    {
        public static string BinaryToString(string binary)
        {
            var byteText = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                byteText.Add(Convert.ToByte(binary.Substring(i, 8), 2));
            }

            return Encoding.ASCII.GetString(byteText.ToArray());
        }

    }
}
