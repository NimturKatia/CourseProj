using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Vernam
    {
        public static string Encrypt(string text, 
                                     string key)
        {
            byte[] textArr = Encoding.ASCII.GetBytes(text);
            byte[] keyArr  = Encoding.ASCII.GetBytes(key);
            for (int i = 0; i < textArr.Length; i++)
                textArr[i] = (byte)(textArr[i] ^ keyArr[i]);
            
            return Encoding.ASCII.GetString(textArr);
        }

        public static string genKey(int length)
        {
            Random rand = new Random();
            string key = "";
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!&, .";
            for (int i = 0; i < length; i++)
                key += abc[rand.Next(abc.Length-1)];
            return key;
        }
    }
}
