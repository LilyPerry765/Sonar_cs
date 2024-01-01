//(cwe326), (cwe327)
using System;
using System.Security.Cryptography;

public void encrypt()
{
    ECDsa ecdsa = ECDsa.Create(ECCurve.NamedCurves.brainpoolP160t1); // Noncompliant
}