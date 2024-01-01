//(cwe327)
using System.Net;

public void encrypt()
{
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls; // Noncompliant
}