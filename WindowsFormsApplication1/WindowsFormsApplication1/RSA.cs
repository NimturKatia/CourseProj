using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace WindowsFormsApplication1
{
    class RSA
    {
        int phi, e, d, n;
        Random rand = new Random();

        public bool isPrime(int n)//check for prime num
        {

            if (n == 2)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;
            for (int i = 3; i < Math.Round((double)n); i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }

        private int multiplicateInverse(int e, int phi)
        {
            int d1 = 0;
            int x1 = 0;
            int x2 = 1;
            int y1 = 1;
            int tempPhi = phi;
            int temp1, temp2;
            int x, y;
            while (e > 0)
            {
                temp1 = tempPhi / e;
                temp2 = tempPhi - temp1 * e;
                tempPhi = e;
                e = temp2;

                x = x2 - temp1 * x1;
                y = d1 - temp1 * y1;

                x2 = x1;
                x1 = x;
                d1 = y1;
                y1 = y;
            }

            if (tempPhi == 1)
                return d1 + phi;
            return 1;
        }

        public List<int> generatePairs(int p, int q)
        {
            if (!isPrime(p) && !isPrime(q))
                throw new Exception();
            else if (p == q)
                throw new Exception();
            List<int> pairs = new List<int>();
            n = p * q;                // Compute n
            phi = (p - 1) * (q - 1);    // Compute phi(n)

            e = rand.Next(2, phi);
            int g = gcd(e, phi);
            while (g != 1)
            {
                e = rand.Next(2, phi);
                g = gcd(e, phi);
            }

            d = multiplicateInverse(e, phi);
            pairs.Add(n);                        
            pairs.Add(e);                        
            pairs.Add(d);                        

            return pairs;
        }

        public int[] Encrypt(List<int> pairs, string text)
        {
            byte[] textArr = Encoding.Unicode.GetBytes(text);
            int[] crypted = new int[textArr.Length];
            for (int i = 0; i < textArr.Length; i++)
            {
                crypted[i] = (int)BigInteger.ModPow(textArr[i], pairs[1], pairs[0]);
            }

            return crypted;
        }

        public string Decrypt(List<int> pairs, int[] arr)
        {
            byte[] bArr = new byte[arr.Length];
            int[] iArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                iArr[i] = (int)BigInteger.ModPow(arr[i], pairs[2], pairs[0]);
                bArr[i] = (byte)iArr[i];
            }


            return Encoding.Unicode.GetString(bArr);
        }

    }
}
