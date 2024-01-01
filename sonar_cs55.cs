//(cwe327)
using System.Net.Http;
using System.Security.Authentication;

public void encrypt()
{
    new HttpClientHandler
    {
        SslProtocols = SslProtocols.Tls // Noncompliant
    };
}