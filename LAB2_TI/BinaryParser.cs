using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_TI
{
    internal class BinaryParser
    {

        public static byte[] GetBytes(string input)
        {
            byte[] result = Encoding.UTF8.GetBytes(input);
            return result;
        }

        public static BitArray GetBits(string input)
        {
            BitArray bits = new BitArray(input.Length);
            for (int i = 0; i < input.Length; i++)
                bits[i] = input[i] == '1';
            return bits;
        }

        public static string GetExtension(string fullPath)
        {
            string extension = "";
            bool found = false;
            for (int i = 0; i < fullPath.Length; i++)
            {
                if (fullPath[i] == '.')
                    found = true;
                if (found)
                    extension += fullPath[i];
            }
            return extension;
        }

        public static string GetStringByBytes(byte[] rawBytes, bool showAll)
        {
            StringBuilder sb = new StringBuilder(rawBytes.Length * 8);
            if ((rawBytes.Length >= 18) && !showAll)
            {
                for (int i = 0; i < 9; i++)
                {
                    sb.Append(Convert.ToString(rawBytes[i], 2).PadLeft(8, '0'));
                    sb.Append(" ");
                }
                sb.Append("\r\n...\r\n");
                for (int i = rawBytes.Length - 9; i < rawBytes.Length; i++)
                {
                    sb.Append(Convert.ToString(rawBytes[i], 2).PadLeft(8, '0'));
                    sb.Append(" ");
                }
            }
            else
            {
                for (int i = 0; i < rawBytes.Length; i++)
                {
                    sb.Append(Convert.ToString(rawBytes[i], 2).PadLeft(8, '0'));
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }

        public static string GetCorrectString(string text)
        {
            string filtered = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '1' || text[i] == '0')
                    filtered += text[i];
            }
            return filtered;
        }
    }
}
