//(cwe347)
using JWT;

public static void decode(IJwtDecoder decoder)
{
    decoder.Decode(token, secret, verify: false); // Noncompliant
}