//(cwe327)
using System.Security.Cryptography;

public void encrypt()
{
    RSACryptoServiceProvider RsaCsp = new RSACryptoServiceProvider();
    byte[] encryptedData            = RsaCsp.Encrypt(dataToEncrypt, false); // Noncompliant
}