using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public class Encryptor
    {
        public IEncryptor encryption { get; set; }

        public string EncryptInputText(string input)
        {
            return encryption.EncryptString(input);
        }

        public string DecryptInputText(string input)
        {
            return encryption.DecryptString(input);
        }
    }
}
