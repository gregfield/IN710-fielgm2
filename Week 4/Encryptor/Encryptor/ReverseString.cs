using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public class ReverseString : IEncryptor
    {
        public string EncryptString(string stringToReverse)
        {
            char[] charArrayToReverse = stringToReverse.ToCharArray();
            //reverses the string
            Array.Reverse(charArrayToReverse);
            string encrypted = new string(charArrayToReverse);
            return encrypted;
        }
        public string DecryptString(string stringToReverse)
        {
            char[] charArrayToReverse = stringToReverse.ToCharArray();
            //reverses the string
            Array.Reverse(charArrayToReverse);
            string decrypted = new string(charArrayToReverse);
            return decrypted;
        }
    }
}
