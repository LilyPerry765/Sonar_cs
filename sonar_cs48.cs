//(cwe326), (cwe327)
using System;
using System.Security.Cryptography;

public void encrypt()
{
    var RsaCsp = new RSACryptoServiceProvider(); // Noncompliant
}