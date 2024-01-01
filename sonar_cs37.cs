//(cwe327)
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;

public void encrypt()
{
    AesFastEngine aesFast = new AesFastEngine(); // Noncompliant
}