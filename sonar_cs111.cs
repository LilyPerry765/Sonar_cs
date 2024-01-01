//(cwe327)
public class CustomHash : HashAlgorithm // Noncompliant
{
    private byte[] result;

    public override void Initialize() => result = null;
    protected override byte[] HashFinal() => result;

    protected override void HashCore(byte[] array, int ibStart, int cbSize) =>
        result ??= array.Take(8).ToArray();
}