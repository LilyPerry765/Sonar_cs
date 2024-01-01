//(cwe20), (cwe22)
private static string TargetDirectory = "/Users/John";

public void Example(string filename)
{
    string canonicalDestinationPath = Path.GetFullPath(filename);

    if (canonicalDestinationPath.StartsWith(TargetDirectory, StringComparison.Ordinal))
    {
        System.IO.File.Delete(canonicalDestinationPath);
    }
}