//(cwe347)
using JWT;

public static void decode()
{
    var jwt = new JwtBuilder()
        .WithSecret(secret)
        .Decode(token); // Noncompliant
}