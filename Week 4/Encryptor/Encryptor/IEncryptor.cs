﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    public interface IEncryptor
    {
        string EncryptString(string stringToEncrypt);
    }
}
