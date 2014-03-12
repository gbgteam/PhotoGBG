using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    public class EncryprDecrypt
    {
        private static EncryprDecrypt instance;
        private EncryprDecrypt() { }
        public static EncryprDecrypt Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EncryprDecrypt();
                }
                return instance;
            }
        }
        public string encryptPass(string text, string key)
        {
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)key[c % key.Length]));

            return result.ToString();
        }

        static void Main()
        {
            EncryprDecrypt e = new EncryprDecrypt();
            string s=e.encryptPass("alex", "pass");
            System.Console.WriteLine(s);
            s = e.encryptPass(s, "pass");
            System.Console.WriteLine(s);
            System.Console.Read();
        }

    }

    

}
