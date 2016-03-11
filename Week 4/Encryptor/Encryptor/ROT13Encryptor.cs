using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public class ROT13Encryptor : IEncryptor
    {
        public string EncryptString(string stringToEncrypt)
        {
            //convert to char so can move forward
            char[] charArrayToEncrypt = stringToEncrypt.ToCharArray();
            for (int i = 0; i < charArrayToEncrypt.Length; i++ )
            {
                int charint = charArrayToEncrypt[i];
                //makes sure it stays in the alphabet
                if (charint >= 'A' && charint <= 'Z')
                {
                    if (charint > 'M')
                    {
                        charint = charint - 13;
                    }
                    else
                    {
                        charint = charint + 13;
                    }
                }
                else
                {
                    if (charint > 'm')
                    {
                        charint = charint - 13;
                    }
                    else
                    {
                        charint = charint + 13;
                    }
                }
                charArrayToEncrypt[i] = (char)charint;
            }
            string encrypted = new string(charArrayToEncrypt);
            return encrypted;
        }
        public string DecryptString(string stringToDecrypt)
        {
            //convert to char so can move forward
            char[] charArrayToDecrypt = stringToDecrypt.ToCharArray();
            for (int i = 0; i < charArrayToDecrypt.Length; i++)
            {
                int charint = charArrayToDecrypt[i];
                //makes sure it stays in the alphabet
                if (charint >= 'A' && charint <= 'Z')
                {
                    if (charint > 'M')
                    {
                        charint = charint + 13;
                    }
                    else
                    {
                        charint = charint - 13;
                    }
                }
                else
                {
                    if (charint > 'm')
                    {
                        charint = charint + 13;
                    }
                    else
                    {
                        charint = charint - 13;
                    }
                }
                charArrayToDecrypt[i] = (char)charint;
            }
            string decrypted= new string(charArrayToDecrypt);
            return decrypted;
        }
    }
}
